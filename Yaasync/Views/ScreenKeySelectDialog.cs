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

namespace Yaasync.Views
{
    public partial class ScreenKeySelectDialog : Form
    {
        public MainPanelController _controller;
        public ScreenKeySelectDialog(MainPanelController controller)
        {
            _controller = controller;
            InitializeComponent();

            List<string> Keys = Enum.GetNames(typeof(Keys)).ToList();
            cbKey.DataSource = Keys;
        }

        private void ScreenKeySelectDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
