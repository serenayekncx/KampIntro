using GameOdevv6.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;



namespace GameOdevv6.Abstract
{
    public interface IUserService : IEntity
   {
        void SignIn(User user);
        void Update(User user);
        void Delete(User user);


   }
}
