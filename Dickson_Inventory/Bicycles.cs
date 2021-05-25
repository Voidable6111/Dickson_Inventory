using System;
using System.Collections.Generic;
using System.Text;

namespace Dickson_Inventory
{
    class Bicycles : IShippable
    {
        decimal cost = 9.50m;
        string name = "Bicycles";
        public decimal ShipCost { get { return cost; } }
        public string Product { get { return name; } }
    }
}
