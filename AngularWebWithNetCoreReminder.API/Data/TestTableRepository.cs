using AngularWebWithNetCoreReminder.API.Interfaces;
using AngularWebWithNetCoreReminder.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWebWithNetCoreReminder.API.Data
{
    public class TestTableRepository : ITestTableRepository
    {
        private readonly DataContext context;

        public TestTableRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<TestTable> GetTestTable(int id)
        {
            return await context.TestTables.Where(x => x.Id == id).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<TestTable>> GetTestTables()
        {
            return await context.TestTables.ToListAsync();
        }
    }
}
