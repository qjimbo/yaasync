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

using System.Drawing;

namespace Yaasync.Controllers
{
    public class MainPanelController
    {
        private readonly IGameDataService _gameDataService;
        private readonly ISyncService _syncService;
        private readonly IFileService _fileService;
        private readonly IYaasyncStatusService _yaasyncStatusService;
        private readonly IYaasyncUpdateService _yaasyncUpdateService;
        private readonly IScreenshotService _screenshotService;
        private Settings _settings;
        public MainPanel _mainPanel;

        public MainPanelController(
            IGameDataService gameDataService,
            ISyncService syncService,
            IFileService fileService,
            IYaasyncStatusService yaasyncStatusService,
            IYaasyncUpdateService yaasyncUpdateService,
            IScreenshotService screenshotService
            )
        {
            _gameDataService = gameDataService;
            _syncService = syncService;
            _fileService = fileService;
            _yaasyncStatusService = yaasyncStatusService;
            _yaasyncUpdateService = yaasyncUpdateService;
            _screenshotService = screenshotService;

            _settings = fileService.readSettings();
        }
        
        // Core functions
        public void Shutdown()
        {
            _yaasyncStatusService.Shutdown();
        }

        // Sync Grid Setup
        public SourceGrid.Cells.Controllers.CustomEvents gridEditEvent = new SourceGrid.Cells.Controllers.CustomEvents();
        public SourceGrid.Cells.Controllers.CustomEvents gridDeleteEvent = new SourceGrid.Cells.Controllers.CustomEvents();
        public SourceGrid.Cells.Controllers.CustomEvents screenshotsClickEvent = new SourceGrid.Cells.Controllers.CustomEvents();

        public void GridLoad()
        {
            var urlGrid = _mainPanel.urlGrid;

            urlGrid.ColumnsCount = 6;
            urlGrid.FixedRows = 1;


            urlGrid.AutoStretchColumnsToFitWidth = true;
            urlGrid.Columns[0].MaximalWidth = 200;
            urlGrid.Columns[5].Visible = false;

			gridEditEvent.Click += new EventHandler(GridEdit);
			gridDeleteEvent.Click += new EventHandler(GridDelete);

            GridBindData(urlGrid);
            
            
        }

        public void GridBindData(SourceGrid.Grid urlGrid)
        {
            urlGrid.Rows.Clear();
            urlGrid.Rows.Insert(0);

            urlGrid[0, 0] = new SourceGrid.Cells.ColumnHeader("URL");
            urlGrid[0, 1] = new SourceGrid.Cells.ColumnHeader("Sync\nPosition");
            urlGrid[0, 2] = new SourceGrid.Cells.ColumnHeader("Sync\nScreenshots");

            int r = 1;
            foreach (SyncURL syncURL in _settings.syncURLs)
            {
                urlGrid.Rows.Insert(r);
                urlGrid[r, 0] = new SourceGrid.Cells.Cell(syncURL.URL, typeof(string));
                urlGrid[r, 0].Editor = null;
                urlGrid[r, 1] = new SourceGrid.Cells.CheckBox(null, syncURL.syncPosition);
                urlGrid[r, 1].Editor = null;
                urlGrid[r, 2] = new SourceGrid.Cells.CheckBox(null, syncURL.syncScreenshot);
                urlGrid[r, 2].Editor = null;
                urlGrid[r, 3] = new SourceGrid.Cells.Button("Edit");
                urlGrid[r, 3].Editor = null;
                urlGrid[r, 3].AddController(gridEditEvent);
                urlGrid[r, 4] = new SourceGrid.Cells.Button("Delete");
                urlGrid[r, 4].Editor = null;
                urlGrid[r, 4].AddController(gridDeleteEvent);

                urlGrid[r, 5] = new SourceGrid.Cells.Cell(syncURL.id, typeof(string));

                r++;
            }

            urlGrid.AutoSizeCells();
        }

        public void GridAdd()
        {
            var addEditSyncURLDialog = new AddEditSyncURLDialog(null);

            var result = addEditSyncURLDialog.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK) return;

            _settings.syncURLs.Add(addEditSyncURLDialog._syncURL);
            _fileService.writeSettings(_settings);

