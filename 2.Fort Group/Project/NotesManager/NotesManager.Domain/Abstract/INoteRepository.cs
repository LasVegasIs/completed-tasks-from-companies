using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesManager.Domain.Entities;

namespace NotesManager.Domain.Abstract
{
    public interface INoteRepository
    {
        IEnumerable<tbNote> AllNotes();
        bool SaveNote(tbNote note);
        tbNote DeleteNote(int noneId);
        tbNote FindNoteById(int id);
        IEnumerable<tbNote> GetNotesByUser(int shopId);
    }
}
