using System;

namespace ReportService.Models
{
	public class Product
	{
		public string Name { get; set; }
		public decimal Price { get; set; }

		public Product(string name, decimal price)
		{
			Name = name;
			Price = price;
		}

		public int CompareTo(Product other)
		{
			if (other == null)
				return 1;

			return string.Compare(Name, other.Name, StringComparison.Ordinal);
		}

		public string ToMessage()
		{
			return $"This is product {Name}";
		}
	}
}
