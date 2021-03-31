using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManager
{
    public class RestaurantManager
    {
        private List<Product> Products {get; set;}

        public RestaurantManager()
        {
            this.Products = new List<Product>();
        }
        public string ServeMeal(string name, List<Product> products, string date)
        {
            foreach (Product product in products)
            {
                var productFromRestaurant = this.Products.FirstOrDefault(p => p.name == product.name);
                if (productFromRestaurant == null)
                {
                    return $"Cannot create {name} because {product.name} does not exist";
                }
                if (productFromRestaurant.quantity < product.quantity)
                {
                    return $"Cannot create {name} because {product.name} has {productFromRestaurant.quantity} quantity but {product.quantity} needed.";
                }
                productFromRestaurant.quantity -= product.quantity;
                if (productFromRestaurant.quantity <=0)
                {
                    this.Products.Remove(productFromRestaurant);

                }
                
            }

            return $"Sucsesfully served {name} at {date}!";
        }



    }
}
