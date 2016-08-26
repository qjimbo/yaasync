using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaasync.Services
{
    public interface IScreenshotService
    {
        void registerGlobalHotkey(IntPtr hwnd, string screenKeyModifier, string screenKeyKey);

        string takeScreenshot(string screenPath);

        void Shutdown();
    }
}

