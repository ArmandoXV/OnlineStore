using OnlineStore.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
