using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace GUI_with_WinForms
{
    public partial class DataBaseWinForm : Form
    {
        public DataBaseWinForm()
        {
            InitializeComponent();
            openSqlConnection();
            buttonSubmit.Enabled = false;
            saveToLog.Enabled = false;
        }

        //Sql Members
        SQLiteConnection sqlite_Connection;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;

       
       

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            openSqlConnection();
            search();
            saveToLog.Enabled = true;

        }

        private void openSqlConnection()
        {
            sqlite_Connection = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            sqlite_Connection.Open();
            sqlite_cmd = sqlite_Connection.CreateCommand();

        }

        private void search()
        {
            string searchFilter = comboBoxExtensions.Text.ToLower();
            this.gridViewFromDB.Rows.Clear();
            //if (searchFilter.Equals("all extensions"))
                sqlite_cmd.CommandText = "SELECT * FROM EVENTRECORDINGS";
            //else
                //sqlite_cmd.CommandText = "SELECT * FROM EVENTRECORDINGS WHERE file = " + searchFilter;
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                
                this.gridViewFromDB.Rows.Add(sqlite_datareader.GetString(0),sqlite_datareader.GetString(1),sqlite_datareader.GetString(2),sqlite_datareader.GetString(3),sqlite_datareader.GetString(4));
                this.gridViewFromDB.Update();
            }

        }

         private void createSQLTable(string TableName)
        {
            //EVENTRECORDINGS
            //sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS "+ TableName + " (time integer primary key, event varchar(100), file varchar(100)), path varchar(100), changereason varchar(100));";
            sqlite_cmd.ExecuteNonQuery();
        }

        private void DataBaseWinForm_Load(object sender, EventArgs e)
        {
            sqlite_Connection.Close();
        }

        private void comboBoxExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSubmit.Enabled = true;
        }

        private void saveToLog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Log will be saved under \"DataGridViewLog.txt\"");

            using(TextWriter tw = new StreamWriter("DataGridViewLog.txt", true))
            {
                if (!(File.Exists("DataGridViewLog.txt"))) File.Create("DataGridViewLog.txt");
                foreach (DataGridViewRow row in gridViewFromDB.Rows)
                    //if (gridViewFromDB.Rows != null)
                        tw.WriteLine(row.Cells[0].Value.ToString() + " " + row.Cells[1].Value.ToString() + " " +  row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString() +" " + row.Cells[4].Value.ToString());

            }
        }
    }
}
