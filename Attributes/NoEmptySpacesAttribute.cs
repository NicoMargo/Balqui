using System.ComponentModel.DataAnnotations;

namespace Balqui.Attributes
{
    public class NoEmptySpacesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string stringValue)
            {
                if (string.IsNullOrWhiteSpace(stringValue))
                {
                    return new ValidationResult("El campo no puede estar vacío o contener solo espacios en blanco.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
