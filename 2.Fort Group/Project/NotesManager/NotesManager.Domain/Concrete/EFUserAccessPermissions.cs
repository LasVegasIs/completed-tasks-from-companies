using NotesManager.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesManager.Domain.Entities;

namespace NotesManager.Domain.Concrete
{
    public class EFUserAccessPermissions : IUserAccessPermissions
    {
        private EFDbContext context = new EFDbContext();

        public EFUserAccessPermissions()
        { }
        public int[] GetUserPermissions(int id_user)
        {
            int[] cc = (from u in context.tbUsers
                      from r in context.tbRoles
                      from rp in context.tbRolePremissions
                     where u.ID_ROLE == r.ID && 
                           r.ID == rp.ID_ROLE &&
                           u.ID == id_user
                             select rp.ID_PREMISSION).ToArray();
            return cc;
        }
    }
}
