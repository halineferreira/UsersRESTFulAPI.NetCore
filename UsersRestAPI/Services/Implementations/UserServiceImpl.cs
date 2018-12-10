using System;
using System.Collections.Generic;
using System.Threading;
using UsersRestAPI.Model;

namespace UsersRestAPI.Services.Implementations
{
    public class UserServiceImpl : IUserService
    {
        private volatile int count;

        public UserServiceImpl()
        {
        }

        public User Create(User person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            for (int i = 0; i<=10; i++)
            {
                User user = MockUser(i);
                users.Add(user);
            }
            return users;
        }

        private User MockUser(int i)
        {
            return new User
            {
                Id = IncrementAndGet() + i,
                /*Role = {
                    Id = 1,
                    Name = "Role",
                    Description = "description"
                    },*/
                FirstName = "Name",
                LastName = "Last Name",
                Phone = "phone",
                Picture = "pic"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public User GetById(long id)
        {
            return new User
            {
                Id = IncrementAndGet(),
                /*Role = {
                    Id = 1,
                    Name = "Role",
                    Description = "description"
                    },*/
                FirstName = "Haline",
                LastName = "Ferreira",
                Phone = "(16) 99732-6233",
                Picture = "test"
            };
        }

        public User Update(User person)
        {
            return person;
        }
    }
}
