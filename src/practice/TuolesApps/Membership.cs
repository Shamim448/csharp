using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuolesApps
{
    internal class Membership
    {
        public (AccountStatus Status, Users User) CreateUser(string username, string password)
        {
            Users newUser = new Users() { Username= username, Password = password };
            AccountStatus status = StoreInDatabase(newUser);
            return (status, newUser);
        }
        public AccountStatus StoreInDatabase(Users user)
        {
            return AccountStatus.Not_Register_Yet;
        }
    }
}
