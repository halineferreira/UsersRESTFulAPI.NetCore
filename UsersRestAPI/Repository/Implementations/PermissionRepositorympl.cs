using System;
using System.Collections.Generic;
using System.Linq;
using UsersRestAPI.Model;
using UsersRestAPI.Model.Context;

namespace UsersRestAPI.Repository.Implementations
{
    public class PermissionRepositoryImpl : IPermissionRepository
    {
        private MySQLContext _context;
        public PermissionRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public PermissionRepositoryImpl()
        {
        }

        public Permission Create(Permission permission)
        {
            try
            {
                _context.Add(permission);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return permission;
        }

        public void Delete(long id)
        {
            var result = _context.Permissions.SingleOrDefault(u => u.Id.Equals(id));

            try
            {
                if (result != null) _context.Permissions.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Permission> GetAll()
        {
            return _context.Permissions.ToList();
        }


        public Permission GetById(long id)
        {
            return _context.Permissions.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Permission Update(Permission permission)
        {
            if (!Exist(permission.Id)) return null;
            var result = _context.Permissions.SingleOrDefault(u => u.Id.Equals(permission.Id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(permission);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return permission;

        }

        public bool Exist(long? id)
        {
            return _context.Permissions.Any(u => u.Id.Equals(id));
        }
    }
}
