using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLib
{
    public class Item : IItem
    {
        private string _name;
        private int _price;
        private readonly int _code;

        public string Name 
        {
           get
           {
               return _name;
           }

            set
            {
                _name = value;
            }
        }
        public int Price
        { 
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }
        public int Code => _code;

        public Item(string name, int price, int code)
        {
            _name = name;
            _price = price;
            _code = code;
        }

        public Item(Item item)
        {
            _name = item.Name;
            _price = item.Price;
            _code = item.Code;
        }
    }
}
