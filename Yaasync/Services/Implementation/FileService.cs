using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Yaasync.Models;

namespace Yaasync.Services.Implementation
{
    class FileService : IFileService
    {
        public string settingsPath = Globals.appFolder + "\\settings.xml";
        public Settings readSettings()
        {
            return readClass<Settings>(settingsPath);
        }
        public void writeSettings(Settings settings)
        {
            writeClass<Settings>(settings, settingsPath);
        }

        public void writeStatus(string filename)
        {
            File.WriteAllText(filename, GameStatus.gameStatusString);
        }

        public void writeClass<T>(object obj, string filename)
        {
            FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stream, obj);
        }

        public T readClass<T>(string filename)
        {
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            T output = default(T);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                output = (T)serializer.Deserialize(stream);
            }
            catch(Exception e)
            {
                // error
                throw e;
            }
            return output;
        }

        public List<string> readImages(string screenPath)
        {
            var result = new List<string>();
            try
            {
                result = Directory.GetFiles(screenPath, "*.png").OrderBy(x => x).ToList();
            }
            catch
            {
            }
            return result;
        }
    }
}
