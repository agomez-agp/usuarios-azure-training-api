using System;
using System.Collections.Generic;

#nullable disable

namespace Azure.ContactBook.Api.Data.Entities.ContactBook
{
    public partial class Group
    {
        public Group()
        {
            ContactGroups = new HashSet<ContactGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? RegisterDate { get; set; }

        public virtual ICollection<ContactGroup> ContactGroups { get; set; }
    }
}
