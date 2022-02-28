using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apiDance.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Clases> Clases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clases>()
                .Property(e => e.Dias)
                .IsUnicode(false);

            modelBuilder.Entity<Clases>()
                .Property(e => e.Tema)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<apiDance.Models.Instructores> Instructores { get; set; }
    }
}
