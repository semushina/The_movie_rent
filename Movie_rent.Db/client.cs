namespace Movie_rent.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public client()
        {
            orders = new HashSet<order>();
            films = new HashSet<film>();
        }
        public override string ToString()
        {
            return fname + " " + lname;
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

        [Required]
        [StringLength(128)]
        [DisplayName("Tel.")]
        public string tel_number { get; set; }
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<film> films { get; set; }
    }
}
