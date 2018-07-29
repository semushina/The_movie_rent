namespace test
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MrDb : DbContext
    {
        public MrDb()
            : base("name=MrDb")
        {
        }

        public virtual DbSet<actors> actors { get; set; }
        public virtual DbSet<available_films> available_films { get; set; }
        public virtual DbSet<clients> clients { get; set; }
        public virtual DbSet<directors> directors { get; set; }
        public virtual DbSet<films> films { get; set; }
        public virtual DbSet<genres> genres { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<staff> staff { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<actors>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<actors>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<actors>()
                .HasMany(e => e.films)
                .WithMany(e => e.actors)
                .Map(m => m.ToTable("film_actor").MapLeftKey("actor_id").MapRightKey("film_id"));

            modelBuilder.Entity<clients>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.tel_number)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.clients)
                .HasForeignKey(e => e.client_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<clients>()
                .HasMany(e => e.films)
                .WithMany(e => e.clients)
                .Map(m => m.ToTable("client_wishlist").MapLeftKey("client_id").MapRightKey("film_id"));

            modelBuilder.Entity<directors>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<directors>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<directors>()
                .HasMany(e => e.films)
                .WithMany(e => e.directors)
                .Map(m => m.ToTable("film_director").MapLeftKey("director_id").MapRightKey("film_id"));

            modelBuilder.Entity<films>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<films>()
                .HasOptional(e => e.available_films)
                .WithRequired(e => e.films)
                .WillCascadeOnDelete();

            modelBuilder.Entity<films>()
                .HasMany(e => e.genres)
                .WithMany(e => e.films)
                .Map(m => m.ToTable("film_genre").MapLeftKey("film_id").MapRightKey("genre_id"));

            modelBuilder.Entity<genres>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<orders>()
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
