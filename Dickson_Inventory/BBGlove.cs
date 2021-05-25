using System;
using System.Collections.Generic;
using System.Text;

namespace Dickson_Inventory
{
    class BBGlove : IShippable
    {
        decimal cost = 3.23m;
        string name = "Baseball Gloves";
        public decimal ShipCost { get { return cost; } }
        public string Product { get { return name; } }
    }
}
