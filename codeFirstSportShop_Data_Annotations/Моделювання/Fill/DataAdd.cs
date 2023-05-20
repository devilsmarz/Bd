using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Моделювання.DataAccess;
using Моделювання.Model;

namespace Моделювання.Fill
{
    public class DataAdd
    {
        public static void FillDb(out int nItems, out int nSportShop, out int nDocs)
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

            using (var context = new SportShopContex())
            {
                products.ForEach(p => context.SportItems.Add(p));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nItems = context.SportItems.Count();
            }
            var manufacturers = new List<SportShop>
             {
                 new SportShop { Name = @"Gym Beam",
                 Address = @"вул. Гв. Широнінців, 1"},
                 new SportShop { Name = @"Titan",
                 Address = @"вул. Шкільна, 18"}
             };
            using (var context = new SportShopContex())
            {
                manufacturers.ForEach(m => context.SportShops.Add(m));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nSportShop = context.SportShops.Count();
            }
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

            using (var context = new SportShopContex())
            {
                sales.ForEach(s => context.ItemDocs.Add(s));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nDocs = context.ItemDocs.Count();
            }
        }
    }
}
