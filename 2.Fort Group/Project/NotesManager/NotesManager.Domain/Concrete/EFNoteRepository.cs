using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesManager.Domain.Abstract;
using System.Data.SqlClient;
using System.Data.Entity.Core.Objects;
using NotesManager.Domain.Entities;

namespace NotesManager.Domain.Concrete
{
    public class EFNoteRepository: INoteRepository
    {
        private EFDbContext context = new EFDbContext();

        public EFNoteRepository()
        { }

        public IEnumerable<tbNote> AllNotes()
        {
            return context.tbNotes.ToList();
        }

        public tbNote FindNoteById(int id)
        {
            var result = from r in context.tbNotes
                         where r.ID == id
                         select r;
            if (result == null) return null;
            else return result.FirstOrDefault();
        }
        public IEnumerable<tbNote> GetNotesByUser(int idUser)
        {
            return context.tbNotes.Where(n => n.ID_USER == idUser).ToList(); //valid for nuull
        }

        public bool SaveNote(tbNote note)
        {
            if (note.ID == 0)
            {
                context.tbNotes.Add(note);//insert record
            }
            else
            {
                tbNote noteEntry = context.tbNotes.Find(note.ID);
                if (note != null)
                {
                    noteEntry.NOTE = note.NOTE;
                    noteEntry.MAIN_TEXT = note.MAIN_TEXT;
                    noteEntry.THOUGHT = note.THOUGHT;
                    noteEntry.IDEA = note.IDEA;
                    noteEntry.REMARK = note.REMARK;
                    noteEntry.COMMENT = note.COMMENT;

                }
            }
            return SaveData();
        }

        public tbNote DeleteNote(int noteId)
        {
            tbNote noteEntry = context.tbNotes.Find(noteId);
        if (noteEntry != null)
            {
            context.tbNotes.Remove(noteEntry);
            SaveData();
            }
           return noteEntry;             
        }   


        private bool SaveData()
        {
            return context.SaveChanges() > 0;
        }       
    }
}
