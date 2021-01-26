using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdevv6.Abstract
{
    public interface IUserCheckService
    {
        bool CheckIfRealPerson(Entities.User user);
    }
}
