using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreInfo
{
    public class CarListViewModel : EntityBase
    {
        [DisplayName("Brand")]
        public string BrandName { get; set; }
        [DisplayName("Model")]
        public string ModelName { get; set; }
        [DisplayName("Price")]
        public int Price { get; set; }
        [DisplayName("Color")]
        public string ColorName { get; set; }
        [Browsable(false)]
        public bool IsDeleted { get; set; }
    }
}
