using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models.Validation
{
    public class IsANumber : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && !IsNumeric(value.ToString()))
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }

        private bool IsNumeric(string value)
        {
            return double.TryParse(value, out _);
        }
    }
}
