using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14
{
    public enum ProductTypes
    {
        Food,
        Appliances
    }

    public class Products
    {
        public string ProductsName { get; set; }
        public int Price { get; set; }
        public ProductTypes ProductType { get; set; }
        public int Jpeg { get; set; }

        public override string ToString()
        {
            return ProductsName;
        }
    }
}
