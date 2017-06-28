using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Interface;

namespace FactoryService.Services
{
    public class CounterService : ICounterService
    {
        private readonly IDataService _dataService;
        public CounterService(IDataService dataService)
        {
            if (dataService == null) throw new ArgumentNullException(nameof(dataService));
            _dataService = dataService;
        }

        public int HowMany()
        {
            return _dataService.GetIds().Count;
        }
    }
}
