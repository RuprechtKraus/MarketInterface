using System;
using System.Collections.Generic;

namespace MarketLib
{
    public class SuperMarket : IMarket
    {
        int _budget;
        List<Item> _stock = new();
        List<Employee> _employees = new();

        public int Budget => _budget;

        public SuperMarket(int startBudget = 1000000)
        {
            _budget = startBudget;
        }

        public SuperMarket(int startBudget, List<Item> startStock)
        {
            _budget = startBudget;
            _stock = startStock;
        }

        public void Sell(Item item)
        {
            Item itemInStock = _stock.Find(x => x.Code == item.Code);
            if (itemInStock != null)
            {
                _stock.Remove(itemInStock);
                _budget += itemInStock.Price;
            }
            else
                Console.WriteLine($"Item \"{item.Name}\" not found");
        }

        public void Buy(Item item)
        {
            if ((_budget - item.Price) >= 0)
            {
                _budget -= item.Price;
                Item itemToStock = new(item);
                itemToStock.Price += (item.Price / 4);
                _stock.Add(itemToStock);
            }
            else
            {
                Console.WriteLine($"Not enought money to buy \"{item.Name}\"");
                return;
            }
        }

        public void printStock()
        {
            if (_stock.Count == 0)
            {
                Console.WriteLine("Stock is empty");
                return;
            }

            foreach (var item in _stock)
            {
                Console.WriteLine($"Name: {item.Name}\nPrice: {item.Price}\nCode: {item.Code}");
                Console.WriteLine();
            }
        }

        public void printEmployees()
        {
            if (_employees.Count == 0)
            {
                Console.WriteLine("Not one hired");
                return;
            }

            foreach (var person in _employees)
            {
                Console.WriteLine($"Name: {person.Name}\nId: {person.Id}");
                Console.WriteLine();
            }
        }

        public void Hire(Employee person)
        {
            _employees.Add(person);
        }

        public void Fire(Employee employee)
        {
            Employee employeeToFire = _employees.Find(x => x.Id == employee.Id);
            if (employeeToFire != null)
            {
                _employees.Remove(employeeToFire);
                Console.WriteLine($"Employee {employeeToFire.Name} has been fired");
            }
            else
                Console.WriteLine($"Employee {employee.Name} with id {employee.Id} not found");
        }
    }
}
