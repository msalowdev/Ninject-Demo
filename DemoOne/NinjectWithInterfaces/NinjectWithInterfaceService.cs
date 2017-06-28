using System;
using System.Collections.Generic;
using Dal.DataService;
using Dal.Interface;
using Ninject;

namespace NinjectWithInterfaces
{
    public class NinjectWithInterfaceService
    {
            private readonly IKernel _kernel;
        private IDataService _dataService;

        public IDataService DataService
        {
            get
            {
                if (_dataService == null)
                    _dataService = _kernel.Get<IDataService>();
                return _dataService;
            }
        }

        public NinjectWithInterfaceService(IKernel kernel)
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