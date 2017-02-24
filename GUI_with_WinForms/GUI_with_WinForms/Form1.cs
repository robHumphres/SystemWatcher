using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Data.SQLite;

namespace GUI_with_WinForms
{

    public partial class Form1 : Form
    {

        private string History = "History.txt";
        public static string getPath = "";
        FileSystemWatcher watcher;
        private int Mux = 0, InnerMux = 0,EventCount;

        //Sql Members
        SQLiteConnection sqlite_Connection;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;

        public Form1()
        {
            InitializeComponent();
            stopFSWbutton.Enabled = false;
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
            if (File.Exists(History))
                {
                    updateCheckBoxHistory();
                }
            else
                {
                    File.Create(History);
                }  
             
        }// Form Load

        private void updateCheckBoxHistory()
        {
            directoryToMonitor.Items.Clear();
            string[] historysContents = File.ReadAllLines(History);
            foreach (var line in historysContents)
            {
                string[] temp = line.Split('\n');
                directoryToMonitor.Items.Add(temp[0]);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutMessageBoxForm();
            aboutForm.Show();
        }
        //Messed up Method nothing inside.
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        //Messed up Method nothing inside.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Messed up Method nothing inside.
        private void extensionListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolUnderHelp_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutMessageBoxForm();
            aboutForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void directoryToMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonDatabaseClickHere_Click(object sender, EventArgs e)
        {
            if (File.Exists("database.db"))
            {
                var dbForm = new DataBaseWinForm();
                dbForm.Show();
            }
            else
                MessageBox.Show("You cannot go to the database page yet since you haven't made a database yet, Please search and write to Database first.");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you'd want to close the program?", "File System Watcher closing Dialog", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Under File ------> Close (Quit Program)
            if(e.Control && e.KeyCode == Keys.Q)
            {
                closeToolStripMenuItem_Click(sender, e);
            }

            //Under File ------> Start
            if(e.Control && e.KeyCode == Keys.S)
            {
                //haven't finished this one, but still be starting the program
            }

            //Under File -----> Query Database
            if(e.Control && e.KeyCode == Keys.D)
            {
                buttonDatabaseClickHere_Click(sender, e);
            }
            
            //Under File ----> Stop
            if(e.Control && e.KeyCode == Keys.H)
            {
                // Havent finished this one, but will halt the program
            }

            //Under Help ---> About 
            if(e.Control && e.KeyCode == Keys.A)
            {
                aboutToolStripMenuItem_Click(sender, e);
            }

        }//end of Form1_KeyDown

        private void startFSWButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(directoryToMonitor.Text))&& !(string.IsNullOrWhiteSpace(directoryToMonitor.Text))) {
                new Thread(checkHistoryIfEntered).Start();
                startFSWButton.Enabled = false;
                stopFSWbutton.Enabled = true;
                //new Thread(Run).Start();
                dataGridView1.ScrollBars = ScrollBars.None;
                extensionListComboBox.Enabled = false;
                directoryToMonitor.Enabled = false;
                Run();
               
               
            }

            if (string.IsNullOrWhiteSpace(directoryToMonitor.Text))
            {
                MessageBox.Show("You've left your directory to Monitor box empty, Please select one from either history or manually enter something please.");
            }

