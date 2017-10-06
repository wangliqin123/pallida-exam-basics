namespace TakeMeToThe
{
    class Program
    {
        static void Main(string[] args)
        {
            CandyShop candyShop = new CandyShop();

            candyShop.CreateSweets();
            candyShop.PrintInfo();
            candyShop.Raise(5);
            candyShop.PrintInfo();
            candyShop.BuySugar(200);
        }
    }
}