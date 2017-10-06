using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class CandyShop
    {
        public int sugarAmount;
        public double money;

        public CandyShop()
        {
            this.money = 300;
            this.sugarAmount = 330;
        }

        List<Sweets> inventory = new List<Sweets>();

        public void CreateSweets(Sweets inventory)
        {
            
        }
    }  
}
