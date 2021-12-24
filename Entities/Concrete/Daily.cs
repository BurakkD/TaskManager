using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Daily:IEntity
    {
        public int DailyId { get; set; }
        public int UserId { get; set; }
        public string DailyDescription { get; set; }

    }
}
