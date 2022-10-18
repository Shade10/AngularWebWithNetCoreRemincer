using AngularWebWithNetCoreReminder.API.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularWebWithNetCoreReminder.API.Interfaces
{
    public interface ITestTableRepository
    {
        public Task<IEnumerable<TestTable>> GetTestTables();
        public Task<TestTable> GetTestTable(int id);
    }
}
