using System;
using System.Collections.Generic;
using System.Text;

namespace Dickson_Inventory
{
    class Crackers : IShippable
    {
        decimal cost = 0.57m;
        string name = "Crackers";
        public decimal ShipCost { get { return cost; } }
        public string Product { get { return name; } }
    }
}
