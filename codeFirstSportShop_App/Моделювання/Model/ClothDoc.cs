using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделювання.Model
{
    public class ClothDoc
    {
        public int ClothDocId { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Required]
        public int Count { get; set; }

        public int ClothId { get; set; }
        public int ClothShopId { get; set; }

        public virtual ClothShop ClothShop { get; set; }
        public virtual Cloth Cloth { get; set; }

        [NotMapped]
        public decimal Вартість => Cloth != null ? Cloth.Price * Count : 0;
    }
}
