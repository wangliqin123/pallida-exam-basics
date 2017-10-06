using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class Sweets : CandyShop
    {
        public int price;
        public int commoditySugar;
        public double priceRaise;

        public double RaisingPrice()
        {
            return price * priceRaise;
        }
    }
}