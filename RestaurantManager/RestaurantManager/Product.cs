using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManager
{
    public class Product
    {
        public string name { get; private set; }

        public double quantity { get;  set; }


        public Product(string name , double  quantity)
        {
            this.name = name;
            this.quantity = quantity;

        }
    }
}
