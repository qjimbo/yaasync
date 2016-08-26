using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Yaasync.Models;

namespace Yaasync.Services.Implementation
{
    public class SyncService : ISyncService
    {
        private readonly IFileService _fileService;
        public SyncService(IFileService fileService)
        {
            _fileService = fileService;
        }

        private string appendDictionaryToUrl(string requestUrl, Dictionary<string, string> requestParams)
        {
            string initialQuerySeperator = "?";
            if (requestUrl.Contains("?")) initialQuerySeperator = "&";
            string requestParamsStr = string.Join("&", requestParams.Select((x) => x.Key + "=" + x.Value.ToString()));
            requestUrl += initialQuerySeperator + requestParamsStr;
            return requestUrl;
        }
        private string sendRequest(string requestUrl,string fileToUpload = null)
        {
            string result = string.Empty;
            using (WebClient client = new WebClient())
            {
                if (string.IsNullOrEmpty(fileToUpload))
                {
                    // Simple ping
                    result = client.DownloadString(requestUrl);

                }
                else
                {
                    // Post file
                    Uri uri = new Uri(requestUrl);
                    var raw = client.UploadFile(uri, "POST", fileToUpload);
                    result = System.Text.Encoding.UTF8.GetString(raw);
                }
            
            }
            return result;
        }

        public string availableactions(string url, string key)
        {
            var requestParams = new Dictionary<string,string>();
            requestParams.Add("action","availableactions");
            if (!string.IsNullOrWhiteSpace(key)) requestParams.Add("key", key);
            string requestUrl = appendDictionaryToUrl(url,requestParams);
            return sendRequest(requestUrl);
        }
        public List<string> syncposition(List<SyncURL> urls)
        {
            var result = new List<string>();
            foreach(var url in urls)
            {
                if(!url.syncPosition) continue;

                var requestParams = new Dictionary<string, string>();
                requestParams.Add("action", "syncposition");
                if (!string.IsNullOrWhiteSpace(url.key)) requestParams.Add("key", url.key);

                requestParams.Add("galaxy", GameStatus.galaxy);
                requestParams.Add("system", GameStatus.system);
                requestParams.Add("planet", GameStatus.planet);
                requestParams.Add("gX", GameStatus.gX.ToString());
                requestParams.Add("gY", GameStatus.gY.ToString());
                requestParams.Add("gZ", GameStatus.gZ.ToString());
                requestParams.Add("sX", GameStatus.sX.ToString());
                requestParams.Add("sY", GameStatus.sY.ToString());
                requestParams.Add("sZ", GameStatus.sZ.ToString());


                string requestUrl = appendDictionaryToUrl(url.URL, requestParams);
                result.Add(sendRequest(requestUrl));
            }
            return result;
        }
        public List<string> syncscreenshot(List<SyncURL> urls, string path)
        {
            var result = new List<string>();
            foreach(var url in urls)
            {
                if(!url.syncScreenshot) continue;

                var requestParams = new Dictionary<string, string>();
                requestParams.Add("action", "syncscreenshot");
                if (!string.IsNullOrWhiteSpace(url.key)) requestParams.Add("key", url.key);

                var position = _fileService.readClass<Position>(path + ".xml");

                string screenshotid = Path.GetFileNameWithoutExtension(path);

                requestParams.Add("screenshotid", screenshotid);

                requestParams.Add("galaxy", position.galaxy);
                requestParams.Add("system", position.system);
                requestParams.Add("planet", position.planet);
                requestParams.Add("gX", position.gX.ToString());
                requestParams.Add("gY", position.gY.ToString());
                requestParams.Add("gZ", position.gZ.ToString());
                requestParams.Add("sX", position.sX.ToString());
                requestParams.Add("sY", position.sY.ToString());
                requestParams.Add("sZ", position.sZ.ToString());

                string requestUrl = appendDictionaryToUrl(url.URL, requestParams);
                result.Add(sendRequest(requestUrl,path));
            }
            return result;
        }
    }
}
