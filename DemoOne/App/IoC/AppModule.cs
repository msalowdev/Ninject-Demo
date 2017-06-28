using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Interface;
using Ninject.Modules;

namespace App.IoC
{
    public class AppModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IDataService>().To<InterfaceDataService>();
        }
    }
}
