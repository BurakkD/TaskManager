using Business.Abstract;
using DataAccess.EntityFrameWork.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class WeeklyManager : IWeeklyService
    {
        IWeeklyDal _weeklyDal;
        public WeeklyManager(IWeeklyDal weeklyDal)
        {
            _weeklyDal = weeklyDal;
        }
        public void Add(Weekly weekly)
        {
            _weeklyDal.Add(weekly);                 
        }

        public void Delete(Weekly weekly)
        {
            _weeklyDal.Delete(weekly);
        }

        public List<Weekly> GetAll()
        {
            return _weeklyDal.GetAll();
        }

        public void Update(Weekly weekly)
        {
            _weeklyDal.Update(weekly);
        }
    }
}
