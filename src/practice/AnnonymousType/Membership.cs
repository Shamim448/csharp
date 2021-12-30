using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymousType
{
    internal class Membership
    {
        public object CreateUser( string username, string password)
        {
            User newuser = new User() { Username = username, Password = password };
            AccountCreationStatus status = StoreIndatabase();
            return new { status, user = newuser};
        }
        public AccountCreationStatus StoreIndatabase( )
        {
            return AccountCreationStatus.Succes;
        }
    }
}
