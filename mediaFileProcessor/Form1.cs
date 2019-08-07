using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Data.SqlClient;

namespace mediaFileProcessor
{

    public partial class metaProcessor : Form
    {
        SynchronizationContext _syncContext = null;
        Form3 f3 = null;
        int lastCount = 0;
        public metaProcessor()
        {
            InitializeComponent();
            _syncContext = SynchronizationContext.Current;
            string path = Directory.GetCurrentDirectory();
            folderTxt.Text = path;
            Util.LogErr("Start processor.");
            statusLbl.Text = "";
            //x.ShowNewFolderButton = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void Display(string output)
        {
            //ListBoxItem ni = new ListBoxItem("name", "value")
            if (output != null)
            {
                if ((output.Trim().Length > 0) && (!output.Trim().EndsWith("Thumbs.db")) && (!output.Trim().EndsWith(".txt")))
                {
                    _syncContext.Post(_ =>  fileLst.Items.Add(output), null);
                    
                }
            }
        }
        //display files
        private void button1_Click(object sender0, EventArgs e)
        {
            try
            {
                if (folderTxt.Text.Length > 0)
                {
                    fileLst.Items.Clear();
                    Process process = new Process();
                    process.StartInfo.FileName = @"cmd.exe";
                    process.StartInfo.Arguments = "/C dir \"" + folderTxt.Text + "\"  /s /b /a-d  /o"; // Note the /c command (*)
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;

                    process.OutputDataReceived += (sender, args) => Display(args.Data);
                    process.ErrorDataReceived += (sender, args) => Display(args.Data);

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.WaitForExit();

                    timer1.Enabled = true;
                    lastCount = 0;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                folderTxt.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void fileLst_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (fileLst.SelectedItem != null)
                {
                    string filePath = fileLst.SelectedItem.ToString();
                    string output = Util.GetMeta(filePath);
                    Form2 metaDialog = new Form2();
                    string nt = Util.getXml2(output);
                    metaDialog.setText(nt);
                    metaDialog.setFocus();
                    metaDialog.ShowDialog();
                    metaDialog.Dispose();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void saveDbBtn_Click(object sender, EventArgs e)
        {
            Util.LogErr("Start saving DB from: " + folderTxt.Text);
            string connectionString = mediaFileProcessor.Properties.Settings.Default.dbString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach(object i in fileLst.Items)
                {
                    try
                    {
                        string metaData = Util.GetMeta(i.ToString());

                        SqlCommand cmd = new SqlCommand("_meta_insert", conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@file", i.ToString());
                        cmd.Parameters.AddWithValue("@metaData", Util.getXml(metaData));
                        cmd.Parameters.AddWithValue("@metaData2", Util.getXml4(metaData));
                        //var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                        //returnParameter.Direction = ParameterDirection.ReturnValue; 
                        cmd.ExecuteNonQuery();
                        //int newId = (int)cmd.Parameters["@ReturnVal"].Value;

                    }
                    catch(Exception err)
                    {
                        Util.LogErr("Error saving DB for: " + i.ToString());
                        Util.LogErr(err.Message);
                    }
                }
            }
            Util.LogErr("Done saving DB from: " + folderTxt.Text);
            MessageBox.Show("Meta data has been saved successfully!");
            fileLst.Items.Clear();
        }

        private void CleanListBtn_Click(object sender, EventArgs e)
        {
            string connectionString = mediaFileProcessor.Properties.Settings.Default.dbString;
            List<string> files = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select FilePath from _metaCollection where MetaData is not null order by 1", conn);
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    files.Add(rd.GetString(0));
                }
            }
            for (int i = 0; i < fileLst.Items.Count; i++)
            {
                string f = fileLst.Items[i].ToString();
                if (files.Contains(f))
                {
                    fileLst.Items.RemoveAt(i);
                    i--;
                }
            }
            MessageBox.Show("Files with metadata already stored in the database have been removed from the list successfully!", "Confirmation");
            setListCount();
        }

        private void cleanDbBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete metadata stored in the database for these files?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = mediaFileProcessor.Properties.Settings.Default.dbString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    for (int i = 0; i < fileLst.Items.Count; i++)
                    {
                        string f = fileLst.Items[i].ToString();
                        SqlCommand cmd = new SqlCommand("_meta_delete", conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@file", f);
                        cmd.ExecuteNonQuery();
                        fileLst.Items.RemoveAt(i);
                        i--;
                    }
                }
                MessageBox.Show("The metadata in the database hase been cleared successfully!", "Confirmation");
                setListCount();
            }
        }

        private void folderTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                button1_Click(sender, null);
            }
        }

        //folder open button
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                folderTxt.Text = folderBrowserDialog2.SelectedPath;
                button1_Click(sender, null);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int c = fileLst.Items.Count;
            if (lastCount == c)
            {
                timer1.Enabled = false;
            }
            else
            {
                lastCount = c;
                setListCount();
            }
        }

        private void setListCount()
        {
            int c = fileLst.Items.Count;
            string fileCount = "";
            if (c > 1)
            {
                fileCount = c.ToString() + " files in total. ";
                statusLbl.Text = fileCount + " Double click on a file to see its metadata.";
            }
            else
            {
                if (c == 1)
                    statusLbl.Text = "1 file only.  Double click on the file to see its metadata.";
                else
                    statusLbl.Text = "No file has been found.";
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new Form3();
                f3.Show(this);
            }
            else
            {
                if (f3.IsDisposed)
                {
                    f3 = new Form3();
                    f3.Show(this);
                }
                else
                    f3.Focus();
            }
        }

        //string[] lines = File.ReadAllLines(@"D:\output2.txt");
        //foreach (string line in lines)
        //{
        //    //Console.WriteLine(line);
        //    Process process = new Process();
        //    process.StartInfo.FileName = @"d:\exiftool.exe";
        //    process.StartInfo.Arguments = "\"" + line + "\""; // Note the /c command (*)
        //    process.StartInfo.UseShellExecute = false;
        //    process.StartInfo.RedirectStandardOutput = true;
        //    process.StartInfo.RedirectStandardError = true;
        //    process.Start();
        //    //* Read the output (or the error)
        //    string output = process.StandardOutput.ReadToEnd();
        //    output = output.Replace("\r\n", "^");
        //    Console.WriteLine(getXml(output));
        //    string err = process.StandardError.ReadToEnd();
        //    Console.WriteLine(err);
        //    process.WaitForExit();
        //}
    }
}
