using System.Collections.Generic;
using UsersRestAPI.Model;

namespace UsersRestAPI.Business
{
    public interface IUserBusiness
    {
        User Create(User user);
        User Update(User user);
        List<User> GetAll();
        User GetById(long id);
        void Delete(long id);
    }
}
