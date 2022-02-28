using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apiDance.Models
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Instructores> Instructores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructores>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Instructores>()
                .Property(e => e.apelidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Instructores>()
                .Property(e => e.apellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Instructores>()
                .Property(e => e.edad)
                .IsUnicode(false);

            modelBuilder.Entity<Instructores>()
                .Property(e => e.foto)
                .IsUnicode(false);
        }
    }
}
