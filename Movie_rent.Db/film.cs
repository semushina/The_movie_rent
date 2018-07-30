namespace Movie_rent.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public film()
        {
            orders = new HashSet<order>();
            clients = new HashSet<client>();
            actors = new HashSet<actor>();
            directors = new HashSet<director>();
            genres = new HashSet<genre>();
        }

        public override string ToString()
        {
            return name;
        }

        [DisplayName("¹")]
        public int id { get; set; }

        [Required]
        [StringLength(128)]
        [DisplayName("Name")]
        public string name { get; set; }

        [DisplayName("Year")]
        public int year { get; set; }

        [DisplayName("Duration")]
        public int duration { get; set; }

        [DisplayName("Available")]
        public virtual available_films available_films { get; set; }
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DisplayName("In wishlist")]
        public virtual ICollection<client> clients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DisplayName("Actors")]
        public virtual ICollection<actor> actors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DisplayName("Directors")]
        public virtual ICollection<director> directors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DisplayName("Genres")]
        public virtual ICollection<genre> genres { get; set; }
    }
}
