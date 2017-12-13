using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Interface
{
    public class MockDataService : IDataService
    {
        public List<Guid> GetIds()
        {
            return new List<Guid>();
        }

        public void SaveItem(Guid id, string name)
        {
            Console.WriteLine("This is a mock");
        }
    }
}
