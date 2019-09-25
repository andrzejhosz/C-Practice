using System;

namespace ReportService.Models
{
	public class OrderReportItem
	{
		public string Id { get; set; }	
		public string CustomerFullName { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime ExecuteAt { get; set; }
	}
}