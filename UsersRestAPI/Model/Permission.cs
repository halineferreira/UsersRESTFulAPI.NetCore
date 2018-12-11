using System.Collections.Generic;
using UsersRestAPI.Model.Base;

namespace UsersRestAPI.Model
{
    public class Permission : BaseEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PermissionRole> PermissionRole { get; set; }
    }
}
