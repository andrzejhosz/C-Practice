using System;
using System.Collections.Generic;

namespace ReportService.Models
{
	public class Order
	{
		public Guid Id { get; }
		public DateTime CreatedAt { get; }
		public Customer Customer { get; }
		public List<Product> Products { get; }
		public DateTime ExecuteAt { get; set; }

		public Order(Guid id, Customer customer, DateTime createdAt)
		{
			Id = id;
			Customer = customer;
			CreatedAt = createdAt;
			Products = new List<Product>();
		}

		public decimal GetTotalPrice()
		{
			var totalPrice = 0m;
			foreach (var product in Products)
			{
				totalPrice += product.Price;
			}

			return totalPrice;
		}

		public static Order CreateTestOrder()
		{
			return new Order(Guid.NewGuid(), Customer.CreateTestCustomer(), new DateTime())
			{
				Products = { new Product("p1", 10), new Product("p2", 11) }
			};
		}

		public static Order CreateTestOrder(string customerEmail, string customerFirstName, string customerLastname)
		{
			return new Order(
				Guid.NewGuid(),
				new Customer { Email = customerEmail, FirstName = customerFirstName, LastName = customerLastname},
				new DateTime())
			{
				Products = { new Product("p1", 10), new Product("p2", 11) }
			}; ;
		}

		public string ToMessage()
		{
			return $"This is order {Id} for {Customer.Email}";
		}
	}
}