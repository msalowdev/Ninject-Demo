using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DataService
{
    public class BasicDataService
    {
        public List<Guid> GetIds()
        {

            var list = new List<Guid>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(Guid.NewGuid());
            }
            return list;
        }

        public void SaveItem(Guid id, string name)
        {
            Console.WriteLine($"Saved Id:[{id}] Name:[{name}] ");
        }


    }
}
