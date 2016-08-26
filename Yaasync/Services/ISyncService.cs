using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaasync.Models;

namespace Yaasync.Services
{
    public interface ISyncService
    {
        string availableactions(string url, string key);
        List<string> syncposition(List<SyncURL> urls);
        List<string> syncscreenshot(List<SyncURL> urls, string path);
    }
}

