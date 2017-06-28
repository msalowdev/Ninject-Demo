using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.DataService;
using Ninject;

namespace BasicNinjectUse
{
    public class BasicNinjectService
    {
        private readonly IKernel _kernel;
        private BasicDataService _dataService;

        public BasicDataService DataService {
            get
            {
                if (_dataService == null)
                    _dataService = _kernel.Get<BasicDataService>();
                return _dataService;
            }
        }

        public BasicNinjectService(IKernel kernel)
        {
            if (kernel == null) throw new ArgumentNullException(nameof(kernel));
            _kernel = kernel;
        }


        public int HowMany()
        {
            return DataService.GetIds().Count;
        }

        public List<Guid> GetAll()
        {
            return DataService.GetIds();
        }

        public void SaveItem(Guid id, string name)
        {
            DataService.SaveItem(id, name);
        }
    }
}
