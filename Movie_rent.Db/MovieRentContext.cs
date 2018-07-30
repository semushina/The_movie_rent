namespace Movie_rent.Db
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieRentContext : DbContext
    {
        public MovieRentContext()
            : base("name=MovieRentContext")
        {
        }

        public virtual DbSet<actor> actors { get; set; }
        public virtual DbSet<available_films> available_films { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<director> directors { get; set; }
        public virtual DbSet<film> films { get; set; }
        public virtual DbSet<genre> genres { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<actor>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<actor>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<actor>()
                .HasMany(e => e.films)
                .WithMany(e => e.actors)
                .Map(m => m.ToTable("film_actor"));

            modelBuilder.Entity<client>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.tel_number)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.client)
                .HasForeignKey(e => e.client_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.films)
                .WithMany(e => e.clients)
                .Map(m => m.ToTable("client_wishlist"));

            modelBuilder.Entity<director>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<director>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<director>()
                .HasMany(e => e.films)
                .WithMany(e => e.directors)
                .Map(m => m.ToTable("film_director"));

            modelBuilder.Entity<film>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<film>()
                .HasOptional(e => e.available_films)
                .WithRequired(e => e.film)
                .WillCascadeOnDelete();

            modelBuilder.Entity<film>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.film)
                .HasForeignKey(e => e.film_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<film>()
                .HasMany(e => e.genres)
                .WithMany(e => e.films)
                .Map(m => m.ToTable("film_genre"));

            modelBuilder.Entity<genre>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<staff>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.staff)
                .HasForeignKey(e => e.staff_id)
                .WillCascadeOnDelete(false);
        }
    }
}
