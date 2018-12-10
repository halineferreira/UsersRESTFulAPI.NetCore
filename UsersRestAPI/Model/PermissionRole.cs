using System;
using System.Collections.Generic;

namespace UsersRestAPI.Model
{
    public class PermissionRole
    {
        public long PermissionId { get; set; }
        public Permission Permission { get; set; }
        public long RoleId { get; set; }
        public Role Role { get; set; }
    }
}
