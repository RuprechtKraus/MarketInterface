using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLib
{
    public interface IItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Code { get; }
    }
}
