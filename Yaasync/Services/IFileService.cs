using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaasync.Models;

namespace Yaasync.Services
{
    public interface IFileService
    {
        Settings readSettings();
        void writeSettings(Settings settings);
        void writeStatus(string filename);

        void writeClass<T>(object obj, string filename);
        T readClass<T>(string filename);

        List<string> readImages(string screenPath);
    }
}

