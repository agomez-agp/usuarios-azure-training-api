using System;
using System.Collections.Generic;

#nullable disable

namespace Azure.ContactBook.Api.Data.Entities.ContactBook
{
    public partial class User
    {
        public User()
        {
            Contacts = new HashSet<Contact>();
            Passwords = new HashSet<Password>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Password> Passwords { get; set; }
    }
}
