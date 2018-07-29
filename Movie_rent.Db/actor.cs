namespace Movie_rent.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class actor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public actor()
        {
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<film> films { get; set; }
    }
}
