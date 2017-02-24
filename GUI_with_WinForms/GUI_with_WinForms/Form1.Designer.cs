namespace GUI_with_WinForms
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolUnderHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.montiorExtensionByLabel = new System.Windows.Forms.Label();
            this.extensionListComboBox = new System.Windows.Forms.ComboBox();
            this.generalInstructionsToGetStarted = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryToMonitor = new System.Windows.Forms.ComboBox();
            this.labelDirectoryMonitor = new System.Windows.Forms.Label();
            this.startFSWButton = new System.Windows.Forms.Button();
            this.stopFSWbutton = new System.Windows.Forms.Button();
            this.labelWantToAddToDatabase = new System.Windows.Forms.Label();
            this.buttonDatabaseClickHere = new System.Windows.Forms.Button();
            this.buttonQueryToDatabase = new System.Windows.Forms.Button();
            this.label_countEvents = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.queryDatabaseToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // queryDatabaseToolStripMenuItem
            // 
            this.queryDatabaseToolStripMenuItem.Name = "queryDatabaseToolStripMenuItem";
            this.queryDatabaseToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.queryDatabaseToolStripMenuItem.Text = "Query Database";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolUnderHelp});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolUnderHelp
            // 
            this.aboutToolUnderHelp.Name = "aboutToolUnderHelp";
            this.aboutToolUnderHelp.Size = new System.Drawing.Size(107, 22);
            this.aboutToolUnderHelp.Text = "About";
            this.aboutToolUnderHelp.Click += new System.EventHandler(this.aboutToolUnderHelp_Click);
            // 
            // montiorExtensionByLabel
            // 
            this.montiorExtensionByLabel.AutoSize = true;
            this.montiorExtensionByLabel.Location = new System.Drawing.Point(28, 68);
            this.montiorExtensionByLabel.Name = "montiorExtensionByLabel";
            this.montiorExtensionByLabel.Size = new System.Drawing.Size(107, 13);
            this.montiorExtensionByLabel.TabIndex = 1;
            this.montiorExtensionByLabel.Text = "Monitor extension by:";
            this.montiorExtensionByLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // extensionListComboBox
            // 
            this.extensionListComboBox.FormattingEnabled = true;
            this.extensionListComboBox.Items.AddRange(new object[] {
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
            this.extensionListComboBox.Location = new System.Drawing.Point(31, 85);
            this.extensionListComboBox.Name = "extensionListComboBox";
            this.extensionListComboBox.Size = new System.Drawing.Size(188, 21);
            this.extensionListComboBox.TabIndex = 2;
            this.extensionListComboBox.SelectedIndexChanged += new System.EventHandler(this.extensionListComboBox_SelectedIndexChanged);
            this.extensionListComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.extensionListComboBox_MouseClick);
            // 
            // generalInstructionsToGetStarted
            // 
            this.generalInstructionsToGetStarted.AutoSize = true;
            this.generalInstructionsToGetStarted.Location = new System.Drawing.Point(131, 41);
            this.generalInstructionsToGetStarted.Name = "generalInstructionsToGetStarted";
            this.generalInstructionsToGetStarted.Size = new System.Drawing.Size(320, 13);
            this.generalInstructionsToGetStarted.TabIndex = 3;
            this.generalInstructionsToGetStarted.Text = "To get started select an extension, a directory, and then click Start";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Extension,
            this.Filename,
            this.PATH,
            this.Event});
            this.dataGridView1.Location = new System.Drawing.Point(0, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(562, 207);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
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
            // directoryToMonitor
            // 
            this.directoryToMonitor.FormattingEnabled = true;
            this.directoryToMonitor.Location = new System.Drawing.Point(307, 84);
            this.directoryToMonitor.Name = "directoryToMonitor";
            this.directoryToMonitor.Size = new System.Drawing.Size(207, 21);
            this.directoryToMonitor.TabIndex = 5;
            this.directoryToMonitor.SelectedIndexChanged += new System.EventHandler(this.directoryToMonitor_SelectedIndexChanged);
            this.directoryToMonitor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.directoryToMonitor_MouseClick);
            // 
            // labelDirectoryMonitor
            // 
            this.labelDirectoryMonitor.AutoSize = true;
            this.labelDirectoryMonitor.Location = new System.Drawing.Point(304, 68);
            this.labelDirectoryMonitor.Name = "labelDirectoryMonitor";
            this.labelDirectoryMonitor.Size = new System.Drawing.Size(101, 13);
            this.labelDirectoryMonitor.TabIndex = 6;
            this.labelDirectoryMonitor.Text = "Directory to monitor:";
            // 
            // startFSWButton
            // 
            this.startFSWButton.Enabled = false;
            this.startFSWButton.Location = new System.Drawing.Point(307, 112);
            this.startFSWButton.Name = "startFSWButton";
            this.startFSWButton.Size = new System.Drawing.Size(75, 23);
            this.startFSWButton.TabIndex = 7;
            this.startFSWButton.Text = "Start";
            this.startFSWButton.UseVisualStyleBackColor = true;
            this.startFSWButton.Click += new System.EventHandler(this.startFSWButton_Click);
            // 
            // stopFSWbutton
            // 
            this.stopFSWbutton.Location = new System.Drawing.Point(439, 112);
            this.stopFSWbutton.Name = "stopFSWbutton";
            this.stopFSWbutton.Size = new System.Drawing.Size(75, 23);
            this.stopFSWbutton.TabIndex = 8;
            this.stopFSWbutton.Text = "Stop";
            this.stopFSWbutton.UseVisualStyleBackColor = true;
            this.stopFSWbutton.Click += new System.EventHandler(this.stopFSWbutton_Click);
            // 
            // labelWantToAddToDatabase
            // 
            this.labelWantToAddToDatabase.AutoSize = true;
            this.labelWantToAddToDatabase.Location = new System.Drawing.Point(203, 225);
            this.labelWantToAddToDatabase.Name = "labelWantToAddToDatabase";
            this.labelWantToAddToDatabase.Size = new System.Drawing.Size(145, 13);
            this.labelWantToAddToDatabase.TabIndex = 9;
            this.labelWantToAddToDatabase.Text = "Want to query the database?";
            // 
            // buttonDatabaseClickHere
            // 
            this.buttonDatabaseClickHere.Location = new System.Drawing.Point(188, 241);
            this.buttonDatabaseClickHere.Name = "buttonDatabaseClickHere";
            this.buttonDatabaseClickHere.Size = new System.Drawing.Size(173, 23);
            this.buttonDatabaseClickHere.TabIndex = 10;
            this.buttonDatabaseClickHere.Text = "Click here to access Database";
            this.buttonDatabaseClickHere.UseVisualStyleBackColor = true;
            this.buttonDatabaseClickHere.Click += new System.EventHandler(this.buttonDatabaseClickHere_Click);
            // 
            // buttonQueryToDatabase
            // 
            this.buttonQueryToDatabase.Enabled = false;
            this.buttonQueryToDatabase.Location = new System.Drawing.Point(153, 270);
            this.buttonQueryToDatabase.Name = "buttonQueryToDatabase";
            this.buttonQueryToDatabase.Size = new System.Drawing.Size(252, 23);
            this.buttonQueryToDatabase.TabIndex = 11;
            this.buttonQueryToDatabase.Text = "Click here to write the data below the database";
            this.buttonQueryToDatabase.UseVisualStyleBackColor = true;
            this.buttonQueryToDatabase.Click += new System.EventHandler(this.buttonQueryToDatabase_Click);
            // 
            // label_countEvents
            // 
            this.label_countEvents.AutoSize = true;
            this.label_countEvents.Location = new System.Drawing.Point(456, 275);
            this.label_countEvents.Name = "label_countEvents";
            this.label_countEvents.Size = new System.Drawing.Size(97, 13);
            this.label_countEvents.TabIndex = 12;
            this.label_countEvents.Text = "Events detected: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 575);
            this.Controls.Add(this.label_countEvents);
            this.Controls.Add(this.buttonQueryToDatabase);
            this.Controls.Add(this.buttonDatabaseClickHere);
            this.Controls.Add(this.labelWantToAddToDatabase);
            this.Controls.Add(this.stopFSWbutton);
            this.Controls.Add(this.startFSWButton);
            this.Controls.Add(this.labelDirectoryMonitor);
            this.Controls.Add(this.directoryToMonitor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generalInstructionsToGetStarted);
            this.Controls.Add(this.extensionListComboBox);
            this.Controls.Add(this.montiorExtensionByLabel);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File System Watcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label montiorExtensionByLabel;
        private System.Windows.Forms.ComboBox extensionListComboBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolUnderHelp;
        private System.Windows.Forms.Label generalInstructionsToGetStarted;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.ComboBox directoryToMonitor;
        private System.Windows.Forms.Label labelDirectoryMonitor;
        private System.Windows.Forms.Button startFSWButton;
        private System.Windows.Forms.Button stopFSWbutton;
        private System.Windows.Forms.Label labelWantToAddToDatabase;
        private System.Windows.Forms.Button buttonDatabaseClickHere;
        private System.Windows.Forms.Button buttonQueryToDatabase;
        private System.Windows.Forms.Label label_countEvents;
    }
}

