using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Validation
{
    public static class ValidationTool
    {
        public static bool Validate(IValidator validator,object entity){


        var context = new ValidationContext<Object>(entity);
        var result = validator.Validate(context);
            if (result.IsValid)
            {
                return true;
            }
            return false;


        }

    }
}
