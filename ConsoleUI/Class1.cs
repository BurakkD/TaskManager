using Business.Concrete;
using Core.Abstract;
using DataAccess.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
     class Class1
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new EFUserDal());

           var result= userManager.GetAll();
            Console.WriteLine(result);

        }
    }
}
