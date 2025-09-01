using System.ComponentModel.DataAnnotations;

namespace Blazor.Validation.Models
{
	public class TermConditionVM
	{
		[Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting.")]
		public bool AcceptedTerms { get; set; }
	}
}
