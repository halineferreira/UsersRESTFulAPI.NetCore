using System;
using System.Collections.Generic;
using System.Threading;
using UsersRestAPI.Model;
using UsersRestAPI.Repository;
using UsersRestAPI.Repository.Generic;

namespace UsersRestAPI.Business.Implementations
{
    public class PermissionBusinessImpl : IPermissionBusiness
    {
        private IRepository<Permission> _repository;

        public PermissionBusinessImpl(IRepository<Permission> repository)
        {
            _repository = repository;
        }

        public Permission Create(Permission permission)
        {
            return _repository.Create(permission);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Permission> GetAll()
        {
            return _repository.GetAll();
        }

        public Permission GetById(long id)
        {
            return _repository.GetById(id);
        }

        public Permission Update(Permission permission)
        {
            return _repository.Update(permission);
        }
    }
}
