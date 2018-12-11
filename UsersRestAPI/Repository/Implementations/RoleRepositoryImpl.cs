using System;
using System.Collections.Generic;
using System.Linq;
using UsersRestAPI.Model;
using UsersRestAPI.Model.Context;

namespace UsersRestAPI.Repository.Implementations
{
    public class RoleRepositoryImpl : IRoleRepository
    {
        private MySQLContext _context;
        public RoleRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public RoleRepositoryImpl()
        {
        }

        public Role Create(Role role)
        {
            try
            {
                _context.Add(role);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return role;
        }

        public void Delete(long id)
        {
            var result = _context.Roles.SingleOrDefault(u => u.Id.Equals(id));

            try
            {
                if (result != null) _context.Roles.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Role> GetAll()
        {
            return _context.Roles.ToList();
        }


        public Role GetById(long id)
        {
            return _context.Roles.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Role Update(Role role)
        {
            if (!Exist(role.Id)) return null;
            var result = _context.Roles.SingleOrDefault(u => u.Id.Equals(role.Id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(role);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return role;

        }

        public bool Exist(long? id)
        {
            return _context.Roles.Any(u => u.Id.Equals(id));
        }
    }
}
