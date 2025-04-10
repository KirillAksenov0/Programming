using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace View.ViewModel.Validation
{
    public class NameValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult(false, "Name must not null");
            }

            if ((value.ToString()).Length > 100)
            {
                return new ValidationResult(false, "Name must not exceed 100 characters");
            }
            return ValidationResult.ValidResult;
        }
    }
}
