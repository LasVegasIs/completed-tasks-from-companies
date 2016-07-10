namespace KeysManager.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbUser
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string LOGIN { get; set; }

        [Required]
        [StringLength(20)]
        public string PASSWORD { get; set; }

        public int? ID_RIGHT { get; set; }

        public virtual tbRight tbRight { get; set; }
    }
}
