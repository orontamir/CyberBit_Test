using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberBit.Models
{
    public interface IUser
    {
        User GetUser(string name);
    }
}
