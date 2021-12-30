using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class Membership
    {
        public (AccountCreationStatus status, User user) CreateUser( string username, string password)
        {
            User newuser = new User() { Username = username, Password = password };
            AccountCreationStatus status = StoreIndatabase();
            return (status, newuser);
        }
        public AccountCreationStatus StoreIndatabase( )
        {
            return AccountCreationStatus.Succes;
        }
    }
}
