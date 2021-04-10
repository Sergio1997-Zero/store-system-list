using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_system
{
    public class Product
    {
        public string Name;
        public double Price;
        public int ID;
        public int Stock;

 
        public int Unist()
        {
            int stock = 0;
            stock = stock + 1;

            return stock;
        }

        public double totalGet()
        {
            return Price;
        }
    }
}
