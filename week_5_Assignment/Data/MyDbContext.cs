using Microsoft.EntityFrameworkCore;
using week_5_Assignment.Models.Entities;

namespace week_5_Assignment.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext>options): base(options)
        {

        }

        public DbSet<Job> Jobs { get; set; }
    }
}
