using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NotesManager.Domain.Abstract;
using NotesManager.Domain.Concrete;
using NotesManager.Domain.Entities;
using NotesManager.WebUI.Infrastructure.Abstract;

namespace NotesManager.WebUI.Infrastructure.Concrete
{
    public class UserAccPerm : IUserAccPerm
    {
        private IUserAccessPermissions uapRepository;
        public UserAccPerm(IUserAccessPermissions uap)
        {
            this.uapRepository = uap;
        }
        enum PermissionType : byte
        {
            CanInsertNote = 1,
            CanUpdateNote,
            CanDeleteNote,
            CanDeactivateNote,
            CanActivateNote,
            CanInsertUser,
            CanDeleteUser,
            CanUpdateUser,
            CanViewAllNotes,
            CanViewOwnNotes
        }

        public bool CanInsertNote {get; set;}
        public bool CanUpdateNote {get; set;} 
        public bool CanDeleteNote {get; set;}
        public bool CanDeactivateNote {get; set;}
        public bool CanActivateNote {get; set;}
        public bool CanInsertUser {get; set;}
        public bool CanDeleteUser {get; set;}
        public bool CanUpdateUser {get; set;}
        public bool CanViewAllNotes {get; set;}
        public bool CanViewOwnNotes { get; set; }
        

        public void GetUserPremissions(int idUser)
        {                        
            int[] arrPermission = uapRepository.GetUserPermissions(idUser);

            if (arrPermission.Length != 0)
            {
                for(int i = 0; i < arrPermission.Length; i++)
                {
                  switch (arrPermission[i])
                  {
                   case (byte)PermissionType.CanInsertNote:
                    CanInsertNote = true;
                  break;
                   case (byte)PermissionType.CanUpdateNote:
                  CanUpdateNote = true;
                  break;
                   case (byte)PermissionType.CanDeleteNote:
                  CanDeleteNote = true;
                  break;
                   case (byte)PermissionType.CanDeactivateNote:
                  CanDeactivateNote = true;
                  break;
                    case (byte)PermissionType.CanActivateNote:
                  CanActivateNote = true;
                  break;
                    case (byte)PermissionType.CanInsertUser:
                  CanInsertUser = true;
                  break;
                    case (byte)PermissionType.CanDeleteUser:
                  CanDeleteUser = true;
                  break;
                    case (byte)PermissionType.CanUpdateUser:
                  CanUpdateUser = true;
                  break;
                    case (byte)PermissionType.CanViewAllNotes:
                  CanViewAllNotes = true;
                  break;
                    case  (byte)PermissionType.CanViewOwnNotes:
                  CanViewOwnNotes = true;
                  break;
                 }

                }
              }
                   
        }
    }
}