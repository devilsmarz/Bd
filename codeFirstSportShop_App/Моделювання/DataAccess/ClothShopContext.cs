using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Моделювання.Model;

namespace Моделювання.DataAccess
{
    public class ClothShopContext : DbContext
    {
        public DbSet<ClothShop> ClothShops { get; set; }
        public DbSet<Cloth> ClothItems { get; set; }
        public DbSet<ClothDoc> ClothDocs { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoicesItems { get; set; }
    }
}
