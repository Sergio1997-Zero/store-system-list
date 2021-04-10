using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_system
{
    public class Sale
    {
        
        public double TotalPrice;
        public Product Product;
        public Client Client;
        public double TotalSale;

        public double Totalsale()
        {
            return TotalSale;
        }
    }
}
