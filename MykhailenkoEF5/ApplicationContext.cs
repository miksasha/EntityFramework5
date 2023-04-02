
using System.Data.Entity;

namespace MykhailenkoEF5
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("ApplicationContext") { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Employee>()
            //    .HasMany(s => s.Enrollments)
            //    .WithRequired(e => e.Student)
            //    .HasForeignKey(e => e.StudentID);



        }
    }
}
