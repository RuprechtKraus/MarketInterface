using System;
using MarketLib;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket market = new SuperMarket(10000);
            Random rand = new();
            Item apple = new("Apple", 10, rand.Next(1, int.MaxValue));
            Item tv = new("Plasma screen", 1000, rand.Next(1, int.MaxValue));
            Employee jane = new("Jane", rand.Next(1, int.MaxValue));
            Employee bob = new("Bob", rand.Next(1, int.MaxValue));

            market.Buy(apple);
            market.Buy(apple);
            market.Buy(apple);

            market.Buy(tv);
            market.Buy(tv);

            Console.Write($"Market budget after purchase: {market.Budget}");
            Console.WriteLine();
            Console.WriteLine("Market stock:");
            Console.WriteLine();
            market.printStock();
            Console.WriteLine("-------------");
            Console.WriteLine();

            market.Sell(apple);
            market.Sell(apple);
            market.Sell(apple);

            market.Sell(tv);
            market.Sell(tv);

            Console.WriteLine($"Market budget after selling: {market.Budget}");
            Console.Write("Market stock: ");
            market.printStock();
        }
    }
}
