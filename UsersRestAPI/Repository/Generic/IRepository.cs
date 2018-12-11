using System;
using System.Collections.Generic;
using UsersRestAPI.Model.Base;

namespace UsersRestAPI.Repository.Generic
{
    public interface IRepository<T> where T: BaseEntity
    {
        T Create(T item);
        T Update(T item);
        List<T> GetAll();
        T GetById(long id);
        void Delete(long id);

        bool Exists(long? id);
    }
}
