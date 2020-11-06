namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class shop2db : DbContext
    {
        public shop2db()
            : base("name=shop2db")
        {
        }

        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(e => e.price)
                .HasPrecision(18, 0);
        }
    }
}
