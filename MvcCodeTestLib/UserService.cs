using System;
using System.Collections.Generic;
using System.Text;

namespace MvcCodeTestLib
{
    public class UserService : IUserService
    {
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            for(int i = 1; i <= 13; i++)
            {
                users.Add(new User()
                {
                     Id = i,
                      Name = "Name-"+i,
                       Address = "Address-"+i
                });
            }
            return users;
        }
    }
}
