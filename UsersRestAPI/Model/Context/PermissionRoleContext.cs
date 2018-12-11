using System;
using Microsoft.EntityFrameworkCore;

namespace UsersRestAPI.Model.Context
{
    public class PermissionRoleContext : DbContext
    {
        public DbSet<Permission> Permissios { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PermissionRole>()
                .HasKey(t => new { t.PermissionId, t.RoleId });

            modelBuilder.Entity<PermissionRole>()
                .HasOne(pt => pt.Permission)
                .WithMany(p => p.PermissionRole)
                .HasForeignKey(pt => pt.PermissionId);

            modelBuilder.Entity<PermissionRole>()
                .HasOne(pt => pt.Role)
                .WithMany(t => t.PermissionRole)
                .HasForeignKey(pt => pt.RoleId);
        }
    }
}
