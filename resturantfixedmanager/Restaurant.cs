using System;

namespace resturantfixedmanager
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

