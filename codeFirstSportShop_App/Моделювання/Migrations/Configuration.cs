namespace Моделювання.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Моделювання.DataAccess;
    using Моделювання.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<Моделювання.DataAccess.ClothShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Моделювання.DataAccess.ClothShopContext";           
        }

        protected override void Seed(Моделювання.DataAccess.ClothShopContext context)
        {
            var products = new List<Cloth>
             {
                 new Cloth { Name = @"Куртка", Price = 10.50m,
                 Description = @"Кожана та комфортна"},
                 new Cloth { Name = @"Шорти", Price = 10.20m,
                 Description = @"Можна плавати"},
                 new Cloth { Name = @"Тапки", Price = 9.80m,
                 Description = @"В'єтнамки"}
             };


            products.ForEach(p => context.ClothItems.AddOrUpdate(t => t.Name, p));
            context.SaveChanges();

            var manufacturers = new List<ClothShop>
             {
                 new ClothShop { Name = @"Zara",
                 Address = @"вул. Героїв Харкова 89"},
                 new ClothShop { Name = @"Cotlin",
                 Address = @"вул. Харківська 11"}
             };

            manufacturers.ForEach(m => context.ClothShops.AddOrUpdate(t => t.Name, m));
            context.SaveChanges();

            var sales = new List<ClothDoc>
             {
                 new ClothDoc { Date = DateTime.Parse("02.08.2022"),
                 ClothShopId =1,
                 ClothId = 1,
                 Count = 200 },
                 new ClothDoc { Date = DateTime.Parse("02.08.2021"),
                 ClothShopId =1,
                 ClothId = 2,
                 Count=250 },
                 new ClothDoc { Date = DateTime.Parse("02.05.2023"),
                 ClothShopId =2,
                 ClothId = 1,
                 Count=150 }
             };

            foreach (ClothDoc s in sales)
            {
                var saleInDB = context.ClothDocs.Where(
                p => p.ClothId == s.ClothId &&
                p.ClothShopId == s.ClothShopId &&
                p.Date == s.Date).SingleOrDefault();
                if (saleInDB == null)
                {
                    context.ClothDocs.Add(s);
                }
            }

            context.SaveChanges();

            //***********
            // Inovices *
            //***********
            // Нові сутності
            var invoices = new List<Invoice>
             {
                 new Invoice
                 {
                    Number = "101",
                    Date = DateTime.Parse("13.02.2023"),
                    ClothShopId = 1
                 },
                 new Invoice
                 {
                     Date = DateTime.Parse("01.02.2021"),
                     ClothShopId =2
                 }
             };
            // Перевіряємо рядки на дублювання накладних
            foreach (Invoice i in invoices)
            {
                var invoiceInDB = context.Invoices.Where(
                n => n.Date == i.Date &&
                n.ClothShopId == i.ClothShopId
                ).FirstOrDefault();
                if (invoiceInDB == null)
                {
                    context.Invoices.Add(i);
                }
            }
            context.SaveChanges();

            int inoviceID = context.Invoices.Where(
             n => n.Number == "101" && n.ClothShopId == 1).SingleOrDefault().InvoiceId;
            // Додаємотовари
            var invoiceProducts = new List<InvoiceItem>
            {
                // Товари накладних через їхні ID
                 new InvoiceItem
                 { InvoiceId =inoviceID,
                 ClothId=1, Count=200},
                 new InvoiceItem
                 { InvoiceId=inoviceID,
                 ClothId=2, Count=260},
            };
            // Перевіряємо рядки на дублювання товарів у накладній
            foreach (InvoiceItem ip in invoiceProducts)
            {
                var invoiceProductInDB = context.InvoicesItems.Where(
                 nt => nt.InvoiceId == ip.InvoiceId &&
                 nt.ClothId == ip.ClothId).FirstOrDefault();
                if (invoiceProductInDB == null)
                {
                    context.InvoicesItems.Add(ip);
                }
            }
            context.SaveChanges();
            // 2. Додавання товарів до нової накладної, отримані
            // від виробника з кодом 2.
            /*invoices = new List<Invoice>
            {
                 new Invoice
                 {
                     Number="102",
                     Date=DateTime.Parse("11.04.2022"),
                     ClothShopId=1,
                     InvoicesItems=new List<InvoiceItem>
                     // Товари накладних через їхні назви (LINQ)
                     {
                         new InvoiceItem
                         {
                             ClothId=products.Single( p => p.Name ==
                             @"Протеін").ClothId,
                             Count=230
                         },
                     }
                 }
            };
            // Перевіряємо рядки на дублювання накладних
            foreach (Invoice i in invoices)
            {
                var invoiceInDB = context.Invoices.Where(
                n => n.Date == i.Date && n.ClothShopId == i.ClothShopId
                ).FirstOrDefault();
                if (invoiceInDB == null)
                {
                    context.Invoices.Add(i);
                }
            }
            context.SaveChanges();*/
        }
    }
}
