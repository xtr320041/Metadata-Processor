using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace mediaFileProcessor
{
    public partial class Form3 : Form
    {
        List<ValuePair> valueList = null;
        List<ValuePair> fileList = null;
        public Form3()
        {
            InitializeComponent();
            valueList = new List<ValuePair>();
            string connectionString = mediaFileProcessor.Properties.Settings.Default.dbString;
            List<string> files = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from _ValueListSummary order by 1", conn);
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    valueList.Add(new ValuePair(rd.GetString(0), rd.GetString(1)));
                }
            }

            for (int i = 0; i < valueList.Count; i++)
            {
                valueLtv.Items.Add(new ListViewItem(new string[] {valueList[i].Key, valueList[i].Value}));
                field1Cbo.Items.Add(valueList[i].Key);
                field2Cbo.Items.Add(valueList[i].Key);
            }


        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filterTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                displayBtn_Click(sender, null);
            }
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            filterTxt.Text = filterTxt.Text.Trim();
            if (filterTxt.Text.Length > 0)
            {
                string filter = filterTxt.Text.ToLower();
                valueLtv.Items.Clear();
                for (int i = 0; i < valueList.Count; i++)
                {
                    if (valueList[i].Key.ToLower().Contains(filter))
                        valueLtv.Items.Add(new ListViewItem(new string[] { valueList[i].Key, valueList[i].Value }));
                }
            }
            else
            {
                valueLtv.Items.Clear();
                for (int i = 0; i < valueList.Count; i++)
                {
                    valueLtv.Items.Add(new ListViewItem(new string[] { valueList[i].Key, valueList[i].Value }));
                }
            }
        }

        private void set1Btn_Click(object sender, EventArgs e)
        {
            fFilter1Txt.Text = fFilter1Txt.Text.Trim();
            if (fFilter1Txt.Text.Length > 0)
            {
                string filter = fFilter1Txt.Text.ToLower();
                field1Cbo.Items.Clear();
                for (int i = 0; i < valueList.Count; i++)
                {
                    if (valueList[i].Key.ToLower().Contains(filter))
                        field1Cbo.Items.Add(valueList[i].Key);
                }
            }
            else
            {
                field1Cbo.Items.Clear();
                for (int i = 0; i < valueList.Count; i++)
                {
                    field1Cbo.Items.Add(valueList[i].Key);
                }
            }
            field1Cbo.Focus();
        }

        private void fFilter1Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                set1Btn_Click(sender, null);
            }
        }

        private void set2Btn_Click(object sender, EventArgs e)
        {
            fFilter2Txt.Text = fFilter2Txt.Text.Trim();
            if (fFilter2Txt.Text.Length > 0)
            {
                string filter = fFilter2Txt.Text.ToLower();
                field2Cbo.Items.Clear();
                for (int i = 0; i < valueList.Count; i++)
                {
                    if (valueList[i].Key.ToLower().Contains(filter))
                        field2Cbo.Items.Add(valueList[i].Key);
                }
            }
            else
            {
                field2Cbo.Items.Clear();
                for (int i = 0; i < valueList.Count; i++)
                {
                    field2Cbo.Items.Add(valueList[i].Key);
                }
            }
            field2Cbo.Select();
        }

        private void fFilter2Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                set2Btn_Click(sender, null);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string vf1 = vFilter1Txt.Text.Trim();
            string vf2 = vFilter2Txt.Text.Trim();
            string v1 = "";
            string v2 = "";
            if (field1Cbo.SelectedItem != null)
                v1 = field1Cbo.SelectedItem.ToString();
            if (field2Cbo.SelectedItem != null)
                v2 = field2Cbo.SelectedItem.ToString();
            string orAnd = "";
            if (andRdi.Checked)
                orAnd = "and";
            else
                orAnd = "or";

            if ((v1 == "") && (v2 == "") && (vf1 == "") && (vf2 == ""))
            {
                MessageBox.Show("Must enter some value in the selection filters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if ((orAnd ==  "or") && (((v1 == "") && (vf1 == "")) || ((v2 == "") && (vf2 == ""))))
            {
                MessageBox.Show("Must enter some value in the selection filters with OR condition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //if ((v1=="") && (v2== ""))
            //{
            //    MessageBox.Show("Must enter some value in the selection filters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}

            //if ((vf1.Length > 0) && (v1 == ""))
            //{
            //    MessageBox.Show("Must select a metadata field name for the selection filter: " + vf1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}

            //if ((vf2.Length > 0) && (v2 == ""))
            //{
            //    MessageBox.Show("Must select a metadata field name for the selection filter: " + vf2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}

            //if ((v1 == "") && (v2.Length > 0))
            //{
            //    vf1 = vf2;
            //    v1 = v2;
            //    vf2 = "";
            //}

            //MessageBox.Show("Please wait while searching the database.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cursor.Current = Cursors.WaitCursor;
            string connectionString = mediaFileProcessor.Properties.Settings.Default.dbString;
            fileList = new List<ValuePair>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("_MetaSearch", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@key1", v1);
                cmd.Parameters.AddWithValue("@value1", vf1);
                cmd.Parameters.AddWithValue("@key2", v2);
                cmd.Parameters.AddWithValue("@value2", vf2);
                cmd.Parameters.AddWithValue("@andOr", orAnd);
                cmd.CommandTimeout = 600;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    fileList.Add(new ValuePair(rd.GetString(1), rd.GetString(2)));
                }
            }

            fileLst.Items.Clear();
            for (int i = 0; i < fileList.Count; i++)
            {
                fileLst.Items.Add(fileList[i].Key);
            }
            setListCount();
            Cursor.Current = Cursors.Default;
        }

        private void setListCount()
        {
            int c = fileLst.Items.Count;
            string fileCount = "";
            if (c > 1)
            {
                fileCount = c.ToString() + " files in total. ";
                statusLbl.Text = fileCount + " Double click on a file to see its metadata form the database.";
            }
            else
            {
                if (c == 1)
                    statusLbl.Text = "1 file only.  Double click on the file to see its metadata form the database.";
                else
                    statusLbl.Text = "No file has been found.";
            }
        }

        private void fileLst_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (fileLst.SelectedItem != null)
                {
                    //string filePath = fileLst.SelectedItem.ToString();
                    //string output = Util.GetMeta(filePath);
                    int i = fileLst.SelectedIndex;
                    Form2 metaDialog = new Form2();
                    string nt = Util.getXml3(fileList[i].Value);
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

        private void myTimer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("timer1");
            
            myTimer1.Enabled = false;
            field1Cbo.Focus();

        }

        private void field1Cbo_Enter(object sender, EventArgs e)
        {
            field1Cbo.DroppedDown = true;
        }

        private void field1Cbo_Leave(object sender, EventArgs e)
        {
            field1Cbo.DroppedDown = false;
        }

        private void field2Cbo_Enter(object sender, EventArgs e)
        {
            field2Cbo.DroppedDown = true;
        }

        private void field2Cbo_Leave(object sender, EventArgs e)
        {
            field2Cbo.DroppedDown = false;
        }

        private void vFilter1Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                searchBtn_Click(sender, null);
            }
        }

        private void vFilter2Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                searchBtn_Click(sender, null);
            }
        }
    }
}
