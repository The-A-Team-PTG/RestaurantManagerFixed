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

}
