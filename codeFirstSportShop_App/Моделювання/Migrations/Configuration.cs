namespace Моделювання.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Моделювання.DataAccess;
    using Моделювання.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<Моделювання.DataAccess.SportShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Моделювання.DataAccess.SportShopContex";           
        }

        protected override void Seed(Моделювання.DataAccess.SportShopContext context)
        {
            var products = new List<SportItem>
             {
                 new SportItem { Name = @"Протеін", Price = 10.50m,
                 Description = @"Стань великим та сильним"},
                 new SportItem { Name = @"Кадеін", Price = 10.20m,
                 Description = @"Нехай твої мишци швидке відновляться"},
                 new SportItem { Name = @"Л-Карнітин", Price = 9.80m,
                 Description = @"Увесь час у тебе буде енергія"}
             };


            products.ForEach(p => context.SportItems.AddOrUpdate(t => t.Name, p));
            context.SaveChanges();

            var manufacturers = new List<SportShop>
             {
                 new SportShop { Name = @"Gym Beam",
                 Address = @"вул. Гв. Широнінців, 1"},
                 new SportShop { Name = @"Titan",
                 Address = @"вул. Шкільна, 18"}
             };

            manufacturers.ForEach(m => context.SportShops.AddOrUpdate(t => t.Name, m));
            context.SaveChanges();

            var sales = new List<ItemDoc>
             {
                 new ItemDoc { Date = DateTime.Parse("01.09.2020"),
                 SportShopId =1,
                 SportItemId = 1,
                 Count = 200 },
                 new ItemDoc { Date = DateTime.Parse("01.09.2020"),
                 SportShopId =1,
                 SportItemId = 2,
                 Count=250 },
                 new ItemDoc { Date = DateTime.Parse("01.09.2020"),
                 SportShopId =2,
                 SportItemId = 1,
                 Count=150 }
             };

            foreach (ItemDoc s in sales)
            {
                var saleInDB = context.ItemDocs.Where(
                p => p.SportItemId == s.SportItemId &&
                p.SportShopId == s.SportShopId &&
                p.Date == s.Date).SingleOrDefault();
                if (saleInDB == null)
                {
                    context.ItemDocs.Add(s);
                }
            }

            context.SaveChanges();

            //***********
            // Inovices *
            //***********
            // Нові сутності
            var invoices = new List<Waybill>
             {
                 new Waybill
                 {
                    Number = "101",
                    Date = DateTime.Parse("10.04.2023"),
                    SportShopId = 1
                 },
                 new Waybill
                 {
                     Date = DateTime.Parse("11.04.2023"),
                     SportShopId =2
                 }
             };
            // Перевіряємо рядки на дублювання накладних
            foreach (Waybill i in invoices)
            {
                var invoiceInDB = context.Waybills.Where(
                n => n.Date == i.Date &&
                n.SportShopId == i.SportShopId
                ).FirstOrDefault();
                if (invoiceInDB == null)
                {
                    context.Waybills.Add(i);
                }
            }
            context.SaveChanges();

            int inoviceID = context.Waybills.Where(
             n => n.Number == "101" && n.SportShopId == 1).SingleOrDefault().WaybillId;
            // Додаємотовари
            var invoiceProducts = new List<WaybillItem>
            {
                // Товари накладних через їхні ID
                 new WaybillItem
                 { WaybillId =inoviceID,
                 SportItemId=1, Count=200},
                 new WaybillItem
                 { WaybillId=inoviceID,
                 SportItemId=2, Count=260},
            };
            // Перевіряємо рядки на дублювання товарів у накладній
            foreach (WaybillItem ip in invoiceProducts)
            {
                var invoiceProductInDB = context.WaybillItems.Where(
                 nt => nt.WaybillId == ip.WaybillId &&
                 nt.SportItemId == ip.SportItemId).FirstOrDefault();
                if (invoiceProductInDB == null)
                {
                    context.WaybillItems.Add(ip);
                }
            }
            context.SaveChanges();
            // 2. Додавання товарів до нової накладної, отримані
            // від виробника з кодом 2.
            /*invoices = new List<Waybill>
            {
                 new Waybill
                 {
                     Number="102",
                     Date=DateTime.Parse("11.04.2022"),
                     SportShopId=1,
                     WaybillItems=new List<WaybillItem>
                     // Товари накладних через їхні назви (LINQ)
                     {
                         new WaybillItem
                         {
                             SportItemId=products.Single( p => p.Name ==
                             @"Протеін").SportItemId,
                             Count=230
                         },
                     }
                 }
            };
            // Перевіряємо рядки на дублювання накладних
            foreach (Waybill i in invoices)
            {
                var invoiceInDB = context.Waybills.Where(
                n => n.Date == i.Date && n.SportShopId == i.SportShopId
                ).FirstOrDefault();
                if (invoiceInDB == null)
                {
                    context.Waybills.Add(i);
                }
            }
            context.SaveChanges();*/
        }
    }
}
