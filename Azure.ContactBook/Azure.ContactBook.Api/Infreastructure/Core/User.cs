using Azure.ContactBook.Api.Data.Entities.ContactBook;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ContactBook.Api.Infreastructure.Core
{
    public class User
    {
        private readonly ContactBookContext _context;
        
        public User(ContactBookContext context)
        {
            _context = context;
        }
        
        public List<Data.Entities.ContactBook.User> GetAll()
        {
            return _context.Users.ToList();
        }

        public Data.Entities.ContactBook.User Get(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public Data.Entities.ContactBook.User Insert(Data.Entities.ContactBook.User user)
        {
            _context.Users.Add(user);
            return _context.SaveChanges() > 0 ? user : null;
        }

        public List<Data.Entities.ContactBook.User> Update(Data.Entities.ContactBook.User user)
        {
            _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _context.SaveChanges() > 0 ? GetAll() : null;
        }


        public List<Data.Entities.ContactBook.User> Delete(int id)
        {
            var getUser = Get(id);
            if (getUser != null)
            {
                _context.Users.Remove(getUser);
                return _context.SaveChanges() > 0 ? GetAll() : null;
            }
            return null;
        }
    }

}
