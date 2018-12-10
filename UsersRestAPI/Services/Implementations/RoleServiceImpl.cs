using System;
using System.Collections.Generic;
using System.Threading;
using UsersRestAPI.Model;

namespace UsersRestAPI.Services.Implementations
{
    public class RoleServiceImpl : IRoleService
    {
        private volatile int count;

        public RoleServiceImpl()
        {
        }

        public Role Create(Role role)
        {
            return role;
        }

        public void Delete(long id)
        {

        }

        public List<Role> GetAll()
        {
            List<Role> roles = new List<Role>();
            for (int i = 0; i<=10; i++)
            {
                Role role = MockRole(i);
                roles.Add(role);
            }
            return roles;
        }

        private Role MockRole(int i)
        {
            return new Role
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

        public Role GetById(long id)
        {
            return new Role
            {
                Id = IncrementAndGet(),
                Name = "Name",
                Description = "Description",
            };
        }

        public Role Update(Role role)
        {
            return role;
        }
    }
}
