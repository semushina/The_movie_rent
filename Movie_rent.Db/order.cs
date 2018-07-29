namespace Movie_rent.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class order
    {
        public int id { get; set; }

        public int film_id { get; set; }

        public DateTime issue_date { get; set; }

        public DateTime return_date { get; set; }

        public int staff_id { get; set; }

        [Column(TypeName = "money")]
        public decimal cost { get; set; }

        public int client_id { get; set; }

        public virtual client client { get; set; }

        public virtual staff staff { get; set; }
    }
}
