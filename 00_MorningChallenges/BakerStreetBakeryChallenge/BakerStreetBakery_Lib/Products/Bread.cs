using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery_Lib
{
    public class Bread: Product
    {
        public Bread()
        {
            Price = 500.01m;
            ProductType = ProductType.Bread;
        }
    }
}
