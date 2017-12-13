using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dal.DataService;

namespace BasicService
{
    public class BasicService
    {
        private readonly DBConfig _config;
        BasicDataService _dataService;// = new BasicDataService();

        public BasicService(DBConfig config)
        {
            if (config == null) throw new ArgumentNullException(nameof(config));
            _config = config;
            _dataService = new BasicDataService(config);
        }

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
