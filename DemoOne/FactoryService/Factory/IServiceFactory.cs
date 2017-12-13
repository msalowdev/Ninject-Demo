using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryService.Services;

namespace FactoryService.Factory
{
    public interface IServiceFactory
    {
        T Create<T>() where T : IService;

    }
}
