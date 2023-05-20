using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Моделювання.Model;

namespace Моделювання.DataAccess
{
    public class SportShopContext : DbContext
    {
        public DbSet<SportShop> SportShops { get; set; }
        public DbSet<SportItem> SportItems { get; set; }
        public DbSet<ItemDoc> ItemDocs { get; set; }
        public DbSet<Waybill> Waybills { get; set; }
        public DbSet<WaybillItem> WaybillItems { get; set; }
    }
}
