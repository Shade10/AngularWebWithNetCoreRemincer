using AngularWebWithNetCoreReminder.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularWebWithNetCoreReminder.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TestTable> TestTables { get; set; }

    }
}
