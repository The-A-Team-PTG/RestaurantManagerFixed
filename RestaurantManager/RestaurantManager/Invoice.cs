using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
	public class Invoice
	{
		public int Number {get; set;}
		public ICompany Costomer { get; set; }
		public ICompany Supplier { get; set; }

	}
}
