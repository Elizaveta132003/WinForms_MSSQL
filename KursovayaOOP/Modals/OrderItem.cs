using KursovayaOOP.Modals;

namespace KursovayaOOP.Services
{
	public class OrderItem
	{
		public Product Product { get; set; }
		public int Count { get; set; }

		public decimal Price { get; set; }

		public OrderItem(Product product, int count)
		{
			Product = product;
			Count = count;
			Price = Count * Price;
		}
	}
}
