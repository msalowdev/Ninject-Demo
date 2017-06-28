using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryService.Factory;
using FactoryService.Services;

namespace Ninject.Extensions.Service.Factory
{
    public class NinjectServiceFactory: IServiceFactory
    {
        private readonly IKernel _kernel;

        public NinjectServiceFactory(IKernel kernel)
        {
            if (kernel == null) throw new ArgumentNullException(nameof(kernel));
            _kernel = kernel;
        }

        public T Create<T>() where T : IService
        {
            return _kernel.Get<T>();
        }
    }
}
