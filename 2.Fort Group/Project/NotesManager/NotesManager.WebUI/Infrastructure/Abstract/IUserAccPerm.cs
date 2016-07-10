using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesManager.WebUI.Infrastructure.Abstract
{
    public interface IUserAccPerm
    {
         bool CanInsertNote { get; set; }
         bool CanUpdateNote { get; set; }
         bool CanDeleteNote { get; set; }
         bool CanDeactivateNote { get; set; }
         bool CanActivateNote { get; set; }
         bool CanInsertUser { get; set; }
         bool CanDeleteUser { get; set; }
         bool CanUpdateUser { get; set; }
         bool CanViewAllNotes { get; set; }
         bool CanViewOwnNotes { get; set; }
         void GetUserPremissions(int idUser);
    }
}
