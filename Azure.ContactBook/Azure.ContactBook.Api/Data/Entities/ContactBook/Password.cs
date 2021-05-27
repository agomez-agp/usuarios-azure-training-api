using System;
using System.Collections.Generic;

#nullable disable

namespace Azure.ContactBook.Api.Data.Entities.ContactBook
{
    public partial class Password
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegisterDate { get; set; }

        public virtual User User { get; set; }
    }
}
