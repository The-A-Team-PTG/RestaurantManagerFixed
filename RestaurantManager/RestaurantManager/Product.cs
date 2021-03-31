using System;
using System.Collections.Generic;
<<<<<<< HEAD
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
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
	public class Product
	{
		public string Name { get; private set; }

		public double Quantity { get; set; }

		public Product(string name, double quantity)
		{
			this.Name = name;
			this.Quantity = quantity;
		}


	}
>>>>>>> feature/2-buyProduct
}
