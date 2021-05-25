using System;
using System.Collections.Generic;
using System.Text;

namespace Dickson_Inventory
{
    interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
