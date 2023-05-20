using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделювання.Model
{
    public class WaybillItem
    {
        public int WaybillItemId { get; set; }
        public int WaybillId { get; set; }
        public int SportItemId { get; set; }
        public int Count { get; set; }
        // Властивості навігації
        public virtual SportItem SportItem { get; set; }
        public virtual Waybill Waybill { get; set; }
        // Обчислювана властивість
        [NotMapped]
        public decimal Вартість => SportItem != null ? SportItem.Price * Count : 0;
    }
}
