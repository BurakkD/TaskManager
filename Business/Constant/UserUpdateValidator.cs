using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{
   public class UserUpdateValidator:AbstractValidator<User>
    {
        public UserUpdateValidator()
        {
            RuleFor(u => u.FirstName).Must(DonotStartWithĞ);
            RuleFor(u => u.LastName).Must(DonotStartWithĞ);
            RuleFor(u => u.UserId).NotEmpty();
        }
        private bool DonotStartWithĞ(string arg)
        {
            if (arg.StartsWith("Ğ"))
            {
                throw new NotImplementedException();
            }
            else;
            return true;
        }

    }
}
