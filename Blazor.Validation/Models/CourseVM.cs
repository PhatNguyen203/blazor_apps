using System.ComponentModel.DataAnnotations;

namespace Blazor.Validation.Models
{
	public class CourseVM : TermConditionsVM
	{
		[Required(ErrorMessage = "Full name is required.")]
		[MinLength(3, ErrorMessage = "Full name must be at least 3 characters long.")]
		public string Name { get; set; } = string.Empty;

		[Required(ErrorMessage = "Email is required.")]
		[EmailAddress(ErrorMessage = "Please enter a valid email address.")]
		public string Email { get; set; } = string.Empty;
		
		[Required(ErrorMessage = "Phone number is requred.")]
		[RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits.")]
		public string PhoneNumber { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please select a course.")]
		public string SelectedCourse { get; set; } = string.Empty;


		[Required(ErrorMessage = "Please select a start date.")]
		public DateTime StartDate { get; set; } = DateTime.Today;

		public bool StudyMode { get; set; } = true;
		public string Comment { get; set; } = string.Empty;
	}
}
