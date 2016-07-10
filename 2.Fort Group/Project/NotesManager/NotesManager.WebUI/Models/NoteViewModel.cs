namespace NotesManager.WebUI.Models
{
    using NotesManager.Domain.Entities;
    using System;
    using System.Web.Mvc;
    using System.ComponentModel.DataAnnotations;

    public class NoteViewModel
    {
        private static bool stateInsert = false;

       [HiddenInput(DisplayValue = false)]
        public static bool StateInsert { get { return stateInsert; } set { stateInsert = value; } }

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a Note")]
        public string Note { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a MainText")]
        public string MainText { get; set; }

        public string Thought { get; set; }
        public string Idea { get; set; }
        public string Remark { get; set; }

        public string Comment { get; set; }
        public bool Active { get; set; }
        public static NoteViewModel MapEntityToDto(tbNote note)
        {
            return new NoteViewModel
                   {
                       Id = note.ID,
                       Note = note.NOTE,
                       MainText = note.MAIN_TEXT,
                       Thought = note.THOUGHT,
                       Idea = note.IDEA,
                       Remark = note.REMARK,
                       Comment = note.COMMENT,
                       Active = note.ACTIVE            
                   };
        }

        //General Fill version
        public static tbNote FillNote(tbNote note, NoteViewModel dto)
        {                            
                note.NOTE = dto.Note;
                note.MAIN_TEXT = dto.MainText;
                note.THOUGHT = dto.Thought;
                note.IDEA = dto.Idea;
                note.REMARK = dto.Remark;
                note.COMMENT = dto.Comment;
                note.ACTIVE = dto.Active;
                return note;
        }


        //version for update and insert
        public static tbNote FillNote(tbNote note, NoteViewModel dto, int id_user, DateTime dat_create)
        {
            tbNote tbn = FillNote(note, dto);
            tbn.ID_USER = id_user;
            tbn.DATE_CREATE = dat_create;

            return tbn;
        }

        //version for delete
        public static tbNote FillNote(tbNote note, NoteViewModel dto, bool Activ)
        {
            tbNote tbn = FillNote(note, dto);
            tbn.ACTIVE = Activ;
            return tbn;
        }
    }
}
