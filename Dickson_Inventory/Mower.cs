using System;
using System.Collections.Generic;
using System.Text;

namespace Dickson_Inventory
{
    class Mower : IShippable
    {
        decimal cost = 24.00m;
        string name = "Lawn Mowers";
        public decimal ShipCost { get { return cost; } }
        public string Product { get { return name; } }
    }
}
