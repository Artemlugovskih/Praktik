using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Registr.Model;

namespace Registr.Core
{
    public static class UserPassword
    {
        public static IEnumerable<User> ParseFile(string path)
        {
            foreach(string line in File.ReadAllLines(path).Skip(1))
            {
                string[] props = line.Split(';');
                yield return new User(Convert.ToInt32(props[0]), props[1], props[2], props[3], Convert.ToDateTime(props[4]),
                    Convert.ToDecimal(props[5]));
            }
        }
        public static void AddUser(string path,User user)
        {
            File.AppendAllText(path, user.Format());
        }
    }
}
