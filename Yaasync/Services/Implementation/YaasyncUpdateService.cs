using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Reflection;

namespace Yaasync.Services.Implementation
{
    class YaasyncUpdateService : IYaasyncUpdateService
    {
        public string versionUrl = "http://qjimbo.co/yaasync/version.php";
        public string setupUrl = "http://qjimbo.co/yaasync/yaasync_setup.exe";
        public string downloadPath { get { return Globals.appFolder + "\\Download\\" + Path.GetFileName(setupUrl); } }

        public Version thisVersion()
        {
            return new Version(File.ReadAllText(Globals.appFolder + "\\version.txt"));
        }

        public Version onlineVersion()
        {
            Version v = null;
            using (WebClient client = new WebClient())
            {
                try {
                    v = new Version(client.DownloadString(versionUrl));
                } catch {
                    // Connection error
                }
            }
            return v;
        }

        public Action<int, string, bool> updateCallback;
        public void update(Action<int, string, bool> _callback)
        {
            updateCallback = _callback;

            using (WebClient client = new WebClient())
            {
                (new FileInfo(downloadPath)).Directory.Create();

                client.DownloadFileCompleted += new AsyncCompletedEventHandler(web_DownloadFileCompleted);
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(web_DownloadProgressChanged);
                client.DownloadFileAsync(new Uri(setupUrl), downloadPath);
            }
        }
        private void web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            string updateCallbackProgressString = string.Format("Updating ({2}%)",
            e.BytesReceived / 1024,
            e.TotalBytesToReceive / 1024,
            e.ProgressPercentage.ToString());
            int updateCallbackProgressPercentage = e.ProgressPercentage;

            updateCallback(updateCallbackProgressPercentage,updateCallbackProgressString, false);
        }
        private void web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            updateCallback(100, "Complete", true);
        }

        public void install()
        {
            // TODO: Load window status on startup, so if installed minimized stay minimized (no popups distracting from game)
            Process.Start(downloadPath, "/SP- /verysilent /noicons \"/dir=expand:" + Globals.appFolder + "\"");
            System.Windows.Forms.Application.Exit();
            Thread.Sleep(1000);
        }
    }
}
