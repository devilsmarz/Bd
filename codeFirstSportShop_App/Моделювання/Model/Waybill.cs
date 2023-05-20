using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделювання.Model
{
    public class Waybill
    {
        public int WaybillId { get; set; }
        [MaxLength(12)]
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public int SportShopId { get; set; }

        public virtual SportShop SportShop { get; set; }
        //public virtual IEnumerable<WaybillItem> WaybillItems { get; set; }
        private readonly ObservableListSource<WaybillItem> waybillItems = new ObservableListSource<WaybillItem>();
        public virtual IEnumerable<WaybillItem> WaybillItems => waybillItems;
    }
}
