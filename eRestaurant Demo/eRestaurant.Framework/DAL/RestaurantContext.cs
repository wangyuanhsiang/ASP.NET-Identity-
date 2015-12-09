using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eRestaurant.Framework.Entities;


namespace eRestaurant.Framework.DAL
{
    internal class RestaurantContext : DbContext
    {
        public RestaurantContext() : base("DefaultConnection") { }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Waiter> Waiters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasMany(t => t.Tables)
                .WithMany(r => r.Reservations)
                .Map(mapping =>
                {
                    mapping.ToTable("ReservationTables");
                    mapping.MapLeftKey("ReservationID");
                    mapping.MapRightKey("TableID");
                }
                );

            base.OnModelCreating(modelBuilder);
        }


    }
}
