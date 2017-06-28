using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.DataService;

namespace BasicService
{
    public class BasicService
    {
        BasicDataService _dataService = new BasicDataService();

        public int HowMany()
        {
            return _dataService.GetIds().Count;
        }

        public List<Guid> GetAll()
        {
            return _dataService.GetIds();
        }

        public void SaveItem(Guid id, string name)
        {
            _dataService.SaveItem(id, name);
        }
    }
}
