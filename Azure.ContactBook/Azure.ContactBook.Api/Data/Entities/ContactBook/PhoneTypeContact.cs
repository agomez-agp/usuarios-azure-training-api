using System;
using System.Collections.Generic;

#nullable disable

namespace Azure.ContactBook.Api.Data.Entities.ContactBook
{
    public partial class PhoneTypeContact
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int PhoneTypeId { get; set; }
        public string Phone { get; set; }
        public DateTime? RegisterDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual PhoneType PhoneType { get; set; }
    }
}
