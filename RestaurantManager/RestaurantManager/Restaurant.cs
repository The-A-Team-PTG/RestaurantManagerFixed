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
		 
		void IssueReceipt(ReceiptIssueable acc)
			{

			acc.IssueReceipt();

				}

		

			void IssueInvoiceFromAccountant(InvoiceIssueable acc)
			{

			acc.IssueInvoice();

				}

		

        public override string ToString()
        {
			this.IssueReceipt(new Accountant());
			this.IssueReceipt(new Machine());
			this.IssueReceipt(new Person());
			this.IssueInvoiceFromAccountant(new Accountant());
			this.IssueInvoiceFromAccountant(new InvoiceSoftware());
             string return =base.ToString();
			result +=$",capital={this.Capital}";

			return result;
        }
    }

}
