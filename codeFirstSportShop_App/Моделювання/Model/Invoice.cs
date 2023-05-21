using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделювання.Model
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        [MaxLength(12)]
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public int ClothShopId { get; set; }

        public virtual ClothShop ClothShop { get; set; }
        //public virtual IEnumerable<InvoiceItem> InvoicesItems { get; set; }
        private readonly ObservableListSource<InvoiceItem> InvoiceItems = new ObservableListSource<InvoiceItem>();
        public virtual IEnumerable<InvoiceItem> InvoicesItems => InvoiceItems;
    }
}
