using System;
using System.Collections.Generic;
using UsersRestAPI.Model;

namespace UsersRestAPI.Repository
{
    public interface IUserRepository
    {
        User Create(User user);
        User Update(User user);
        List<User> GetAll();
        User GetById(long id);
        void Delete(long id);
    }
}
