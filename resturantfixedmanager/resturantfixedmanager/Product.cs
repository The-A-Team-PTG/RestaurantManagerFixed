using System;

namespace resturantfixedmanager
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

}

