namespace ReportService.Models
{
	public class Customer
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

		public static Customer CreateTestCustomer()
		{
			return new Customer { FirstName = "Jan", LastName = "Kowalski", Email = "jk@is.pl"};
		}
	}
}