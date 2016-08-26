using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaasync.Views
{
    public partial class ScreenKeySelectDialog : Form
    {
        public ScreenKeySelectDialog()
        {
            InitializeComponent();
        }

        private void ScreenKeySelectDialog_Load(object sender, EventArgs e)
        {
            List<string> Keys = Enum.GetNames(typeof(Keys)).ToList();
            cbKey.DataSource = Keys;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult =
        }
    }
}
