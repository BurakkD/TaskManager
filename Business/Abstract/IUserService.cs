using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        public void Add(User user);
        public void Delete(User user);
        public void Update(User user);
        List<User> GetAll();



    }
}
