using Business.Concrete;
using DataAccess.EntityFrameWork;
using DataAccess.EntityFrameWork.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            UserManager userManager = new UserManager(new EFUserDal());
            userManager.Add(new User() { UserId = 0 });


            //DailyManager dailyManager = new DailyManager(new EFDailyDal());





        }
    }
}
