using GameOdevv6.Abstract;
using GameOdevv6.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdevv6.Concrete
{
    public class UserManager : BaseUserManager
    {

        private IUserCheckService _userCheckManager;

        public UserManager()
        {
        }

        public UserManager(IUserCheckService userCheckManager)
        {

            _userCheckManager = userCheckManager;


        }
        


        public override void SignIn(User user)
        {

            if (_userCheckManager.CheckIfRealPerson(user))
            {
                base.SignIn(user);
            }
            else
            {
                throw new Exception("Not a valid person");

            }

        }

    }

  
}

public class SaleManager : BaseUserManager
{

}

public class CampaignManager : BaseUserManager
{

}

