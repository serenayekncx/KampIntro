using GameOdevv6.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdevv6.Abstract
{
    public abstract class BaseUserManager : IUserService, IEntity
    {
        public void CampaignAdd()
        {
            throw new NotImplementedException();
        }

        public void CampaignDelete()
        {
            throw new NotImplementedException();
        }

        public void CampaignUpdate()
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public void Purchase(User user)
        {
            Console.WriteLine("Purchased");
        }

        public virtual void SignIn(User user)
        {
            Console.WriteLine("Signed");
        }

        public void Update(User user)
        {
            Console.WriteLine("Updated");
        }
    }

}
