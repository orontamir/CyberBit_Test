using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberBit.Models
{
    public class SQLUser : IUser
    {
        private readonly AppDbContext context;
        public SQLUser(AppDbContext _context)
        {
            this.context = _context;
        }
               
        public User GetUser(string name)
        {
            return context.Users.SingleOrDefault(o => o.Name == name);
        }
    }
}
