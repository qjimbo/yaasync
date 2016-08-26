using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Yaasync.Models
{
    static class YaasyncStatus
    {
        static public string GameEXE = "NMS";
        static public Process GameProcess { get; set; }
        static public string GamePath { get; set; }

        static public bool? GameRunning = null;
        static public bool? ScreenShotEngineRunning = null;
        static public string GameVersion { get; set; }
        static public string GameStatusText { get; set; }

        static public bool NMSDBStatus { get; set; }
        static public string NMSDBStatusText { get; set; }

        static public StatusEnum CurrentStatus { get; set; }
    }
    public enum StatusEnum
    {
        Offline,
        GameOnly,
        Online
    }
}
