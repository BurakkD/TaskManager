using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFrameWork
{
   public class EFUserDal:EntityFrameWork<User,SQLConnect>,IUserDal
    {

    }
}
