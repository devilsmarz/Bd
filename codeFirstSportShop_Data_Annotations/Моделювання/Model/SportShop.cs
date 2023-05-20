using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделювання.Model
{
    public class SportShop
    {
        public int SportShopId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Address { get; set; }

        public virtual IEnumerable<ItemDoc> ItemDocs { get; set; }
    }
}
