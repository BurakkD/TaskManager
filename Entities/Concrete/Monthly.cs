using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Monthly:IEntity
    {
        public int MonthlyId { get; set; }
        public int UserId { get; set; }
        public string MonthlyDescription { get; set; }

    }
}
