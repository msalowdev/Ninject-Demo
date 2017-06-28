using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Interface;

namespace FactoryService.Services
{
    public class ActionService : IActionService
    {
        private readonly IDataService _dataService;

        public ActionService(IDataService dataService)
        {
            if (dataService == null) throw new ArgumentNullException(nameof(dataService));
            _dataService = dataService;
        }

        public List<Guid> GetIds()
        {
            return _dataService.GetIds();
        }

        public void SaveItem(Guid id, string name)
        {
            _dataService.SaveItem(id, name);
        }
    }
}
