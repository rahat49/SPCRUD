using EFCoreCRUDusingStoreProcedure.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCRUDusingStoreProcedure.Data
{
    public class StudentDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = string.Format(@"Data Source=RAHAT_ERP\SQLEXPRESS; Initial Catalog=SchoolDB;Integrated Security=True");
            optionsBuilder.UseSqlServer(connectionString);
            //base.OnConfiguring(optionsBuilder);

        }

        public DbSet<Student>Students { get; set; }
    }
}
