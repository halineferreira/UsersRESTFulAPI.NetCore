using System;
namespace UsersRestAPI.Model
{
    public class User
    {
        public long Id { get; set; }
        //public Role Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }

    }
}
