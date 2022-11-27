namespace WindowsFormsApp122.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class order_items
    {
        public int id { get; set; }

        public int? order_id { get; set; }

        public int? product_id { get; set; }

        public int? quanlity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "date")]
        public DateTime? modified_at { get; set; }

        public virtual order_details order_details { get; set; }

        public virtual product product { get; set; }
    }
}
