using System;
using System.Collections.Generic;

namespace RestaurantManager
{
    class Program
    {
        static void Main(string[] args)
        {

            var manager = new RestaurantManager();
            while (true)
            {
                string line = Console.ReadLine();
                string[] cmdParts = line.Split(" ");
                string cmd = cmdParts[0];
                switch (cmd)
                {
                    case "ServeMeal":
                        string name = cmdParts[1];
                        List<Product> product = new List<Product>();
                        for (int i = 2; i < cmdParts.Length - 1; i += 2)
                        {
                            string productname = cmdParts[i];
                            double productQuantity = double.Parse(cmdParts[i + 1]);
                            product.Add(new Product(productname, productQuantity));
                        }
                        string date = cmdParts[cmdParts.Length - 1];
                        string result = manager.ServeMeal(name, product, date);
                        Console.WriteLine(result);
                        break;
                    default:
                        break;
                }

                

                }
        }
    }
}
