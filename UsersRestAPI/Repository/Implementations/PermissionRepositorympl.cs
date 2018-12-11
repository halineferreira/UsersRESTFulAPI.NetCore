using System.Collections.Generic;
using System.Threading;
using UsersRestAPI.Model;

namespace UsersRestAPI.Repository.Implementations
{
    public class PermissionRepositoryImpl : IPermissionRepository
    {
        private volatile int count;

        public PermissionRepositoryImpl()
        {
        }

        public Permission Create(Permission permission)
        {
            return permission;
        }

        public void Delete(long id)
        {

        }

        public List<Permission> GetAll()
        {
            List<Permission> permissions = new List<Permission>();
            for (int i = 0; i<=10; i++)
            {
                Permission permission = MockPermission(i);
                permissions.Add(permission);
            }
            return permissions;
        }

        private Permission MockPermission(int i)
        {
            return new Permission
            {
                Id = IncrementAndGet() + i,
                Name = "Name",
                Description = "Description"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Permission GetById(long id)
        {
            return new Permission
            {
                Id = IncrementAndGet(),
                Name = "Name",
                Description = "Description",
            };
        }

        public Permission Update(Permission permission)
        {
            return permission;
        }
    }
}
