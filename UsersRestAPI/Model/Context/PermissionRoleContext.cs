using System;
using Microsoft.EntityFrameworkCore;

namespace UsersRestAPI.Model.Context
{
    public class PermissionRoleContext : DbContext
    {
        public DbSet<Permission> Permissios { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PermissionRole> PermissionRoles { get; set; }
    }
}
