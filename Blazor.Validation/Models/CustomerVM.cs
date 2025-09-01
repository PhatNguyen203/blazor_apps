using System.ComponentModel.DataAnnotations;

namespace Blazor.Validation.Models
{
	public class CustomerVM : TermConditionVM
	{
		[Required(ErrorMessage = "Full name is required.")]
		[MinLength(3, ErrorMessage = "Full name must be at least 3 characters long.")]
		public string Name { get; set; } = string.Empty;

		[Required(ErrorMessage = "Email is requred.")]
		[EmailAddress(ErrorMessage = "Please enter a valid email address.")]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = "Phone numer is requred.")]
		[RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits.")]
		public string PhoneNumber { get; set; } = string.Empty;

		[MinLength(5, ErrorMessage = "Address must be at least 5 characters long.")]
		public string? Address { get; set; }

		[Required(ErrorMessage = "Message is requred.")]
		[MinLength(10, ErrorMessage = "Message must be at least 10 characters long.")]
		public string Message { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please select a service.")]
		public string Service { get; set; } = string.Empty;
	}
}
