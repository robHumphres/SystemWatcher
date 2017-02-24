namespace GUI_with_WinForms
{
    partial class DataBaseWinForm
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
            this.labelWelcomeMessage = new System.Windows.Forms.Label();
            this.gridViewFromDB = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.comboBoxExtensions = new System.Windows.Forms.ComboBox();
            this.labelSearchWithExtension = new System.Windows.Forms.Label();
            this.saveToLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFromDB)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcomeMessage
            // 
            this.labelWelcomeMessage.AutoSize = true;
            this.labelWelcomeMessage.Location = new System.Drawing.Point(244, 9);
            this.labelWelcomeMessage.Name = "labelWelcomeMessage";
            this.labelWelcomeMessage.Size = new System.Drawing.Size(435, 13);
            this.labelWelcomeMessage.TabIndex = 0;
            this.labelWelcomeMessage.Text = "Welcome to the Database. Please choose from the selection below and then press Su" +
    "bmit.";
            // 
            // gridViewFromDB
            // 
            this.gridViewFromDB.AllowUserToAddRows = false;
            this.gridViewFromDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewFromDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewFromDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Extension,
            this.Filename,
            this.PATH,
            this.Event});
            this.gridViewFromDB.Location = new System.Drawing.Point(12, 105);
            this.gridViewFromDB.Name = "gridViewFromDB";
            this.gridViewFromDB.Size = new System.Drawing.Size(869, 262);
            this.gridViewFromDB.TabIndex = 5;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Extension
            // 
            this.Extension.HeaderText = "Extension";
            this.Extension.Name = "Extension";
            // 
            // Filename
            // 
            this.Filename.HeaderText = "FileName";
            this.Filename.Name = "Filename";
            // 
            // PATH
            // 
            this.PATH.HeaderText = "Path";
            this.PATH.Name = "PATH";
            // 
            // Event
            // 
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(795, 76);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // comboBoxExtensions
            // 
            this.comboBoxExtensions.FormattingEnabled = true;
            this.comboBoxExtensions.Items.AddRange(new object[] {
            "ALL EXTENSIONS",
            ".AIFF",
            ".AU",
            ".AVI",
            ".BAT",
            ".BMP",
            ".CLASS",
            ".JAVA",
            ".CSV",
            ".DBF",
            ".DIF",
            ".DOC",
            ".DOCX",
            ".EPS",
            ".EXE",
            ".FM3",
            ".GIF",
            ".HQX",
            ".HTM",
            ".HTML",
            ".JPG",
            ".JPEG",
            ".MAC",
            ".MAP",
            ".MDB",
            ".MID",
            ".MIDI",
            ".MOV",
            ".QT",
            ".MTB",
            ".MTW",
            ".PDF",
            ".P65",
            ".T65",
            ".PNG",
            ".PPT",
            ".PPTX",
            ".PSD",
            ".PSP",
            ".QXD",
            ".RA",
            ".RTF",
            ".SIT",
            ".TAR",
            ".TIF",
            ".TXT",
            ".WAV",
            ".WK3",
            ".WKS",
            ".WPD",
            ".WP5",
            ".XLS",
            ".XLSX",
            ".ZIP"});
            this.comboBoxExtensions.Location = new System.Drawing.Point(12, 39);
            this.comboBoxExtensions.Name = "comboBoxExtensions";
            this.comboBoxExtensions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExtensions.TabIndex = 9;
            this.comboBoxExtensions.SelectedIndexChanged += new System.EventHandler(this.comboBoxExtensions_SelectedIndexChanged);
            // 
            // labelSearchWithExtension
            // 
            this.labelSearchWithExtension.AutoSize = true;
            this.labelSearchWithExtension.Location = new System.Drawing.Point(13, 20);
            this.labelSearchWithExtension.Name = "labelSearchWithExtension";
            this.labelSearchWithExtension.Size = new System.Drawing.Size(160, 13);
            this.labelSearchWithExtension.TabIndex = 10;
            this.labelSearchWithExtension.Text = "Search with an extension below:";
            // 
            // saveToLog
            // 
            this.saveToLog.Location = new System.Drawing.Point(16, 75);
            this.saveToLog.Name = "saveToLog";
            this.saveToLog.Size = new System.Drawing.Size(185, 23);
            this.saveToLog.TabIndex = 11;
            this.saveToLog.Text = "Save The Query Below to a Log";
            this.saveToLog.UseVisualStyleBackColor = true;
            this.saveToLog.Click += new System.EventHandler(this.saveToLog_Click);
            // 
            // DataBaseWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 379);
            this.Controls.Add(this.saveToLog);
            this.Controls.Add(this.labelSearchWithExtension);
            this.Controls.Add(this.comboBoxExtensions);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.gridViewFromDB);
            this.Controls.Add(this.labelWelcomeMessage);
            this.Name = "DataBaseWinForm";
            this.Text = "DataBaseWinForm";
            this.Load += new System.EventHandler(this.DataBaseWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFromDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcomeMessage;
        private System.Windows.Forms.DataGridView gridViewFromDB;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.ComboBox comboBoxExtensions;
        private System.Windows.Forms.Label labelSearchWithExtension;
        private System.Windows.Forms.Button saveToLog;
    }
}