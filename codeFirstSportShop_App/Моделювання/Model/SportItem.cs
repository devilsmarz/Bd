using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделювання.Model
{
    public class SportItem
    {
        public int SportItemId { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        public virtual IEnumerable<ItemDoc> ItemDocs { get; set; }
        public virtual IEnumerable<WaybillItem> WaybillItems { get; set; }
    }
}
