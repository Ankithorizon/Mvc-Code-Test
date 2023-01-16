using System;
using System.Collections.Generic;
using System.Text;

namespace MvcCodeTestLib
{
    public interface IUserService
    {
        List<User> GetAllUsers();
    }
}
