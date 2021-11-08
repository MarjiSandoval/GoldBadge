using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery_Lib
{
    public enum ProductType { Bread, Cake, Pastry, Pie}
    public abstract class Product
    {
        public Product()
        {
        }

        public decimal Price { get; protected set; }
        public ProductType ProductType { get; protected set; }

    }
}
