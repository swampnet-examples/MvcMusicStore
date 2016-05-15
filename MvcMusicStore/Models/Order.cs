using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Models
{
	public class Order
	{
		public int OrderId { get; set; }
		public DateTime OrderDate { get; set; }

		[System.Web.Mvc.Remote("CheckUsername", "Order")]
		public string Username { get; set; }

		[Required]
		[StringLength(160, MinimumLength = 3)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(160, MinimumLength = 3)]
		public string LastName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }

		[Compare("Email")]
		public string EmailConfirm { get; set; }

		[Range(20, 60)]
		public int Age { get; set; }

		[Range(typeof(decimal), "0.00", "49.00")]
		public decimal Total { get; set; }
	}
}
