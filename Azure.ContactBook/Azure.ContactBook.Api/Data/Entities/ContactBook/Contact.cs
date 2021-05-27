using System;
using System.Collections.Generic;

#nullable disable

namespace Azure.ContactBook.Api.Data.Entities.ContactBook
{
    public partial class Contact
    {
        public Contact()
        {
            ContactGroups = new HashSet<ContactGroup>();
            PhoneTypeContacts = new HashSet<PhoneTypeContact>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDay { get; set; }
        public string WebSite { get; set; }
        public string Avatar { get; set; }
        public DateTime? RegisterDate { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ContactGroup> ContactGroups { get; set; }
        public virtual ICollection<PhoneTypeContact> PhoneTypeContacts { get; set; }
    }
}
