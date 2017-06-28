using Dal.Interface;
using Ninject.Modules;

namespace Ninject.Extensions.Dal
{
    public class Module: NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IDataService>().To<InterfaceDataService>();
        }
    }
}
