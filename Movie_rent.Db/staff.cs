namespace Movie_rent.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("staff")]
    public partial class staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public staff()
        {
            orders = new HashSet<order>();
        }

        [DisplayName("¹")]
        public int id { get; set; }

        [Required]
        [StringLength(128)]
        [DisplayName("First Name")]
        public string fname { get; set; }

        [Required]
        [StringLength(128)]
        [DisplayName("Last Name")]
        public string lname { get; set; }

        [DisplayName("Type")]
        public int type { get; set; }

        [Required]
        [StringLength(128)]
        [DisplayName("Login")]
        public string login { get; set; }

        [Required]
        [StringLength(128)]
        [DisplayName("Password")]
        public string password { get; set; }
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }

        public override string ToString()
        {
            return fname + " " + lname;
        }
    }
}
