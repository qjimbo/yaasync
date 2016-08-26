using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Yaasync
{
    static class Globals
    {
        public static string appFolder { get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); } }

        public static bool debugEnabled = true;
        public static Views.DebugWindow debugWindow { get; set; }
        public static void debugMsg(string text)
        {
            if (!debugEnabled) return;
            debugWindow.txtDebug.Text += text + Environment.NewLine;
        }
    }
}
