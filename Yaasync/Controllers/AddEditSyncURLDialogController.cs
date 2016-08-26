using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Yaasync.Views;
using Yaasync.Models;
using Yaasync.Services;
using Yaasync.Services.Implementation;
using System.Windows.Forms;

namespace Yaasync.Controllers
{
    public class AddEditSyncURLDialogController
    {
        private readonly ISyncService _syncService;
        public AddEditSyncURLDialogController(ISyncService syncService)
        {
            _syncService = syncService;
        }

        public bool FetchServices(AddEditSyncURLDialog addEditSyncURLDialog)
        {
            // Validate URL
            var url = addEditSyncURLDialog.txtURL.Text;
            Uri uriResult;
            bool uriIsValid = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (!uriIsValid)
            {
                MessageBox.Show("URL is invalid", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // Try Fetch
            bool serviceFound = false;
            try
            {
                string actionsStr = _syncService.availableactions(url, addEditSyncURLDialog.txtKey.Text);
                string[] actionsArr = actionsStr.Split(',');

                if (actionsArr.Contains("syncposition")) { serviceFound = true; addEditSyncURLDialog.cbSyncPosition.Enabled = true; }
                if (actionsArr.Contains("syncscreenshot")) { serviceFound = true; addEditSyncURLDialog.cbSyncScreens.Enabled = true; }
                addEditSyncURLDialog.btnOK.Enabled = true;
            }
            catch
            {
                // Connection issue?
                MessageBox.Show("Unable to connect, verify that the URL is valid", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // Check if any services
            if(!serviceFound)
            {
                MessageBox.Show("No Services are available at this URL", "No Services", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
    }
}
