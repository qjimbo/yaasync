using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Yaasync.Controllers;
using Microsoft.Practices.Unity;


namespace Yaasync.Views
{
    public partial class MainPanel : Form
    {
        public MainPanelController _controller;
        public MainPanel()
        {
            InitializeComponent();
            _controller = UnityConfig.UnityContainer.Resolve<MainPanelController>();
            _controller._mainPanel = this;

            if (Globals.debugEnabled)
            {
                Globals.debugWindow = new DebugWindow();
                Globals.debugWindow.Show();
            }

            this.Closing += Shutdown;  
        }
        public void Shutdown(object sender, EventArgs e)
        {
            _controller.Shutdown();
        }

        // Frontend //
        private void MainPanel_Shown(object sender, EventArgs e)
        {
            _controller.SettingsLoad();
            _controller.GetVersion();
            _controller.CheckVersion();
            timerAutoUpdate.Enabled = true;

            _controller.GridLoad();
            _controller.ScreenshotsLoad();
        }

        private const int WM_HOTKEY = 0x312;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                _controller.TakeScreenshot();               
            }

            base.WndProc(ref m);
        }


        // Backend //

        private void timerProcess_Tick(object sender, EventArgs e)
        {
            _controller.RefreshProcess();
        }

        private void timerData_Tick(object sender, EventArgs e)
        {
            _controller.RefreshData();
        }

        private void lblQjimbo_Click(object sender, EventArgs e)
        {
            var sInfo = new System.Diagnostics.ProcessStartInfo("http://qjimbo.co/");
            System.Diagnostics.Process.Start(sInfo);
        }

        private void timerAutoUpdate_Tick(object sender, EventArgs e)
        {
            _controller.CheckVersion();
        }

        private void btnScreenPathSelect_Click(object sender, EventArgs e)
        {
            _controller.ScreenPathSelect();
        }

        private void btnScreenHotkeySelect_Click(object sender, EventArgs e)
        {
            _controller.ChangeHotkey();
        }

        private void btnSaveToText_Click(object sender, EventArgs e)
        {
            _controller.SaveToText();
        }

        private void btnAddNewSync_Click(object sender, EventArgs e)
        {
            _controller.GridAdd();
        }

        private void timerSync_Tick(object sender, EventArgs e)
        {
            _controller.SyncPosition();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
