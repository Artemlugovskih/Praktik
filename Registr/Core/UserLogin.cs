using Registr.Model;
using System.Collections.Generic;
using System.Linq;

namespace Registr.Core
{
   public static class UserLogin
    {
        public static User FindUserByFirstName(IEnumerable<User> users, string firstName)=>
            users.FirstOrDefault(User=>User.FirstName==firstName);
            public static bool Validate(string login, string password) => login == "admin" && password == "admin";
    }
}
