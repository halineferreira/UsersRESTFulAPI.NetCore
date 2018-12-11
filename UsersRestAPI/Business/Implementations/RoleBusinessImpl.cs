using System;
using System.Collections.Generic;
using System.Threading;
using UsersRestAPI.Model;
using UsersRestAPI.Repository;

namespace UsersRestAPI.Business.Implementations
{
    public class RoleBusinessImpl : IRoleBusiness
    {
        private IRoleRepository _repository;

        public RoleBusinessImpl(IRoleRepository repository)
        {
            _repository = repository;
        }

        public Role Create(Role role)
        {
            return _repository.Create(role);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Role> GetAll()
        {
            return _repository.GetAll();
        }

        public Role GetById(long id)
        {
            return _repository.GetById(id);
        }

        public Role Update(Role role)
        {
            return _repository.Update(role);
        }
    }
}
