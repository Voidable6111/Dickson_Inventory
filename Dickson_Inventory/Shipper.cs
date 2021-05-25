using System;
using System.Collections.Generic;
using System.Text;

namespace Dickson_Inventory
{
    class Shipper
    {
        private decimal sum = 0;
        private int size = 0;
        private int mGet;
        private int bGet;
        private int gGet;
        private int cGet;
        private IShippable[] purchases = new IShippable[10];
        public void Add(IShippable addition)
        {
            if (size < 10)
            {
                purchases[size] = addition;
                //sum += addition.ShipCost;
                size++;
            }
        }
        public void printOff()
        {
            int c = 0;
            int g = 0;
            int m = 0;
            int b = 0;
            for(int i = 0; i < size; i++)
            {
                switch (purchases[i].Product)
                {
                    case "Crackers":
                        c++;
                        cGet = i;
                        break;
                    case "Baseball Gloves":
                        g++;
                        gGet = i;
                        break;
                    case "Lawn Mowers":
                        m++;
                        mGet = i;
                        break;
                    case "Bicycles":
                        b++;
                        bGet = i;
                        break;
                }
            }
            printer(purchases[bGet], b);
            printer(purchases[mGet], m);
            printer(purchases[gGet], g);
            printer(purchases[cGet], c);
        }
        public void totalCost()
        {
            if (size == 0)
            {
                sum = 0;
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    sum += purchases[i].ShipCost;
                }
            }
            Console.WriteLine("Total shipping cost for this order is $" + sum);
        }
        private void printer(IShippable temp, int num)
        {
            switch (num)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(num + " " + temp.Product.Remove(temp.Product.Length - 1));
                    break;
                default:
                    Console.WriteLine(num + " " +temp.Product);
                    break;
            }
        }
    }
}
