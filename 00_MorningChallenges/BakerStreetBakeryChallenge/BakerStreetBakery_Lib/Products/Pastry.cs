using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery_Lib
{
    public class Pastry : Product
    {
        public Pastry()
        {
            Price = 200.10m;
            ProductType = ProductType.Pastry;
        }
    }
}
