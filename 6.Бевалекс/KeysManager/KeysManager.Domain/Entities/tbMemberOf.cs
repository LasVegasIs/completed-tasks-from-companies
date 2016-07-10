namespace KeysManager.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbMemberOf")]
    public partial class tbMemberOf
    {
        public int ID { get; set; }

        public int ID_GROUP { get; set; }

        public int ID_USER { get; set; }

        public virtual tbGroup tbGroup { get; set; }
    }
}
