namespace Yaasync.Views
{
    partial class MainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGameStatusText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNMSDBStatusText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbVersion = new System.Windows.Forms.ProgressBar();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gameStatusGalaxy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gameStatusSurfaceXYZ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveToText = new System.Windows.Forms.Button();
            this.gameStatusGalaxyXYZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gameStatusSystem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gameStatusPlanet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddNewSync = new System.Windows.Forms.Button();
            this.urlGrid = new SourceGrid.Grid();
            this.label8 = new System.Windows.Forms.Label();
            this.btnScreenPathSelect = new System.Windows.Forms.Button();
            this.btnScreenHotkeySelect = new System.Windows.Forms.Button();
            this.txtScreenPath = new System.Windows.Forms.TextBox();
            this.txtScreenKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.screenshotGrid = new SourceGrid.Grid();
            this.timerProcess = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.lblQjimbo = new System.Windows.Forms.Label();
            this.timerAutoUpdate = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timerSync = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pbStatusIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbStatusIcon);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 48);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGameStatusText);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNMSDBStatusText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yaasync Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "No Man\'s Sky:";
            // 
            // txtGameStatusText
            // 
            this.txtGameStatusText.Location = new System.Drawing.Point(156, 21);
            this.txtGameStatusText.Name = "txtGameStatusText";
            this.txtGameStatusText.ReadOnly = true;
            this.txtGameStatusText.Size = new System.Drawing.Size(100, 20);
            this.txtGameStatusText.TabIndex = 2;
            this.txtGameStatusText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sync Status:";
            // 
            // txtNMSDBStatusText
            // 
            this.txtNMSDBStatusText.Location = new System.Drawing.Point(156, 43);
            this.txtNMSDBStatusText.Name = "txtNMSDBStatusText";
            this.txtNMSDBStatusText.ReadOnly = true;
            this.txtNMSDBStatusText.Size = new System.Drawing.Size(100, 20);
            this.txtNMSDBStatusText.TabIndex = 3;
            this.txtNMSDBStatusText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbVersion);
            this.groupBox2.Controls.Add(this.txtVersion);
            this.groupBox2.Location = new System.Drawing.Point(283, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yaasync Version";
            // 
            // pbVersion
            // 
            this.pbVersion.Location = new System.Drawing.Point(6, 43);
            this.pbVersion.Name = "pbVersion";
            this.pbVersion.Size = new System.Drawing.Size(130, 20);
            this.pbVersion.TabIndex = 5;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(6, 19);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(130, 20);
            this.txtVersion.TabIndex = 4;
            this.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gameStatusGalaxy);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.gameStatusSurfaceXYZ);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnSaveToText);
            this.groupBox3.Controls.Add(this.gameStatusGalaxyXYZ);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.gameStatusSystem);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.gameStatusPlanet);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 185);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Status";
            // 
            // gameStatusGalaxy
            // 
            this.gameStatusGalaxy.Location = new System.Drawing.Point(120, 67);
            this.gameStatusGalaxy.Name = "gameStatusGalaxy";
            this.gameStatusGalaxy.ReadOnly = true;
            this.gameStatusGalaxy.Size = new System.Drawing.Size(287, 20);
            this.gameStatusGalaxy.TabIndex = 12;
            this.gameStatusGalaxy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Current Galaxy:";
            // 
            // gameStatusSurfaceXYZ
            // 
            this.gameStatusSurfaceXYZ.Location = new System.Drawing.Point(120, 114);
            this.gameStatusSurfaceXYZ.Multiline = true;
            this.gameStatusSurfaceXYZ.Name = "gameStatusSurfaceXYZ";
            this.gameStatusSurfaceXYZ.ReadOnly = true;
            this.gameStatusSurfaceXYZ.Size = new System.Drawing.Size(287, 20);
            this.gameStatusSurfaceXYZ.TabIndex = 10;
            this.gameStatusSurfaceXYZ.Text = "X: ..., Y: ...., Z: ...";
            this.gameStatusSurfaceXYZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Surface Coordinates:";
            // 
            // btnSaveToText
            // 
            this.btnSaveToText.Location = new System.Drawing.Point(298, 140);
            this.btnSaveToText.Name = "btnSaveToText";
            this.btnSaveToText.Size = new System.Drawing.Size(109, 24);
            this.btnSaveToText.TabIndex = 8;
            this.btnSaveToText.Text = "Save to text file";
            this.btnSaveToText.UseVisualStyleBackColor = true;
            this.btnSaveToText.Click += new System.EventHandler(this.btnSaveToText_Click);
            // 
            // gameStatusGalaxyXYZ
            // 
            this.gameStatusGalaxyXYZ.Location = new System.Drawing.Point(120, 91);
            this.gameStatusGalaxyXYZ.Multiline = true;
            this.gameStatusGalaxyXYZ.Name = "gameStatusGalaxyXYZ";
            this.gameStatusGalaxyXYZ.ReadOnly = true;
            this.gameStatusGalaxyXYZ.Size = new System.Drawing.Size(287, 20);
            this.gameStatusGalaxyXYZ.TabIndex = 6;
            this.gameStatusGalaxyXYZ.Text = "X: ..., Y: ...., Z: ...";
            this.gameStatusGalaxyXYZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Galactic Coordinates:";
            // 
            // gameStatusSystem
            // 
            this.gameStatusSystem.Location = new System.Drawing.Point(120, 21);
            this.gameStatusSystem.Name = "gameStatusSystem";
            this.gameStatusSystem.ReadOnly = true;
            this.gameStatusSystem.Size = new System.Drawing.Size(287, 20);
            this.gameStatusSystem.TabIndex = 4;
            this.gameStatusSystem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current System:";
            // 
            // gameStatusPlanet
            // 
            this.gameStatusPlanet.Location = new System.Drawing.Point(120, 44);
            this.gameStatusPlanet.Name = "gameStatusPlanet";
            this.gameStatusPlanet.ReadOnly = true;
            this.gameStatusPlanet.Size = new System.Drawing.Size(287, 20);
            this.gameStatusPlanet.TabIndex = 2;
            this.gameStatusPlanet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current Planet:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddNewSync);
            this.groupBox4.Controls.Add(this.urlGrid);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(414, 138);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sync";
            // 
            // btnAddNewSync
            // 
            this.btnAddNewSync.Location = new System.Drawing.Point(277, 107);
            this.btnAddNewSync.Name = "btnAddNewSync";
            this.btnAddNewSync.Size = new System.Drawing.Size(130, 23);
            this.btnAddNewSync.TabIndex = 13;
            this.btnAddNewSync.Text = "Add new Sync URL";
            this.btnAddNewSync.UseVisualStyleBackColor = true;
            this.btnAddNewSync.Click += new System.EventHandler(this.btnAddNewSync_Click);
            // 
            // urlGrid
            // 
            this.urlGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.urlGrid.EnableSort = true;
            this.urlGrid.Location = new System.Drawing.Point(6, 32);
            this.urlGrid.Name = "urlGrid";
            this.urlGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.urlGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.urlGrid.Size = new System.Drawing.Size(401, 69);
            this.urlGrid.TabIndex = 12;
            this.urlGrid.TabStop = true;
            this.urlGrid.ToolTipText = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "URLs to send Sync data to:";
            // 
            // btnScreenPathSelect
            // 
            this.btnScreenPathSelect.Location = new System.Drawing.Point(335, 133);
            this.btnScreenPathSelect.Name = "btnScreenPathSelect";
            this.btnScreenPathSelect.Size = new System.Drawing.Size(66, 20);
            this.btnScreenPathSelect.TabIndex = 10;
            this.btnScreenPathSelect.Text = "Browse...";
            this.btnScreenPathSelect.UseVisualStyleBackColor = true;
            this.btnScreenPathSelect.Click += new System.EventHandler(this.btnScreenPathSelect_Click);
            // 
            // btnScreenHotkeySelect
            // 
            this.btnScreenHotkeySelect.Location = new System.Drawing.Point(118, 132);
            this.btnScreenHotkeySelect.Name = "btnScreenHotkeySelect";
            this.btnScreenHotkeySelect.Size = new System.Drawing.Size(48, 20);
            this.btnScreenHotkeySelect.TabIndex = 9;
            this.btnScreenHotkeySelect.Text = "Select";
            this.btnScreenHotkeySelect.UseVisualStyleBackColor = true;
            this.btnScreenHotkeySelect.Click += new System.EventHandler(this.btnScreenHotkeySelect_Click);
            // 
            // txtScreenPath
            // 
            this.txtScreenPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtScreenPath.Location = new System.Drawing.Point(174, 133);
            this.txtScreenPath.Name = "txtScreenPath";
            this.txtScreenPath.ReadOnly = true;
            this.txtScreenPath.Size = new System.Drawing.Size(155, 20);
            this.txtScreenPath.TabIndex = 7;
            this.txtScreenPath.Text = "C:\\Yaasync\\Screenshots";
            this.txtScreenPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScreenKey
            // 
            this.txtScreenKey.BackColor = System.Drawing.SystemColors.Control;
            this.txtScreenKey.Location = new System.Drawing.Point(10, 132);
            this.txtScreenKey.Name = "txtScreenKey";
            this.txtScreenKey.ReadOnly = true;
            this.txtScreenKey.Size = new System.Drawing.Size(102, 20);
            this.txtScreenKey.TabIndex = 6;
            this.txtScreenKey.Text = "CTRL+S";
            this.txtScreenKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Screenshot Location:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Screenshot Hotkey:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.screenshotGrid);
            this.groupBox6.Controls.Add(this.btnScreenPathSelect);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.btnScreenHotkeySelect);
            this.groupBox6.Controls.Add(this.txtScreenPath);
            this.groupBox6.Controls.Add(this.txtScreenKey);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(11, 426);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(415, 161);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Screenshots";
            // 
            // screenshotGrid
            // 
            this.screenshotGrid.BackColor = System.Drawing.Color.White;
            this.screenshotGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenshotGrid.EnableSort = true;
            this.screenshotGrid.Location = new System.Drawing.Point(7, 18);
            this.screenshotGrid.Name = "screenshotGrid";
            this.screenshotGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.screenshotGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.screenshotGrid.Size = new System.Drawing.Size(401, 94);
            this.screenshotGrid.TabIndex = 13;
            this.screenshotGrid.TabStop = true;
            this.screenshotGrid.ToolTipText = "";
            // 
            // timerProcess
            // 
            this.timerProcess.Enabled = true;
            this.timerProcess.Interval = 1000;
            this.timerProcess.Tick += new System.EventHandler(this.timerProcess_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 596);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Coded by";
            // 
            // timerData
            // 
            this.timerData.Enabled = true;
            this.timerData.Interval = 500;
            this.timerData.Tick += new System.EventHandler(this.timerData_Tick);
            // 
            // lblQjimbo
            // 
            this.lblQjimbo.AutoSize = true;
            this.lblQjimbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQjimbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQjimbo.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblQjimbo.Location = new System.Drawing.Point(58, 596);
            this.lblQjimbo.Name = "lblQjimbo";
            this.lblQjimbo.Size = new System.Drawing.Size(45, 13);
            this.lblQjimbo.TabIndex = 13;
            this.lblQjimbo.Text = "Qjimbo";
            this.lblQjimbo.Click += new System.EventHandler(this.lblQjimbo_Click);
            // 
            // timerAutoUpdate
            // 
            this.timerAutoUpdate.Interval = 3600000;
            this.timerAutoUpdate.Tick += new System.EventHandler(this.timerAutoUpdate_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text File|*.txt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 615);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Screenshot engine by";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(114, 615);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "juce";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // timerSync
            // 
            this.timerSync.Enabled = true;
            this.timerSync.Interval = 60000;
            this.timerSync.Tick += new System.EventHandler(this.timerSync_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 634);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Game data help from";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Goldenrod;
            this.label15.Location = new System.Drawing.Point(111, 634);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Racer_S";
            // 
            // pbStatusIcon
            // 
            this.pbStatusIcon.Image = global::Yaasync.Properties.Resources.icon_online;
            this.pbStatusIcon.Location = new System.Drawing.Point(-2, 0);
            this.pbStatusIcon.Name = "pbStatusIcon";
            this.pbStatusIcon.Size = new System.Drawing.Size(48, 48);
            this.pbStatusIcon.TabIndex = 0;
            this.pbStatusIcon.TabStop = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 669);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblQjimbo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yaasync (beta) - Sync No Man\'s Sky";
            this.Shown += new System.EventHandler(this.MainPanel_Shown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtGameStatusText;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtVersion;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox gameStatusSystem;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox gameStatusPlanet;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox gameStatusGalaxyXYZ;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnSaveToText;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnScreenPathSelect;
        public System.Windows.Forms.Button btnScreenHotkeySelect;
        public System.Windows.Forms.TextBox txtScreenPath;
        public System.Windows.Forms.TextBox txtScreenKey;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNMSDBStatusText;
        public System.Windows.Forms.PictureBox pbStatusIcon;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.TextBox gameStatusSurfaceXYZ;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Timer timerProcess;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Timer timerData;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblQjimbo;
        private System.Windows.Forms.Timer timerAutoUpdate;
        public System.Windows.Forms.ProgressBar pbVersion;
        public System.Windows.Forms.TextBox gameStatusGalaxy;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddNewSync;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.SaveFileDialog saveFileDialog;
        public SourceGrid.Grid urlGrid;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public SourceGrid.Grid screenshotGrid;
        private System.Windows.Forms.Timer timerSync;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
    }
}

