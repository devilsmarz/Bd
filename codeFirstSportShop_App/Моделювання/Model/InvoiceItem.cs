using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделювання.Model
{
    public class InvoiceItem
    {
        public int InvoiceItemId { get; set; }
        public int InvoiceId { get; set; }
        public int ClothId { get; set; }
        public int Count { get; set; }
        // Властивості навігації
        public virtual Cloth Cloth { get; set; }
        public virtual Invoice Invoice { get; set; }
        // Обчислювана властивість
        [NotMapped]
        public decimal Вартість => Cloth != null ? Cloth.Price * Count : 0;
    }
}
