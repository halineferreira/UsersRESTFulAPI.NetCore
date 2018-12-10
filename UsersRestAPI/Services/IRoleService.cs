using System;
using System.Collections.Generic;
using UsersRestAPI.Model;

namespace UsersRestAPI.Services.Implementations
{
    public interface IRoleService
    {
        Role Create(Role role);
        Role Update(Role role);
        List<Role> GetAll();
        Role GetById(long id);
        void Delete(long id);
    }
}
