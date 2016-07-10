using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesManager.Domain.Entities;

namespace NotesManager.Domain.Abstract
{
   public interface IUserRepository
    {
        IEnumerable<tbUser> AllUsers();

        bool AuthenticateUser(string name, string pass);

        tbUser GetUser(string name, string pass);

        bool AddUser(tbUser user);

    }
}
