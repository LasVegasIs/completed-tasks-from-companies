namespace KeysManager.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbKey
    {
        public int ID { get; set; }

        [Required]
        [StringLength(64)]
        public string VALUE { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_START { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_END { get; set; }

        public bool TEST { get; set; }

        public int ID_DEV { get; set; }

        public virtual tbDevice tbDevice { get; set; }
    }
}
