using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UsersRestAPI.Model.Base;

namespace UsersRestAPI.Model
{
    [Table("roles_permissos")]
    public class PermissionRole : BaseEntity
    {
        [Key]
        [Column("id_permiso")]
        public long PermissionId { get; set; }
        public Permission Permission { get; set; }

        [Column("id_rol")]
        public long RoleId { get; set; }
        public Role Role { get; set; }
    }
}
