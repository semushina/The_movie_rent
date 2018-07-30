namespace Movie_rent.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class order
    {
        [DisplayName("¹")]
        public int id { get; set; }
        [Browsable(false)]
        public int film_id { get; set; }
        [DisplayName("Issue Date")]
        public DateTime issue_date { get; set; }
        [DisplayName("Return Date")]
        public DateTime return_date { get; set; }
        [Browsable(false)]
        public int staff_id { get; set; }
        [DisplayName("Cost")]
        [Column(TypeName = "money")]
        public decimal cost { get; set; }
        [Browsable(false)]
        public int client_id { get; set; }
        [DisplayName("Client")]
        public virtual client client { get; set; }
        [DisplayName("Film")]
        public virtual film film { get; set; }
        [DisplayName("Staff")]
        public virtual staff staff { get; set; }


    }
}
