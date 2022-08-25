using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OxfordMarvelDb.Models.DB_Model
{
    public partial class OxfordDb : DbContext
    {
        public OxfordDb()
            : base("name=OxfordDb")
        {
        }

        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<customer> customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<student>()
                .Property(e => e.student_id)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.student_name)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.student_email)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.ContactName)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Country)
                .IsUnicode(false);
        }
    }
}
