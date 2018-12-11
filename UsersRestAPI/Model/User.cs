using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersRestAPI.Model
{
    [Table("usuarios")]
    public class User
    {
        [Key]
        [Column("id_usuario")]
        public long? Id { get; set; }

        [ForeignKey("id_rol")]
        public Role Role { get; set; }

        [Column("nombre")]
        public string FirstName { get; set; }

        [Column("apellido")]
        public string LastName { get; set; }

        [Column("telefono")]
        public string Phone { get; set; }

        [Column("foto")]
        public string Picture { get; set; }

    }
}
