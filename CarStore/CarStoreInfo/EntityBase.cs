﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreInfo
{
    public abstract class EntityBase
    {
        [Browsable(false)]
        public int ID { get; set; }
    }
}
