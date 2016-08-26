using System;
using System.Drawing; // add reference to the System.Drawing.dll
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using Yaasync.Models;
using System.Collections.Generic;
using System.Linq;

namespace Yaasync.Services
{
    public class ScreenshotService : IScreenshotService
    {
        private readonly IFileService _fileService;
        public ScreenshotService(IFileService fileService)
        {
            _fileService = fileService;
        }

        const int HOTKEY_ID = 19862012; // hotkey instance
        public enum KeyModifiers
        {
            None = 0,
            ALT = 1,
            CTRL = 2,
            SHIFT = 4,
            WIN = 8
        }
        public void registerGlobalHotkey(IntPtr hwnd, string screenKeyModifier, string screenKeyKey)
        {
            UnregisterHotKey(hwnd, HOTKEY_ID);
            var screenKeyModifiers = screenKeyModifier.Split('+');
            KeyModifiers keyModifier = KeyModifiers.None;
            if (screenKeyModifiers.Length == 0) keyModifier = KeyModifiers.None; // Blank
            if (screenKeyModifiers.Length == 1) keyModifier = (KeyModifiers)Enum.Parse(typeof(KeyModifiers), screenKeyModifier); // Single
            if (screenKeyModifiers.Length == 2) keyModifier = (KeyModifiers)Enum.Parse(typeof(KeyModifiers), screenKeyModifiers[0]) | (KeyModifiers)Enum.Parse(typeof(KeyModifiers), screenKeyModifiers[1]); // Double e.g. CTRL+ALT
            
            RegisterHotKey(hwnd, HOTKEY_ID, keyModifier, (Keys)Enum.Parse(typeof(Keys),screenKeyKey) );
        }

        public string takeScreenshot(string screenPath)
        {
            if (YaasyncStatus.GameRunning != true) return string.Empty;
            if (YaasyncStatus.ScreenShotEngineRunning != true) { InstallTheHook(); YaasyncStatus.ScreenShotEngineRunning = true; }

            Guid id = Guid.NewGuid();
            string screenshotRawPath = Path.Combine(screenPath, "raw\\");
            string screenshotFile = Path.Combine(screenPath, Functions.DateTimeToUnixTimestamp(DateTime.Now) + "-" + id + ".png");

            // Run capture
            var bmp = getScreenBitmap(screenshotRawPath);
            if (bmp == null) return string.Empty;

            // saving the screenshot to a bitmap
            Graphics g = Graphics.FromImage(bmp);

            RectangleF rectcentre = new RectangleF(10, 10, bmp.Width, 200);

            RectangleF rectbtmleft = new RectangleF(9, 11, bmp.Width, 200);
            RectangleF rectbtmright = new RectangleF(11, 11, bmp.Width, 200);
            RectangleF recttopleft = new RectangleF(9, 9, bmp.Width, 200);
            RectangleF recttopright = new RectangleF(11, 9, bmp.Width, 200);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            string output = "Yaasync Screenshot taken " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine + GameStatus.gameStatusString;
            output = output.ToUpper();
            var bitDustFont = loadBitmapFont();
            g.DrawString(output, new Font(bitDustFont, 12), Brushes.Black, rectbtmleft);
            g.DrawString(output, new Font(bitDustFont, 12), Brushes.Black, rectbtmright);
            g.DrawString(output, new Font(bitDustFont, 12), Brushes.Black, recttopleft);
            g.DrawString(output, new Font(bitDustFont, 12), Brushes.Black, recttopright);

            g.DrawString(output, new Font(bitDustFont, 12), Brushes.Yellow, rectcentre);

            g.Flush();

            // and now you can use it as you like
            // let's just save it to the desktop folder as a png file

            (new FileInfo(screenshotFile)).Directory.Create();
            bmp.Save(screenshotFile, ImageFormat.Png);

            var position = new Position();
            _fileService.writeClass<Position>(position, screenshotFile + ".xml");

            return screenshotFile;
        }

        private bool getScreenBitmapBusy = false;
        private Bitmap getScreenBitmap(string tempPath)
        {
            while (getScreenBitmapBusy) Thread.Sleep(500);
            getScreenBitmapBusy = true;
            (new FileInfo(tempPath)).Directory.Create();
            SetCaptureDir(tempPath);

            List<string> beforeFiles = Directory.GetFiles(tempPath, "*.bmp").ToList();
            // Call taksi.dll function
            TakeScreenShot(0);
            // End function

            List<string> newFiles = new List<string>();
            int waited = 0;
            do
            {
                Thread.Sleep(100);
                waited += 100;
                List<string> afterFiles = Directory.GetFiles(tempPath, "*.bmp").ToList();
                newFiles = afterFiles.Except(beforeFiles).ToList();                
            }
            while (newFiles.Count == 0 && waited < 2000);

            getScreenBitmapBusy = false; 
            if (newFiles.Count == 0) return null;
            string file = newFiles[0];

            // Open bitmap
            return new Bitmap(Image.FromFile(file));
        }

        public void Shutdown()
        {
            if (YaasyncStatus.ScreenShotEngineRunning == true) UninstallTheHook();
        }

        // Font
        private FontFamily loadBitmapFont()
        {
            PrivateFontCollection collection = new PrivateFontCollection();
            collection.AddFontFile(Globals.appFolder + "\\bitdust2.ttf");
            FontFamily fontFamily = new FontFamily("BitDust Two", collection);
            return fontFamily;
        }

        // Screenshot
        [DllImport("taksi.dll", SetLastError = true)]
        public static extern bool InstallTheHook();

        [DllImport("taksi.dll", SetLastError = true)]
        public static extern bool UninstallTheHook();

        [DllImport("taksi.dll", SetLastError = true)]
        public static extern bool UninstallKeyboardHook();

        [DllImport("taksi.dll", SetLastError = true, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Auto)]
        public static extern bool SetCaptureDir([MarshalAs(UnmanagedType.LPStr)]string path);

        [DllImport("taksi.dll", SetLastError = true, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Auto)]
        public static extern bool TakeScreenShot(uint processId);

        // Hotkey
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        
    }
}

