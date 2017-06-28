using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryService.Factory;
using FactoryService.Services;
using Ninject.Extensions.Service.Factory;
using Ninject.Modules;

namespace Ninject.Extensions.Service
{
    public class Module : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IActionService>().To<ActionService>();
            Kernel.Bind<ICounterService>().To<CounterService>();

            Kernel.Bind<IServiceFactory>().To<NinjectServiceFactory>();
        }
    }
}
