using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesManager.Domain.Abstract
{
   public interface IUserAccessPermissions
    {
        int[] GetUserPermissions(int id_user);
    }
}
