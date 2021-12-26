using Business.Abstract;
using DataAccess.EntityFrameWork.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MonthlyManager : IMonthlyService
    {
        IMonthlyDal _monthlyDal;

        public MonthlyManager(IMonthlyDal monthlyDal)
        {
            _monthlyDal = monthlyDal;
        }


        public void Add(Monthly monthly)
        {
            _monthlyDal.Add(monthly);
        }

        public void Delete(Monthly monthly)
        {
            _monthlyDal.Delete(monthly);
        }

        public List<Monthly> GetAll()
        {
            return _monthlyDal.GetAll();
        }

        public void Update(Monthly monthly)
        {
            _monthlyDal.Update(monthly);
        }
    }
}
