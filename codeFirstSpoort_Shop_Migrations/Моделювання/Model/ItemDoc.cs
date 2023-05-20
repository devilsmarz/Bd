using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделювання.Model
{
    public class ItemDoc
    {
        public int ItemDocId { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Required]
        public int Count { get; set; }

        public int SportItemId { get; set; }
        public int SportShopId { get; set; }

        public virtual SportShop SportShop { get; set; }
        public virtual SportItem SportItem { get; set; }

        [NotMapped]
        public decimal Вартість => SportItem != null ? SportItem.Price * Count : 0;
    }
}
