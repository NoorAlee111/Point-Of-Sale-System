using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointsofsalesapp1.BL
{
    class Product
    {
        public string Productname;
        public string Productcategory;
        public float Productprice;
        public int Stock_Quantity;
        public int Mini_Stock_Quantity;
        public static List<Product> productlist = new List<Product>();
        
      public float tax()
        { 

            float tax;
            if (Productcategory == "Fruit")
            {
                tax = Productprice * 10 / 100F;
            }
            else if (Productcategory == "Grocery")
            {
                tax = Productprice * 5 / 100F;
            }
            else
            {
                tax =Productprice * 15 / 100F;
            }


            return tax;
        }

    }
}
