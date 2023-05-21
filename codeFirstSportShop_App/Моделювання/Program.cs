using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Моделювання.DataAccess;
using Моделювання.Fill;
using Моделювання.Migrations;

namespace Моделювання
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Стратегія роботи з базою даних
                Database.SetInitializer(
                new DropCreateDatabaseAlways<ClothShopContext>());
                // Описуємо фактичні параметри методу FillDB
                int nProduct;
                int nManufacturer;
                int nSale;
                // Викликаємо метод
                DataAdd.FillDb(out nProduct, out nManufacturer,
                out nSale);
                // Виводимо результат
                Console.WriteLine(
                "Базу даних на SQL Server створено і заповнено.\n"
                + "У таблиці записано таку кількість рядків:\n"
                + "ClothItems - " + nProduct
                + ", ClothShops - " + nManufacturer
                + ", ClothDocs - " + nSale
                + ".\n Перевірте!!!");


                // Реєстрування ініціалізатора бази даних
                Database.SetInitializer(new
                 MigrateDatabaseToLatestVersion<ClothShopContext, Configuration>());
                using (var context = new ClothShopContext())
                {
                    foreach (var p in context.ClothItems)
                    {
                        Console.WriteLine(p.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                // Виводимо повідомлення про помилку
                Console.WriteLine("Базу даних не створено. \n Помилка:\n "
                + ex.ToString());
            }

            // Виводимо повідомлення про подальші дії
            Console.WriteLine("Натисніть будь-яку клавішу, щоб вийти...");
            Console.ReadKey();
        }
    }
}
