namespace NotesManager.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbNote
    {
        public int ID { get; set; }

        [StringLength(70)]
        public string NOTE { get; set; }

        [Required]
        [StringLength(250)]
        public string MAIN_TEXT { get; set; }

        [StringLength(150)]
        public string THOUGHT { get; set; }

        [StringLength(100)]
        public string IDEA { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string COMMENT { get; set; }

        public int ID_USER { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_CREATE { get; set; }

        public bool ACTIVE { get; set; }

        public virtual tbUser tbUser { get; set; }
    }
}
