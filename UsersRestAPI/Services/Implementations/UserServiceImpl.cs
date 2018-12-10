﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UsersRestAPI.Model;
using UsersRestAPI.Model.Context;

namespace UsersRestAPI.Services.Implementations
{
    public class UserServiceImpl : IUserService
    {
        private MySQLContext _context;
        public UserServiceImpl(MySQLContext context)
        {
            _context = context;
        }
        private volatile int count;

        public UserServiceImpl()
        {
        }

        public User Create(User user)
        {
            try
            {
                _context.Add(user);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }

        public void Delete(long id)
        {
            var result = _context.Users.SingleOrDefault(u => u.Id.Equals(id));
            
            try
            {
                if (result != null) _context.Users.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }


        public User GetById(long id)
        {
            return _context.Users.SingleOrDefault(p => p.Id.Equals(id));
        }

        public User Update(User user)
        {
            if (!Exist(user.Id)) return new User();
            var result = _context.Users.SingleOrDefault(u => u.Id.Equals(user.Id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(user);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;

        }

        private bool Exist(long? id)
        {
            return _context.Users.Any(u => u.Id.Equals(id));
        }
    }
}
