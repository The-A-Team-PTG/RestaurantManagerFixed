using System;

namespace RestaurantManager
{
    public interface ICompany
    {
        public string name { get;  }
        public string Address { get;  }
        public string UIN { get;  }
        public string MRP { get;  }
    }
}