            if (string.IsNullOrWhiteSpace(extensionListComboBox.Text))
            {
                MessageBox.Show("You've left your Extension box empty please select one from the drop down list.");
            }
        }

        


        private void touchFile(string FiletoTouch)
        {
            System.IO.File.SetLastWriteTimeUtc(FiletoTouch, DateTime.UtcNow);

        }

        private void checkHistoryIfEntered()
        {

            /*
             * checkHistoryIfEntered is called inside of a Thread inside the startFSWButton_Click
             */

            string wordToCheck = directoryToMonitor.Text;
            if (!string.IsNullOrWhiteSpace(wordToCheck))
            {
                Boolean containedInHistory = false;
                touchFile(History);
                containedInHistory = isWordinHistoryAlready(wordToCheck);               

                if (!containedInHistory)
                {
                    //MessageBox.Show("Made it inside not in history file");
                    try
                    {
                        writeToFile(wordToCheck);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("There was an error writing to the history log");
                    }
                }
                //MessageBox.Show("Made it to end of check history");
            }
        }//end of checkHistoryIfEntered()

        public Boolean isWordinHistoryAlready(string wordToCheck)
        {
            Boolean contains = false;

            using (StreamReader r = new StreamReader(History))
            {
                string lineToRead;
                while ((lineToRead = r.ReadLine()) != null)
                {
                    if (lineToRead.Equals(wordToCheck))
                    {
                        contains = true;
                    }

                }//end of while

            }//end of using streamReader

            return contains;
        }

        private void writeToFile(string s)
        {
            using (StreamWriter write = new StreamWriter(History, true))
            {
                write.WriteLine(s);
                
            }//end of using
            updateCheckBoxHistory();
        }      

       
        //Start of FileSystemWatcher Methods

        //Stops FileSystemWatcher
        private void stopFileSystemWatcher()
        {
            watcher.EnableRaisingEvents = false;
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            while (Mux != 0) ;
                Mux = 1;
            while (InnerMux != 0) ;
                InnerMux = 1;
            if(Mux == 1 && InnerMux == 1) { 
                this.dataGridView1.Rows.Add(DateTime.Now.ToFileTime(), "File", e.Name, e.FullPath, "Renamed");
                this.dataGridView1.Update();
                EventCount++;
                label_countEvents.Text = "Events detected: " + EventCount;
                //MessageBox.Show("made into onRename");
                InnerMux = 0;
            }//Mux ! = to 0
            Mux = 0;

        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            while (Mux != 0) ;
            Mux = 1;
            while (InnerMux != 0) ;
            InnerMux = 1;
            if (Mux == 1 & InnerMux == 1)
            {
                this.dataGridView1.Rows.Add(DateTime.Now.ToFileTime(), "File", e.Name, e.FullPath, e.ChangeType);
                this.dataGridView1.Update();
                EventCount++;
                label_countEvents.Text = "Events detected: " + EventCount;
                InnerMux = 0;
            }
            Mux = 0;
            //MessageBox.Show("made into onchanged");


        }
        //Starts FileSystemWatcher
        public void Run()
        {
            string m_pathToWatch = directoryToMonitor.Text; 
             
            watcher = new FileSystemWatcher();
            watcher.Path = m_pathToWatch;
            
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            if (!extensionListComboBox.Text.Equals("ALL EXTENSIONS"))
                watcher.Filter = extensionListComboBox.Text;
            watcher.IncludeSubdirectories = true;

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;


            // Wait for the user to quit the program.
           // while (!(stopFSWbutton.Enabled == false)) ;
        }

        //End of FileSystemWatcher Methods

        private void stopFSWbutton_Click(object sender, EventArgs e)
        {
            stopFileSystemWatcher();
            startFSWButton.Enabled = true;
            stopFSWbutton.Enabled = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
            extensionListComboBox.Enabled = true;
            directoryToMonitor.Enabled = true;
        }

        //enables the button for data entry once somethigns added to datagridview
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            buttonQueryToDatabase.Enabled = true;
        }



        // These on Clicks check each other to make sure they have data inside of them. Then the start button is enabled.
        private void extensionListComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(directoryToMonitor.Text))){
                startFSWButton.Enabled = true;
            }
            
        }

        private void directoryToMonitor_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(extensionListComboBox.Text)))
            {
                startFSWButton.Enabled = true;
            }
        }


        /// <summary>
        /// Sql Methods below
        /// </summary>

        private void openSqlConnection()
        {
            sqlite_Connection = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            sqlite_Connection.Open();
            sqlite_cmd = sqlite_Connection.CreateCommand();
            
        }

        private void buttonQueryToDatabase_Click(object sender, EventArgs e)
        {
            openSqlConnection();
            createSQLTable("EVENTRECORDINGS");
            foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    insertIntoSQLTable(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                }
        }

        private void createSQLTable(string TableName)
        {
            //EVENTRECORDINGS
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS EVENTRECORDINGS (time varchar(200) , event varchar(500), file varchar(500), path varchar(500), changereason varchar(500));";
            sqlite_cmd.ExecuteNonQuery();
        }

        private void insertIntoSQLTable(string time,string eventType, string file,string path,string typeOfChange)
        {
            sqlite_cmd.CommandText = "INSERT INTO EVENTRECORDINGS (time, event, file, path, changereason) VALUES ('" + time + "','" + eventType + "','" + file + "','" + path + "','" + typeOfChange+"')";
            sqlite_cmd.ExecuteNonQuery();

        }

        


    }//end of form1 : form

    
}
