using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NotesManager.Domain.Abstract;
using NotesManager.Domain.Concrete;
using NotesManager.Domain.Entities;
using NotesManager.WebUI.Infrastructure.Concrete;
using NotesManager.WebUI.Models;
using NotesManager.WebUI.Infrastructure.Abstract;


namespace NotesManager.WebUI.Controllers
{    

    [Authorize]
    public class NoteController : Controller
    {
        private INoteRepository noteRepository;
        private IUserAccPerm userAccRepository;
        public NoteController(INoteRepository noteRep, IUserAccPerm userAccRep)
        {
            this.noteRepository = noteRep;
            this.userAccRepository = userAccRep;
        }

        public ActionResult List()
        {
           
            string userID = Request.Cookies["userID"].Value;           

            if (userID != null)
            {
                IEnumerable<NoteViewModel> notes = null;
                userAccRepository.GetUserPremissions(int.Parse(userID));         
                
                if (userAccRepository.CanViewAllNotes)
                {
                    notes = noteRepository.AllNotes().Select(c => NoteViewModel.MapEntityToDto(c));
                }

                if (userAccRepository.CanViewOwnNotes)
                {
                    notes = noteRepository.AllNotes().Where(c => c.ID_USER == int.Parse(userID) && c.ACTIVE == true).Select(c => NoteViewModel.MapEntityToDto(c));
                }

                ViewBag.CanActivateNote = userAccRepository.CanActivateNote;
                ViewBag.CanDeleteNote = userAccRepository.CanDeleteNote;
                ViewBag.CanInsertNote = userAccRepository.CanInsertNote;
                ViewBag.CanUpdateNote = userAccRepository.CanUpdateNote;
                ViewBag.UserName = (string)HttpContext.Session["UserName"];

                return View(notes);
            }
            else
            {
                return RedirectToAction("LogOut", "Account");
            }           
            
        }

        [HttpGet]
        public ActionResult Edit(int noteId)
        {
            string userID = Request.Cookies["userID"].Value;
            userAccRepository.GetUserPremissions(int.Parse(userID));
            ViewBag.CanActivateNote = userAccRepository.CanActivateNote;
            ViewBag.Title = "Edit Note";

            if (userAccRepository.CanUpdateNote)
            { 
                tbNote note = noteRepository.AllNotes()
                .FirstOrDefault(p => p.ID == noteId);
                if (note != null)
                {
                    return View(NoteViewModel.MapEntityToDto(note));
                }   
            }
            return RedirectToAction("List");                 
         }

        [HttpPost]
        public ActionResult Edit(NoteViewModel noteM)
        {               
            if (ModelState.IsValid)
            {
                tbNote note;
                string userID = Request.Cookies["userID"].Value;
                userAccRepository.GetUserPremissions(int.Parse(userID));
                ViewBag.CanActivateNote = userAccRepository.CanActivateNote;
                ViewBag.Title = "Edit Note";

                if (!userAccRepository.CanActivateNote)
                {
                    noteM.Active = true;//Default Value Active Rowd  
                }

                if (!NoteViewModel.StateInsert)
                {
                    note = noteRepository.FindNoteById(noteM.Id);
                    if (note == null)
                        return View(noteM);        

                    note = NoteViewModel.FillNote(note, noteM);//fill data in note
                    
                }
                else
                {
                    NoteViewModel.StateInsert = false;      
                    note = new tbNote();
                    note.ID_USER = int.Parse(userID); 
                    note = NoteViewModel.FillNote(note, noteM, note.ID_USER , DateTime.Now);//fill data in note
                } 
                                
                noteRepository.SaveNote(note);//Insert Or UpdateNote
                TempData["message"] = string.Format("{0} has been saved", noteM.Note);
                return RedirectToAction("List");
            }
            else
            {
                // there is something wrong return Edit window with previous data
                return View(noteM);
            }

        }

        public ActionResult Create()
        {
            string userID = Request.Cookies["userID"].Value;
            userAccRepository.GetUserPremissions(int.Parse(userID));
            ViewBag.CanActivateNote = userAccRepository.CanActivateNote;

            if (userAccRepository.CanInsertNote)
            { 
            ViewBag.Title = "Create Note";
            NoteViewModel.StateInsert = true;
            NoteViewModel Ndto = NoteViewModel.MapEntityToDto(new tbNote());
            return View("Edit", Ndto);
            }
            else
                return RedirectToAction("List");    
        }      

       public ActionResult Delete(int noteId)
        {
            string userID = Request.Cookies["userID"].Value;
            userAccRepository.GetUserPremissions(int.Parse(userID));
            if (!userAccRepository.CanDeactivateNote)
            {
                tbNote deletedNote = noteRepository.DeleteNote(noteId);
                if (deletedNote != null)
                {
                    TempData["message"] = string.Format("{0} was deleted", deletedNote.NOTE);
                }
            }
            else //Deactivate and Save Note
            {
                tbNote tbn = noteRepository.AllNotes().Where(c => c.ID == noteId).FirstOrDefault();
                tbn.ACTIVE = false;
                noteRepository.SaveNote(tbn);//Insert Or UpdateNote                   
            }
       
            return RedirectToAction("List");
        }
         public ActionResult LogOut()
         {
             return RedirectToAction("LogOut", "Account");
         } 

    }
}
