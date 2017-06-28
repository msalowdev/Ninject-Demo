using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Interface;

namespace NinjectWithDI
{
    public class NinjectWithDISevice
    {
        private readonly IDataService _dataService;

        public NinjectWithDISevice(IDataService dataService)
        {
            if (dataService == null) throw new ArgumentNullException(nameof(dataService));
            _dataService = dataService;
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
