namespace Movie_rent.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class available_films
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int film_id { get; set; }

        public int dvd { get; set; }

        public int bluray { get; set; }

        public virtual film film { get; set; }
    }
}
