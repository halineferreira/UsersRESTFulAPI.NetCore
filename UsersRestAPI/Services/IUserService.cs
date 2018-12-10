using System;
using System.Collections.Generic;
using UsersRestAPI.Model;

namespace UsersRestAPI.Services.Implementations
{
    public interface IUserService
    {
        User Create(User user);
        User Update(User user);
        List<User> GetAll();
        User GetById(long id);
        void Delete(long id);
    }
}
