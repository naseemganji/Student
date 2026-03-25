using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Student
{
    public partial class StudentEntity : DbContext
    {
        public StudentEntity()
            : base("name=StudentEntity")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.firstName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.lastName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.address)
                .IsUnicode(false);
        }
    }
}
