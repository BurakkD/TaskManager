using Business.Abstract;
using Business.Consrate;
using Business.Constant;
using Core.Abstract;
using DataAccess.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        
        IUserDal _userDal;

        UserValidation UserValidation = new UserValidation();
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        
        public void Add(User user)
        {
            UserValidation.Addvalidation(user);
            Console.WriteLine("ürün eklenemedi");
                
        }

        public void Delete(User user)
        {

            _userDal.Delete(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
