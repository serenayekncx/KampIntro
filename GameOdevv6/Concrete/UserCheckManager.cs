using GameOdevv6.Abstract;
using GameOdevv6.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdevv6.Concrete
{
    public class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
           

        }
           
    }
}
