using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
	public class Restaurant : Company
	{

		public dynamic Capital { get; set; }

		public Restaurant(string name, string address, string uin, string mrp, dynamic capital)
			: base(name, address, uin, mrp)
		{
			this.Capital = capital;
		}



	}

}