            GridBindData(_mainPanel.urlGrid);
        }

        public void GridEdit(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            int row = context.Position.Row;
            var urlGrid = (SourceGrid.Grid)context.Grid;
            string id = urlGrid[row, 5].Value.ToString();

            var item = _settings.syncURLs.FirstOrDefault(m => m.id == id);

            var addEditSyncURLDialog = new AddEditSyncURLDialog(item);

            var result = addEditSyncURLDialog.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK) return;

            _settings.syncURLs.Remove(item);
            _settings.syncURLs.Add(addEditSyncURLDialog._syncURL);
            _fileService.writeSettings(_settings);

            GridBindData(urlGrid);
        }

        public void GridDelete(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            int row = context.Position.Row;
            var urlGrid = (SourceGrid.Grid)context.Grid;
            string id = urlGrid[row, 5].Value.ToString();

            var result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != System.Windows.Forms.DialogResult.Yes) return;

            var item = _settings.syncURLs.FirstOrDefault(m => m.id == id);

            _settings.syncURLs.Remove(item);
            _fileService.writeSettings(_settings);

            GridBindData(urlGrid);
        }
        // File related       

        public void SaveToText()
        {
            var result = _mainPanel.saveFileDialog.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK) return;
            _fileService.writeStatus(_mainPanel.saveFileDialog.FileName);
        }


        // Settings related
        public void SettingsLoad()
        {
            _mainPanel.txtScreenKey.Text = _settings.screenKeyModifier + "+" + _settings.screenKeyKey;
            _mainPanel.txtScreenPath.Text = _settings.screenPath;

            _screenshotService.registerGlobalHotkey(_mainPanel.Handle, _settings.screenKeyModifier,_settings.screenKeyKey);
        }

        public void ScreenPathSelect()
        {
            _mainPanel.openFileDialog.InitialDirectory = _settings.screenPath;
            _mainPanel.openFileDialog.FileName = "Filename will be ignored";
            _mainPanel.openFileDialog.Filter = string.Empty;
            _mainPanel.openFileDialog.CheckFileExists = false;
            _mainPanel.openFileDialog.CheckPathExists = false;
            var result = _mainPanel.openFileDialog.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK) return;
            string path = Path.GetDirectoryName(_mainPanel.openFileDialog.FileName);
            _settings.screenPath = path;
            _mainPanel.txtScreenPath.Text = path;

            _fileService.writeSettings(_settings);
        }

        // Screenshot related
        public void ScreenshotsLoad()
        {
            screenshotsClickEvent.Click += ScreenshotsClick;

            var files = _fileService.readImages(_settings.screenPath);
            var screenshotGrid = _mainPanel.screenshotGrid;

            screenshotGrid.ColumnsCount = files.Count();
            screenshotGrid.FixedRows = 1;
            screenshotGrid.HScrollBar.Visible = true;
            screenshotGrid.AutoStretchRowsToFitHeight = true;

            screenshotGrid.Rows.Clear();
            screenshotGrid.Rows.Insert(0);

            int c = 0;

            foreach (var file in files)
            {
                ScreenshotsAdd(file, true);
            }

            screenshotGrid.AutoSizeCells();
            screenshotGrid.RecalcCustomScrollBars();
        }

        public void ScreenshotsAdd(string file, bool quick)
        {
            var screenshotGrid = _mainPanel.screenshotGrid;

            screenshotGrid.Columns.Insert(0);

            screenshotGrid[0, 0] = new SourceGrid.Cells.Cell();

            Image image = Functions.ScaleImage(Bitmap.FromFile(file), 400, 70);
            SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();

            screenshotGrid[0, 0].View = viewImage;
            screenshotGrid[0, 0].Image = image;
            screenshotGrid[0, 0].ToolTipText = file;
            screenshotGrid[0, 0].AddController(screenshotsClickEvent);

            if (!quick)
            {
                screenshotGrid.AutoSizeCells();
                screenshotGrid.RecalcCustomScrollBars();
            }
        }

        public void ScreenshotsClick(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            int column = context.Position.Column;
            var screenshotGrid = (SourceGrid.Grid)context.Grid;
            string file = screenshotGrid[0, column].ToolTipText;

            var sInfo = new System.Diagnostics.ProcessStartInfo(file);
            System.Diagnostics.Process.Start(sInfo);
        }

        public void TakeScreenshot()
        {
            string file = _screenshotService.takeScreenshot(_settings.screenPath);
            if (file == string.Empty) return; // Game not running
            ScreenshotsAdd(file, false);
            Application.DoEvents();
            _syncService.syncscreenshot(_settings.syncURLs, file);
        }

        public void ChangeHotkey()
        {
            var screenKeySelectDialog = new ScreenKeySelectDialog(this);

            screenKeySelectDialog.cbKey.SelectedIndex = screenKeySelectDialog.cbKey.FindStringExact(_settings.screenKeyKey);
            screenKeySelectDialog.cbModifier.SelectedIndex = screenKeySelectDialog.cbModifier.FindStringExact(_settings.screenKeyModifier);

            var result = screenKeySelectDialog.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK) return;

            _settings.screenKeyKey = screenKeySelectDialog.cbKey.Text;
            _settings.screenKeyModifier = screenKeySelectDialog.cbModifier.Text;
            _mainPanel.txtScreenKey.Text = _settings.screenKeyModifier + "+" + _settings.screenKeyKey;

            _fileService.writeSettings(_settings);
        }

        // Position related
        public void SyncPosition()
        {
            if (YaasyncStatus.GameRunning != true) return;
            _syncService.syncposition(_settings.syncURLs);
        }

        // Process related
        public void RefreshProcess()
        {
            // Check if game is running //
            bool gameRunning = _yaasyncStatusService.IsGameRunning();
            if (gameRunning != YaasyncStatus.GameRunning)
            {
                if (gameRunning)
                {
                    YaasyncStatus.GameRunning = true;
                    _yaasyncStatusService.LoadFromProcess();
                    _mainPanel.txtGameStatusText.Text = YaasyncStatus.GameStatusText;
                    _mainPanel.pbStatusIcon.Image = Yaasync.Properties.Resources.icon_online;
                }
                else
                {
                    YaasyncStatus.GameRunning = false;
                    _mainPanel.txtGameStatusText.Text = "Not Running";
                    _mainPanel.pbStatusIcon.Image = Yaasync.Properties.Resources.icon_offline;
                }
            }
        }

        public void RefreshData()
        {
            if (YaasyncStatus.GameRunning == true)
            {
                _gameDataService.LoadFromProcess();
            }

            _mainPanel.gameStatusSystem.Text = GameStatus.system;
            _mainPanel.gameStatusPlanet.Text = GameStatus.planet;
            _mainPanel.gameStatusGalaxy.Text = GameStatus.galaxy;

            _mainPanel.gameStatusGalaxyXYZ.Text = GameStatus.gameStatusGalaxyXYZ;
            _mainPanel.gameStatusSurfaceXYZ.Text = GameStatus.gameStatusSurfaceXYZ;
        }

        public void GetVersion()
        {
            var version = _yaasyncUpdateService.thisVersion();
            _mainPanel.Text = "Yaasync " + version.ToString() + " - Sync No Man's Sky";
        }

        public void SaveDataToText()
        {

        }
    

        // Sync Grid Setup

        // Updating
        public void CheckVersion()
        {
            var thisversion = _yaasyncUpdateService.thisVersion();
            var onlineversion = _yaasyncUpdateService.onlineVersion();

            if(onlineversion != null)
            {
                if(onlineversion > thisversion)
                {
                    // Update
                    _mainPanel.txtVersion.Text = "Updating";
                    _yaasyncUpdateService.update(UpdateCallback);
                }
                else
                {
                    _mainPanel.txtVersion.Text = "Latest - " + thisversion;
                }
            }
        }

        public void UpdateCallback(int progress, string status, bool complete)
        {
            _mainPanel.pbVersion.Value = progress;
            _mainPanel.txtVersion.Text = status;
            if(complete)
            {
                _mainPanel.txtVersion.Text = "Installing";
                _yaasyncUpdateService.install();
            }
        }
    }
}
