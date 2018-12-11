using System.Collections.Generic;
using UsersRestAPI.Model;

namespace UsersRestAPI.Repository
{
    public interface IPermissionRepository
    {
        Permission Create(Permission permission);
        Permission Update(Permission permission);
        List<Permission> GetAll();
        Permission GetById(long id);
        void Delete(long id);
    }
}
