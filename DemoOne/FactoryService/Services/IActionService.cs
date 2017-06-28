using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryService.Services
{
    public interface IActionService: IService
    {
        List<Guid> GetIds();
        void SaveItem(Guid id, string name);
    }
}
