namespace WindowsFormsApp122.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            cart_item = new HashSet<cart_item>();
            order_items = new HashSet<order_items>();
        }

        public int id { get; set; }

        public string name_product { get; set; }

        public string desc_product { get; set; }

        public int? category_id { get; set; }

        public int? inventory_id { get; set; }

        public decimal? price { get; set; }

        public int? discount_id { get; set; }

        public string image_url { get; set; }

        [Column(TypeName = "date")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "date")]
        public DateTime? modified_at { get; set; }

        [Column(TypeName = "date")]
        public DateTime? deleted_at { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cart_item> cart_item { get; set; }

        public virtual discount discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_items> order_items { get; set; }

        public virtual product_category product_category { get; set; }

        public virtual product_inventory product_inventory { get; set; }
    }
}
