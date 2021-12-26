using Business.Abstract;
using Business.Consrate;
using Business.Constant;
using Core;
using Core.Abstract;
using Core.Validation;
using DataAccess.EntityFrameWork;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        
        //IUserDal _userDal;
        //Validation userValidation = new Validation(new EFUserDal());     
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        
        public void Add(User user)
        {

            var resultt=ValidationTool.Validate(new UserAddValidator(),user);
            if (resultt==true)
            {
                _userDal.Add(user);
                Console.WriteLine("Kullanıcı Eklendi");
            }
             else if (!resultt)
                Console.WriteLine("Kullanıcı Eklenemedi");
            
          
        }

        public void Delete(User user)
        {
            var resultt = ValidationTool.Validate(new UserDeleteValidator(), user);
            if (resultt==true)
            {
                _userDal.Delete(user);
                Console.WriteLine("Kullanıcı Silindi");
            }
            else if(!resultt)
                Console.WriteLine("Kullanıcı Silinemedi");
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public void Update(User user)
        {
            var resultt = ValidationTool.Validate(new UserUpdateValidator(), user);
            if (resultt == true)
            {
                _userDal.Update(user);
                Console.WriteLine("Kullanıcı Güncellendi");
            }
            else if (!resultt)
                Console.WriteLine("Kullanıcı Güncellenemedi");

        }
    }
}
