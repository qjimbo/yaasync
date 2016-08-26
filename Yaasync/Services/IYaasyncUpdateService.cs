using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaasync.Services
{
    public interface IYaasyncUpdateService
    {
        Version thisVersion();
        Version onlineVersion();
        void update(Action<int, string, bool> callback);
        void install();
    }
}
