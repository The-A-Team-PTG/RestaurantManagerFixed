using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
	public class Company : Object
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public string UIN { get; set; }
		public string MRP { get; set; }

		public Company(string name, string address, string uin, string mrp)
		{
			this.Name = name;
			this.Address = address;
			this.UIN = uin;
			this.MRP = mrp;

		}

		public override string ToString()
		{
			return $"Name:{this.Name}, address: {this.Address}, uin: {this.UIN}, mrp: {this.MRP}";
		}
	}
}
