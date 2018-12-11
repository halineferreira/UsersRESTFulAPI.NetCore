using System;
using System.Collections.Generic;
using UsersRestAPI.Model;

namespace UsersRestAPI.Business
{
    public interface IPermissionBusiness
    {
        Permission Create(Permission permission);
        Permission Update(Permission permission);
        List<Permission> GetAll();
        Permission GetById(long id);
        void Delete(long id);
    }
}
