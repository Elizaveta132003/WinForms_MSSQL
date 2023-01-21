using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOP.Modals
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string TypeOfProduct { get; set; }
		public decimal Price { get; set; }
		public Product(string name, string typeOfProduct, decimal price)
		{
			Name = name;
			TypeOfProduct = typeOfProduct;
			Price = price;
		}
	}
}
