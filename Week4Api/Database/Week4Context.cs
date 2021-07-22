using Microsoft.EntityFrameworkCore;

namespace Week4Api.Database
{
    public class Week4Context : DbContext
    {
        public Week4Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= (localdb)\MSSQLLocalDB; Database=Week4");
        }

        public DbSet<User> Users { get; set; }
    }
}