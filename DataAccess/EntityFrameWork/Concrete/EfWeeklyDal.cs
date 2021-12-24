using DataAccess.EntityFrameWork.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFrameWork.Concrete
{
   public class EfWeeklyDal: EntityFrameWork<Weekly,SQLConnect>,IWeeklyDal
    {


    }
}
