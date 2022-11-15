using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace WindowsFormsApp122.Models
{
    public partial class DatabaseEC : DbContext
    {
        public DatabaseEC()
            : base("name=DatabaseEC")
        {
        }

        public virtual DbSet<cart_item> cart_item { get; set; }
        public virtual DbSet<discount> discounts { get; set; }
        public virtual DbSet<order_details> order_details { get; set; }
        public virtual DbSet<order_items> order_items { get; set; }
        public virtual DbSet<payment_details> payment_details { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<product_category> product_category { get; set; }
        public virtual DbSet<product_inventory> product_inventory { get; set; }
        public virtual DbSet<shopping_session> shopping_session { get; set; }
        public virtual DbSet<user_address> user_address { get; set; }
        public virtual DbSet<user_payment> user_payment { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<discount>()
                .Property(e => e.discount_percent)
                .HasPrecision(18, 0);

            modelBuilder.Entity<discount>()
                .HasMany(e => e.products)
                .WithOptional(e => e.discount)
                .HasForeignKey(e => e.discount_id);

            modelBuilder.Entity<order_details>()
                .Property(e => e.total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<order_details>()
                .HasMany(e => e.order_items)
                .WithOptional(e => e.order_details)
                .HasForeignKey(e => e.order_id);

            modelBuilder.Entity<payment_details>()
                .HasMany(e => e.order_details)
                .WithOptional(e => e.payment_details)
                .HasForeignKey(e => e.payment_id);

            modelBuilder.Entity<product>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<product>()
                .HasMany(e => e.cart_item)
                .WithOptional(e => e.product)
                .HasForeignKey(e => e.product_id);

            modelBuilder.Entity<product>()
                .HasMany(e => e.order_items)
                .WithOptional(e => e.product)
                .HasForeignKey(e => e.product_id);

            modelBuilder.Entity<product_category>()
                .HasMany(e => e.products)
                .WithOptional(e => e.product_category)
                .HasForeignKey(e => e.category_id);

            modelBuilder.Entity<product_inventory>()
                .HasMany(e => e.products)
                .WithOptional(e => e.product_inventory)
                .HasForeignKey(e => e.inventory_id);

            modelBuilder.Entity<shopping_session>()
                .Property(e => e.total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<shopping_session>()
                .HasMany(e => e.cart_item)
                .WithOptional(e => e.shopping_session)
                .HasForeignKey(e => e.session_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.order_details)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.users_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.shopping_session)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.users_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.user_address)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.users_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.user_payment)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.users_id);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
