using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsofsalesapp1;
using pointsofsalesapp1.BL;

namespace pointsofsalesapp1
{
    class ProductDL
    {
        public static void AddProductsintoList(Product p)
        {
            Product.productlist.Add(p);
        }
        public static Product highest_priceProduct()
        {

            List<Product> sortedlist = new List<Product>();

            sortedlist = Product.productlist.OrderByDescending(o => o.Productprice).ToList();
            return sortedlist[0];


        }
    }
}
