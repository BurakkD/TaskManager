using Business.Abstract;
using Business.Constant;
using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Consrate
{
   public class UserValidation:IUserValidation
    {
         IUserDal userdal;
        public  void Addvalidation(User user)
        {
            if (user.UserId > 0)
            {
                userdal.Add(user);
            }
        }

    }
}
