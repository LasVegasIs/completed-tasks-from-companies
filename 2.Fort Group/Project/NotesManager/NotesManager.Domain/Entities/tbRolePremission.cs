namespace NotesManager.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbRolePremission
    {
        public int ID { get; set; }

        public int ID_ROLE { get; set; }

        public int ID_PREMISSION { get; set; }

        public virtual tbPremission tbPremission { get; set; }

        public virtual tbRole tbRole { get; set; }
    }
}
