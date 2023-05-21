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
        public static void FillDb(out int nItems, out int nClothShop, out int nDocs)
        {
            var products = new List<Cloth>
             {
                 new Cloth { Name = @"Куртка", Price = 12.40m,
                 Description = @"Кожана та комфортна"},
                 new Cloth { Name = @"Шорти", Price = 17.80m,
                 Description = @"Можна плавати"},
                 new Cloth { Name = @"Тапки", Price = 5.40m,
                 Description = @"В'єтнамки"}
             };

            using (var context = new ClothShopContext())
            {
                products.ForEach(p => context.ClothItems.Add(p));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nItems = context.ClothItems.Count();
            }
            var manufacturers = new List<ClothShop>
             {
                 new ClothShop { Name = @"Zara",
                 Address = @"вул. Героїв Харкова 89"},
                 new ClothShop { Name = @"Cotlin",
                 Address = @"вул. Харківська 11"}
             };
            using (var context = new ClothShopContext())
            {
                manufacturers.ForEach(m => context.ClothShops.Add(m));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nClothShop = context.ClothShops.Count();
            }
            var sales = new List<ClothDoc>
             {
                 new ClothDoc { Date = DateTime.Parse("02.08.2022"),
                 ClothShopId =1,
                 ClothId = 1,
                 Count = 145 },
                 new ClothDoc { Date = DateTime.Parse("02.08.2021"),
                 ClothShopId =1,
                 ClothId = 2,
                 Count=345 },
                 new ClothDoc { Date = DateTime.Parse("02.05.2023"),
                 ClothShopId =2,
                 ClothId = 1,
                 Count=150 },
                 new ClothDoc { Date = DateTime.Parse("02.05.2023"),
                 ClothShopId =2,
                 ClothId = 2,
                 Count=123 }

             };

            using (var context = new ClothShopContext())
            {
                sales.ForEach(s => context.ClothDocs.Add(s));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nDocs = context.ClothDocs.Count();
            }
        }
    }
}
