using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new UserDal());
            userManager.Add(new User { UserName = "eser", UserLastName="ulusor",Email="eserulusoy@gmail.com",Password="1233321" }) ;


            foreach (var User in userManager.Getall().Data)
            {
                Console.WriteLine(User.UserName);
            }
        }
    }
}
