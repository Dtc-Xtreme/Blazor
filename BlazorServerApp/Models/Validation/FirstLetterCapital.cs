using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlazorServerApp.Models.Validation
{
    public class FirstLetterCapital : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && !IsFirstLetterCapital(value.ToString()))
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }

        private bool IsFirstLetterCapital(string value)
        {
            if (string.IsNullOrEmpty(value))
                return true;

            char firstLetter = value[0];
            return char.IsUpper(firstLetter);
        }
    }
}