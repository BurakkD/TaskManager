using DataAccess.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Abstract
{
   public interface IUserDal:IEntityFrameworkBase<User>
    {

    }
}
