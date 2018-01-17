using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreInfo
{
    public class CarInfo : EntityBase
    {
        public int Price { get; set; }
        public string ColorName { get; set; }
        public int ModelId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
