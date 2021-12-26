using Business.Abstract;
using Business.Constant;
using Core.Abstract;
using DataAccess.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Consrate
{
   public class Validation
    {
         IUserDal _userdal;
        public Validation(IUserDal userdal)
        {
            _userdal = userdal;
        }
            
        public  bool Addvalidation(User user)
        {
            if (user.UserId > 0 && user.IdentificationNumber.Length==11)
            {
                _userdal.Add(user);
                return true;
            }
            return false;
            
        }
        public bool DeleteValidation(User user)
        {
            foreach (var item in _userdal.GetAll(d => d.UserId == user.UserId))
                {
                if (item.UserId==user.UserId && user.IdentificationNumber.Length == 11)
                {
                    _userdal.Delete(item);
                    return true;
                }
                }
            return false;
                        
        }
        public bool UpdateValidation(User user)
        {
            foreach (var item in _userdal.GetAll(d => d.UserId == user.UserId))
            {
                if (item.UserId==user.UserId)
                {
                    _userdal.Update(user);
                    return true;
                }
            }
            return false;
            //if (user.FirstName !="Ğ" && user.LastName !="Ğ")
            //{
            //    return false;
            //}
            //_userdal.Delete(user);

            //return true;

        }

    }
}
