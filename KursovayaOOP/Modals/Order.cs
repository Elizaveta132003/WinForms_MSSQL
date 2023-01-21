using KursovayaOOP.Modals;
using System;
using System.Collections.Generic;

namespace KursovayaOOP.Services
{
	public class Order
	{
		public int IdOrder { get; set; }
		public Client Client { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime DateOfSgipment { get; set; }
		public string Status { get; set; }
		public List<OrderItem> List { get; set; }
		public decimal Price { get; set; }
		public Employee Employee { get; set; }

		public Order(int idOrder, Client client, DateTime orderDate, DateTime dateOfSgipment, string status, List<OrderItem> list, decimal price, Employee employee)
		{
			IdOrder = idOrder;
			Client = client;
			OrderDate = orderDate;
			DateOfSgipment = dateOfSgipment;
			Status = status;
			List = list;
			Price = price;
			Employee = employee;
		}
	}
}
