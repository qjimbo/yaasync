using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

using Yaasync.Models;

namespace Yaasync.Services
{
    public interface IYaasyncStatusService
    {
        bool IsGameRunning();

        bool LoadFromProcess();

        void Shutdown();
    }
}
