using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaasync.Models
{
    public class Settings
    {
        public string screenKeyKey = "N";
        public string screenKeyModifier = "CTRL+ALT";
        public string screenPath = Globals.appFolder + "\\Screenshots"; // Use location

        public List<SyncURL> syncURLs = new List<SyncURL>();
    }
}
