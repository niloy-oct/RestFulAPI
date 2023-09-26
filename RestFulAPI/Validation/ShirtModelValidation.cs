using RestFulAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace RestFulAPI.Validation
{
    public class ShirtModelValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object?value, ValidationContext validationcontext)
        {
            var shirt = validationcontext.ObjectInstance as Shirt;

            if(shirt != null && !string.IsNullOrWhiteSpace(shirt.Gender))
            {
                if(shirt.Gender.Equals("men",  StringComparison.OrdinalIgnoreCase) && shirt.Size < 8)
                {
                    return new ValidationResult("For men shirt size should be greater or qual 8");
                }
                else if (shirt.Gender.Equals("women", StringComparison.OrdinalIgnoreCase) && shirt.Size < 6)
                {
                    return new ValidationResult("For women shirt size should be greater or qual 6");
                }
            }

            return ValidationResult.Success;
        }

    }
}
