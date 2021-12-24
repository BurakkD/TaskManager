using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IMonthlyService
    {
        public void Add(Monthly monthly);
        public void Delete(Monthly monthly);
        public void Update(Monthly monthly);
        List<Monthly> GetAll();

    }
}
