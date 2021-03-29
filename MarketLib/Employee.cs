using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLib
{
    public class Employee : IPerson
    {
        private string _name;
        private readonly int _id;

        public string Name => _name;

        public int Id => _id;

        public Employee(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {_name}!");
        }
    }
}
