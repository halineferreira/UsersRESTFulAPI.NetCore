using System;
using Microsoft.EntityFrameworkCore;

namespace UsersRestAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
       public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PermissionRole> PermissionRoles { get; set; }
    }
}
