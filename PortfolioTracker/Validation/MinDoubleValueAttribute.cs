using System;
using System.ComponentModel.DataAnnotations;

public class MinDoubleValueAttribute : ValidationAttribute
{
    private readonly double _minValue;

    public MinDoubleValueAttribute(double minValue)
    {
        _minValue = minValue;
        ErrorMessage = $"Value must be greater than {_minValue}.";
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        // Ensure the value is a double and greater than the minimum value
        if (value is double doubleValue)
        {
            if (doubleValue <= 0)
            {
                return new ValidationResult("Value must be greater than 0.");
            }

            if (doubleValue < _minValue)
            {
                return new ValidationResult(ErrorMessage);
            }
        }
        else if (value is decimal decimalValue)
        {
            if (decimalValue <= 0)
            {
                return new ValidationResult("Value must be greater than 0.");
            }

            if (decimalValue < (decimal)_minValue)
            {
                return new ValidationResult(ErrorMessage);
            }
        }

        return ValidationResult.Success;
    }
}
