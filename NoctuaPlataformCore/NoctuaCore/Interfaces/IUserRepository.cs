using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoctuaCore.Interfaces
{
    public interface IUserRepository 
    {
        string Insert(User user);
        string Delete(int id);
        string Update(int id, User user);
        User getUser(int id);
    }
}
