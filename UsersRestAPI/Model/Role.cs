using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UsersRestAPI.Model.Base;

namespace UsersRestAPI.Model
{
    [Table("roles")]
    public class Role : BaseEntity
    {
        [Key]
        [Column("id_rol")]
        public long Id { get; set; }

        [Column("nombre")]
        public string Name { get; set; }

        [Column("descripcion")]
        public string Description { get; set; }

        public List<User> Users { get; set; }

        public List<PermissionRole> PermissionRole { get; set; }
    }
}
