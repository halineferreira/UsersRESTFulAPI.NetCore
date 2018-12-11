using System;
using Microsoft.EntityFrameworkCore;

namespace UsersRestAPI.Model.Context
{
    public class UserRoleContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(p => p.Role)
                .WithMany(b => b.Users)
                .IsRequired();
        }
    }
}
