using Business.Abstract;
using DataAccess.EntityFrameWork.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DailyManager : IDailyService
    {
        IDailyDal _dailyDal;
        public DailyManager(IDailyDal dailyDal)
        {
            _dailyDal = dailyDal;
        }
        
        public void Add(Daily daily)
        {
            _dailyDal.Add(daily);
        }

        public void Delete(Daily daily)
        {
            _dailyDal.Delete(daily);
        }

        public List<Daily> GetAll()
        {
            return _dailyDal.GetAll();
        }

        public void Update(Daily daily)
        {
            _dailyDal.Update(daily);
        }
    }
}
