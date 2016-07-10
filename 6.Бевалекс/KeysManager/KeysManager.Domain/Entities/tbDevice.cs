namespace KeysManager.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbDevice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbDevice()
        {
            tbKeys = new HashSet<tbKey>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(32)]
        public string CODE_KEY { get; set; }

        [Required]
        [StringLength(128)]
        public string NAME_OWNER { get; set; }

        [Required]
        [StringLength(128)]
        public string JOB_POSITION { get; set; }

        public int ID_ORG { get; set; }

        public virtual tbOrganization tbOrganization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbKey> tbKeys { get; set; }
    }
}
