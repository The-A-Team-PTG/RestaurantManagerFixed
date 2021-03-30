using System;

namespace resturantfixedmanager
{
	public class Supplier : Company
	{
		public Supplier(string name, string address, string uin, string mrp, dynamic capital)
		   : base(name, address, uin, mrp)
        {

        }
	}

}
