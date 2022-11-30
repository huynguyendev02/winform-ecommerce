namespace WindowsFormsApp122.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_address
    {
        public int id { get; set; }

        public int? users_id { get; set; }

        public string address_line1 { get; set; }

        public string address_line2 { get; set; }

        public string city { get; set; }

        public string postal_code { get; set; }

        public string country { get; set; }

        public string telephone { get; set; }

        public string mobile { get; set; }

        public virtual user user { get; set; }
    }
}
