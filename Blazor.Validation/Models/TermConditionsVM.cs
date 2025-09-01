using System.ComponentModel.DataAnnotations;

namespace Blazor.Validation.Models
{
	public class TermConditionsVM
	{
		[Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting.")]
		public bool AcceptedTerms { get; set; }
	}
}
