using System;
using System.Collections.Generic;
using UsersRestAPI.Model;

namespace UsersRestAPI.Business
{
    public interface IRoleBusiness
    {
        Role Create(Role role);
        Role Update(Role role);
        List<Role> GetAll();
        Role GetById(long id);
        void Delete(long id);
    }
}
