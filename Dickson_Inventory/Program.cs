using System;

namespace Dickson_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            bool going = true;
            int option;
            int counter = 0;
            Bicycles bike = new Bicycles();
            BBGlove glove = new BBGlove();
            Mower mower = new Mower();
            Crackers crackers = new Crackers();
            Shipper order = new Shipper();
            while (going)
            {
                Console.WriteLine("Choose from the following options:\n1.Add a Bicycle to the shipment\n2.Add a Lawn Mower to the Shipment\n3.Add a Baseball Glove to the shipment\n4.Add Crackers to the shipment\n5.List Shipment Items\n6.Compute Shipping Charges");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        if (counter == 10)
                        {
                            Console.WriteLine("Inventory is full.\nPress any key to return to the menu.");
                        }
                        else
                        {
                            order.Add(bike);
                            Console.WriteLine("1 bicycle added.\nPress any key to return to the menu.");
                            counter++;
                        }
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        if (counter == 10)
                        {
                            Console.WriteLine("Inventory is full.\nPress any key to return to the menu.");
                        }
                        else
                        {
                            order.Add(mower);
                            Console.WriteLine("1 lawn mower added.\nPress any key to return to the menu.");
                            counter++;
                        }
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        if (counter == 10)
                        {
                            Console.WriteLine("Inventory is full.\nPress any key to return to the menu.");
                        }
                        else {
                            order.Add(glove);
                            Console.WriteLine("1 baseball glove added.\nPress any key to return to the menu.");
                            counter++;
                        }
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        if (counter == 10)
                        {
                            Console.WriteLine("Inventory is full.\nPress any key to return to the menu.");
                        }
                        else {
                            order.Add(crackers);
                            Console.WriteLine("1 cracker added.\nPress any key to return to the menu.");
                            counter++;
                        }
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        Console.WriteLine("Shipment manifest:");
                        order.printOff();
                        Console.WriteLine("Press any key to return to the menu.");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        order.totalCost();
                        Console.WriteLine("This is the end of the program. Press any key to terminate it.");
                        going = false;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }

            }
        }
    }
}
