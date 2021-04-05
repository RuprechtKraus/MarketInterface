using System;
using MarketLib;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket market = new SuperMarket(10000);
            Random rand = new Random();
            Item apple = new Item("Apple", 10, rand.Next(1, int.MaxValue));
            Item tv = new Item("Plasma screen", 1000, rand.Next(1, int.MaxValue));
            Employee jane = new Employee("Jane", rand.Next(1, int.MaxValue));
            Employee bob = new Employee("Bob", rand.Next(1, int.MaxValue));

            jane.SayHello();
            bob.SayHello();
            Console.WriteLine();

            market.Buy(apple);
            market.Buy(apple);
            market.Buy(apple);

            market.Buy(tv);
            market.Buy(tv);

            Console.Write($"Market budget after purchase: {market.Budget}");
            Console.WriteLine();
            Console.WriteLine("Market stock:");
            Console.WriteLine();
            market.PrintStock();
            Console.WriteLine("-------------");
            Console.WriteLine();

            market.Sell(apple);
            market.Sell(apple);
            market.Sell(apple);

            market.Sell(tv);
            market.Sell(tv);

            Console.WriteLine($"Market budget after selling: {market.Budget}");
            Console.Write("Market stock: ");
            market.PrintStock();
        }
    }
}
