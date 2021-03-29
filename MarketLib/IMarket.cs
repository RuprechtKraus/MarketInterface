using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLib
{
    public interface IMarket
    {
        int Budget { get; }

        void Sell(Item item);
        void Buy(Item item);
        void Hire(Employee person);
        void Fire(Employee person);
    }
}
