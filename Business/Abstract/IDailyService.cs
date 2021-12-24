using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IDailyService
    {

        public void Add(Daily daily);
        public void Delete(Daily daily);
        public void Update(Daily daily);
        List<Daily> GetAll();

    }
}
