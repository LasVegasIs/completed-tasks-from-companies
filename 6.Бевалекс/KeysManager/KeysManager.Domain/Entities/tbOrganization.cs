namespace KeysManager.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbOrganization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbOrganization()
        {
            tbDevices = new HashSet<tbDevice>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(256)]
        public string NAME { get; set; }

        [Required]
        [StringLength(128)]
        public string NUM_CONTR { get; set; }

        public int LIM_KEYS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDevice> tbDevices { get; set; }
    }
}
