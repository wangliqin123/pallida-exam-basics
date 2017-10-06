using System.Collections.Generic;

namespace TakeMeToThe
{
    class CandyShop
    {
        Sweets sweets = new Sweets();

        public int sugarAmount;
        public double money;
        public int sugarPrice;


        public CandyShop()
        {
            this.money = 300;
            this.sugarAmount = 330;
            this.sugarPrice = 100;
        }

        List<Sweets> inventory = new List<Sweets>();

        public void BuySugar(int boughtSugarGramm)
        {
            money = money - (boughtSugarGramm / sugarPrice * 10);
            sugarAmount = sugarAmount + boughtSugarGramm;
        }
        public void CreateSweets()
        {

        }

        public void PrintInfo()
        {

        }

        public void Sell()
        {

        }

        public void Raise(int raiseNumber)
        {
            sweets.price = sweets.price * raiseNumber;
        }
    }
}

