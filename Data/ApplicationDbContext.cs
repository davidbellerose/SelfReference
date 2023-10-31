using Microsoft.EntityFrameworkCore;
using SelfReference.Models;


namespace SelfReference.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Relationship> Relationships { get; set; }

        public DbSet<RelationshipType> RelationshipTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Relationship>()
            //    .HasMany(r => r.Parent)
            //    .HasForeignKey(r => r.ParentId)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Relationship>()
            //            .HasMany(r => r.Child)
            //            .HasForeignKey(r => r.ChildId)
            //            .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Contact>(b =>
            //{
            //    b.HasMany(c => c.Parent)
            //        .WithOne(r => r.Parent)
            //        .HasForeignKey(r => r.ParentId)
            //            .OnDelete(DeleteBehavior.ClientSetNull);
            //    b.HasMany(c => c.Child)
            //        .WithOne(r => r.Child)
            //        .HasForeignKey(r => r.ChildId)
            //            .OnDelete(DeleteBehavior.ClientSetNull);
            //});


            // Relationship configuration  
            modelBuilder.Entity<Relationship>(b =>
            {
                b.HasOne(r => r.Parent)
                    .WithMany(c => c.Relationships)
                    .HasForeignKey(r => r.ParentId);

                b.HasOne(r => r.Child)
                    .WithMany()
                    .HasForeignKey(r => r.ChildId);

                //b.HasOne(r => r.RelationshipType)
                //    .WithOne(rt => rt.Relationship)
                //    .HasForeignKey<RelationshipType>(rt => rt.RelationshipId);
            });
        }
    }
}
