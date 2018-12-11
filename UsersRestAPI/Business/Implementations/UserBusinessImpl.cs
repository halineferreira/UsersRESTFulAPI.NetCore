using System;
using System.Collections.Generic;
using System.Linq;
using UsersRestAPI.Model;
using UsersRestAPI.Model.Context;
using UsersRestAPI.Repository;

namespace UsersRestAPI.Business.Implementations
{
    public class UserBusinessImpl : IUserBusiness
    {
        private IUserRepository _repository;

        public UserBusinessImpl(IUserRepository repository)
        {
            _repository = repository;
        }

        public User Create(User user)
        {
            return _repository.Create(user);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User GetById(long id)
        {
            return _repository.GetById(id);
        }

        public User Update(User user)
        {
            return _repository.Update(user);
        }
    }
}
