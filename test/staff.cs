namespace test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("staff")]
    public partial class staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public staff()
        {
            orders = new HashSet<orders>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(128)]
        public string fname { get; set; }

        [Required]
        [StringLength(128)]
        public string lname { get; set; }

        public int type { get; set; }

        [Required]
        [StringLength(128)]
        public string login { get; set; }

        [Required]
        [StringLength(128)]
        public string password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }
    }
}
