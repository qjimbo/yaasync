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
using Yaasync.Models;
using Microsoft.Practices.Unity;

namespace Yaasync.Views
{
    public partial class AddEditSyncURLDialog : Form
    {
        public AddEditSyncURLDialogController _controller;
        public SyncURL _syncURL;
        public AddEditSyncURLDialog(SyncURL syncURL)
        {
            InitializeComponent();
            _controller = UnityConfig.UnityContainer.Resolve<AddEditSyncURLDialogController>();
            _syncURL = syncURL;
        }

        private void AddEditSyncURLDialog_Shown(object sender, EventArgs e)
        {
            if(_syncURL != null)
            {
                txtURL.Text = _syncURL.URL;
                txtKey.Text = _syncURL.key;
            }
            else
            {
                _syncURL = new SyncURL();
                _syncURL.id = Guid.NewGuid().ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _syncURL.URL = txtURL.Text;
            _syncURL.key = txtKey.Text;
            _syncURL.syncPosition = cbSyncPosition.Checked;
            _syncURL.syncScreenshot = cbSyncScreens.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if(_controller.FetchServices(this))
            {
                btnFetch.BackColor = SystemColors.Control;
                txtURL.Enabled = false;
                txtKey.Enabled = false;
                btnFetch.Enabled = false;
            }
        }
    }
}
