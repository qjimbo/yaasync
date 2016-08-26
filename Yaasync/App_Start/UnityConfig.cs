using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

using Yaasync.Services;
using Yaasync.Services.Implementation;

namespace Yaasync
{

    public class UnityConfig
    {
        public static UnityContainer UnityContainer = new UnityContainer();
        public class Dependency
        {
            public Type From { get; set; }
            public Type To { get; set; }
        }

        public static void RegisterTypes()
        {
            UnityContainer.RegisterType<IGameDataService,GameDataService>();
            UnityContainer.RegisterType<IFileService, FileService>();
            UnityContainer.RegisterType<ISyncService, SyncService>();
            UnityContainer.RegisterType<IYaasyncStatusService, YaasyncStatusService>();
            UnityContainer.RegisterType<IYaasyncUpdateService, YaasyncUpdateService>();
            UnityContainer.RegisterType<IScreenshotService, ScreenshotService>();
        }
    }
}
