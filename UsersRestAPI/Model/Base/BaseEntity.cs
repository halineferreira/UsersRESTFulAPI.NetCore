using System;
using System.Runtime.Serialization;

namespace UsersRestAPI.Model.Base
{
    [DataContract]
    public class BaseEntity
    {
        public long? Id { get; set; }
    }
}
