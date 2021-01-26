using GameOdevv6.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdevv6.Entities
{
    public class User : IEntity
    {
        

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public object Campaign1 { get; internal set; }
    }

    
}
