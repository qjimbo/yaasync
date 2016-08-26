namespace Yaasync.Views
{
    partial class AddEditSyncURLDialog
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSyncScreens = new System.Windows.Forms.CheckBox();
            this.cbSyncPosition = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 33);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(260, 20);
            this.txtURL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter URL:";
            // 
            // btnFetch
            // 
            this.btnFetch.BackColor = System.Drawing.Color.Cyan;
            this.btnFetch.Location = new System.Drawing.Point(128, 98);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(144, 23);
            this.btnFetch.TabIndex = 2;
            this.btnFetch.Text = "Fetch available services >";
            this.btnFetch.UseVisualStyleBackColor = false;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSyncScreens);
            this.groupBox1.Controls.Add(this.cbSyncPosition);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Services to Sync";
            // 
            // cbSyncScreens
            // 
            this.cbSyncScreens.AutoSize = true;
            this.cbSyncScreens.Enabled = false;
            this.cbSyncScreens.Location = new System.Drawing.Point(6, 42);
            this.cbSyncScreens.Name = "cbSyncScreens";
            this.cbSyncScreens.Size = new System.Drawing.Size(112, 17);
            this.cbSyncScreens.TabIndex = 1;
            this.cbSyncScreens.Text = "Sync Screenshots";
            this.cbSyncScreens.UseVisualStyleBackColor = true;
            // 
            // cbSyncPosition
            // 
            this.cbSyncPosition.AutoSize = true;
            this.cbSyncPosition.Enabled = false;
            this.cbSyncPosition.Location = new System.Drawing.Point(6, 19);
            this.cbSyncPosition.Name = "cbSyncPosition";
            this.cbSyncPosition.Size = new System.Drawing.Size(90, 17);
            this.cbSyncPosition.TabIndex = 0;
            this.cbSyncPosition.Text = "Sync Position";
            this.cbSyncPosition.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(115, 203);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unique Key (optional):";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 72);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(260, 20);
            this.txtKey.TabIndex = 7;
            // 
            // AddEditSyncURLDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 240);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditSyncURLDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Sync URL";
            this.Shown += new System.EventHandler(this.AddEditSyncURLDialog_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtURL;
        public System.Windows.Forms.Button btnFetch;
        public System.Windows.Forms.CheckBox cbSyncScreens;
        public System.Windows.Forms.CheckBox cbSyncPosition;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtKey;
    }
}