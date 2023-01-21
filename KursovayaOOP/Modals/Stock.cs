using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOP.Modals
{
	public class Stock
	{
		public DateTime DateOfReceipt { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime DateOfDispatch { get; set; }
		public int idProduct { get; set; }

	}
}
