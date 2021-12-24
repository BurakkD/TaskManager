using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IWeeklyService
    {
        public void Add(Weekly weekly);
        public void Delete(Weekly weekly);
        public void Update(Weekly weekly);
        List<Weekly> GetAll();




    }
}
