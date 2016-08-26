using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Runtime.InteropServices; // DllImport
using Yaasync.Models;

namespace Yaasync.Services
{
    public interface IGameDataService
    {
        void LoadFromProcess();
    }
}
