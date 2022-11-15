namespace WindowsFormsApp122.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_payment
    {
        public int id { get; set; }

        public int? users_id { get; set; }

        public string payment_type { get; set; }

        public string providers { get; set; }

        public int? account_no { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expiry { get; set; }

        public virtual user user { get; set; }
    }
}
