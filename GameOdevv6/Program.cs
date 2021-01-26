using System;

namespace GameOdevv6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Abstract.BaseUserManager userManager = new Concrete.UserManager();
            userManager.SignIn(new Entities.User { DateOfBirth = new DateTime(1991, 9, 17), FirstName = "Serenay", LastName = "Ekinci", UserId = 3, NationalityId = "35362262" });

            Abstract.BaseUserManager userManager1 = new Concrete.UserManager();
            userManager1.Purchase(new Entities.User { Campaign1 = 300 });


        }


      
    }
}
