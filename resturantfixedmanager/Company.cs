using System;

namespace resturantfixedmanager
{
	public class Company
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
	}

}


