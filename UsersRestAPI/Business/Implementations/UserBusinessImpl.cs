using System.Collections.Generic;
using UsersRestAPI.Model;
using UsersRestAPI.Repository.Generic;

namespace UsersRestAPI.Business.Implementations
{
    public class UserBusinessImpl : IUserBusiness
    {
        private IRepository<User> _repository;

        public UserBusinessImpl(IRepository<User> repository)
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
