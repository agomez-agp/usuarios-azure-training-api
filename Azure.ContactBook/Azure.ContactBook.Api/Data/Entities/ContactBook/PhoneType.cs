using System;
using System.Collections.Generic;

#nullable disable

namespace Azure.ContactBook.Api.Data.Entities.ContactBook
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            PhoneTypeContacts = new HashSet<PhoneTypeContact>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PhoneTypeContact> PhoneTypeContacts { get; set; }
    }
}
