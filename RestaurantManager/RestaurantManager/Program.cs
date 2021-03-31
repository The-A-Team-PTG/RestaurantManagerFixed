using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> feature/2-buyProduct

namespace RestaurantManager
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

            var manager = new RestaurantManager();
=======
            var manager = new RestaurantManager();

            var testRestaurant = new Restaurant("rest", "centera", "123123", "Pesho", 300.50M);
            Console.WriteLine(testRestaurant);

>>>>>>> feature/2-buyProduct
            while (true)
            {
                string line = Console.ReadLine();
                string[] cmdParts = line.Split(" ");
                string cmd = cmdParts[0];
                switch (cmd)
                {
<<<<<<< HEAD
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
=======
                    case "serveMeal":
                        string name = cmdParts[1];
                        List<Product> products = new List<Product>();
                        for (int i = 2; i < cmdParts.Length - 1; i += 2)
                        {
                            string productName = cmdParts[i];
                            double productQuantity = double.Parse(cmdParts[i + 1]);
                            products.Add(new Product(productName, productQuantity));
                        }
                        string date = cmdParts[cmdParts.Length - 1];

                        string result = manager.ServeMeal(name, products, date);
                        Console.WriteLine(result);
                        break;
                    case "buyProduct":
                        Console.WriteLine(manager.BuyProducts(cmdParts[1], double.Parse(cmdParts[2]),0));
                        break;
                    default:
                        break;
                }
            }
>>>>>>> feature/2-buyProduct
        }
    }
}
