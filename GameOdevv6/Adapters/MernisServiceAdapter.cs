using GameOdevv6.Abstract;
using GameOdevv6.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdevv6.Adapters

{
    public class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(user.NationalityId, user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DateOfBirth.Year);
        }
    }
}
