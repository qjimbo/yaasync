using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

using Yaasync.Models;

namespace Yaasync.Services.Implementation
{
    public class YaasyncStatusService : IYaasyncStatusService
    {
        private readonly IFileService _fileService;
        private readonly IScreenshotService _screenshotService;
        public YaasyncStatusService(IFileService fileService, IScreenshotService screenshotService)
        {
            _fileService = fileService;
            _screenshotService = screenshotService;
        }

        public bool IsGameRunning()
        {
            Process[] GameProcesses = Process.GetProcessesByName(YaasyncStatus.GameEXE);
            if (GameProcesses.Length > 0)
            {               
                YaasyncStatus.GameProcess = GameProcesses[0];
                return true;
            }
            return false;
        }

        public bool LoadFromProcess()
        {
            YaasyncStatus.GamePath = YaasyncStatus.GameProcess.MainModule.FileName;
            FileVersionInfo GameFileVersionInfo = FileVersionInfo.GetVersionInfo(YaasyncStatus.GamePath);
            YaasyncStatus.GameVersion = GameFileVersionInfo.FileVersion.Trim();
            YaasyncStatus.GameStatusText = "Running v" + YaasyncStatus.GameVersion;
            return false;
        }

        public void Shutdown()
        {
            _screenshotService.Shutdown();
        }
    }
}
