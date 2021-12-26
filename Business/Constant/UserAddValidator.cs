using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{
   public class UserAddValidator:AbstractValidator<User>
    {
        public UserAddValidator()
        {
            
            
                RuleFor(u => u.UserId).NotEmpty();
                RuleFor(u => u.UserId).GreaterThan(0);
                RuleFor(u => u.IdentificationNumber).Length(11);
                                 
        }

       
    }
}
