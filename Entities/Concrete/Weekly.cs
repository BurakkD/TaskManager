using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public  class Weekly:IEntity
    {
        public int WeeklyId { get; set; }
        public int UserId { get; set; }
        public string   WeeklyDescription { get; set; }

    }
}
