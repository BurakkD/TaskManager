using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{
   public class UserDeleteValidator:AbstractValidator<User>
    {
       
        public UserDeleteValidator()
        {
           
            RuleFor(u => u.UserId).NotEmpty();
            RuleFor(u => u.UserId).GreaterThan(0);
            RuleFor(u => u.IdentificationNumber).Length(11);
            

        }


    }
}
