using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryService.Services
{
    public interface ICounterService : IService
    {
        int HowMany();
    }
}
