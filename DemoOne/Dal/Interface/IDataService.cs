using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Interface
{
    public interface IDataService
    {
        List<Guid> GetIds();

        void SaveItem(Guid id, string name);
    }
}
