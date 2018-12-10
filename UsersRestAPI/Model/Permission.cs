﻿using System.Collections.Generic;

namespace UsersRestAPI.Model
{
    public class Permission
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PermissionRole> PermissionRole { get; set; }
    }
}
