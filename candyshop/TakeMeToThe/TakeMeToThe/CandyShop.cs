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
        public int sugarPrice;
        public int boughtSugarGramm;

        public CandyShop()
        {
            this.money = 300;
            this.sugarAmount = 330;
            this.sugarPrice = 100;
        }

        List<Sweets> inventory = new List<Sweets>();

        public double BuySugar(int boughtSugarGramm)
        {
            money = money - (boughtSugarGramm /sugarPrice * 10);
            sugarAmount = sugarAmount + boughtSugarGramm;
        }
    }  
}