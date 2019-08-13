namespace mediaFileProcessor
{
    partial class metaProcessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(metaProcessor));
            this.startBtn = new System.Windows.Forms.Button();
            this.folderTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.fileLst = new System.Windows.Forms.ListBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.saveDbBtn = new System.Windows.Forms.Button();
            this.CleanListBtn = new System.Windows.Forms.Button();
            this.cleanDbBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(682, 7);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(50, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Display";
            this.myToolTip.SetToolTip(this.startBtn, "Display files in the selected folder and all sub folders.");
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderTxt
            // 
            this.folderTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTxt.Location = new System.Drawing.Point(161, 9);
            this.folderTxt.Name = "folderTxt";
            this.folderTxt.Size = new System.Drawing.Size(469, 20);
            this.folderTxt.TabIndex = 0;
            this.folderTxt.Text = "X:\\Historic\\Cave Creek";
            this.folderTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.folderTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter a folder name: ";
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.ShowNewFolderButton = false;
            // 
            // fileLst
            // 
            this.fileLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileLst.FormattingEnabled = true;
            this.fileLst.Location = new System.Drawing.Point(19, 35);
            this.fileLst.Margin = new System.Windows.Forms.Padding(0);
            this.fileLst.Name = "fileLst";
            this.fileLst.Size = new System.Drawing.Size(866, 561);
            this.fileLst.TabIndex = 3;
            this.fileLst.DoubleClick += new System.EventHandler(this.fileLst_DoubleClick);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLbl.Location = new System.Drawing.Point(0, 599);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Padding = new System.Windows.Forms.Padding(16, 0, 0, 11);
            this.statusLbl.Size = new System.Drawing.Size(217, 24);
            this.statusLbl.TabIndex = 4;
            this.statusLbl.Text = "Double click on a file to see its metadata.";
            // 
            // saveDbBtn
            // 
            this.saveDbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDbBtn.Location = new System.Drawing.Point(828, 6);
            this.saveDbBtn.Name = "saveDbBtn";
            this.saveDbBtn.Size = new System.Drawing.Size(57, 24);
            this.saveDbBtn.TabIndex = 5;
            this.saveDbBtn.Text = "Save";
            this.myToolTip.SetToolTip(this.saveDbBtn, "Extract and save metadata into the database for the files in the list.");
            this.saveDbBtn.UseVisualStyleBackColor = true;
            this.saveDbBtn.Click += new System.EventHandler(this.saveDbBtn_Click);
            // 
            // CleanListBtn
            // 
            this.CleanListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CleanListBtn.Location = new System.Drawing.Point(805, 600);
            this.CleanListBtn.Name = "CleanListBtn";
            this.CleanListBtn.Size = new System.Drawing.Size(80, 23);
            this.CleanListBtn.TabIndex = 6;
            this.CleanListBtn.Text = "Check";
            this.CleanListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.myToolTip.SetToolTip(this.CleanListBtn, "Check the current file list and remove those with metadata already stored in the " +
        "database.");
            this.CleanListBtn.UseVisualStyleBackColor = true;
            this.CleanListBtn.Click += new System.EventHandler(this.CleanListBtn_Click);
            // 
            // cleanDbBtn
            // 
            this.cleanDbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanDbBtn.Location = new System.Drawing.Point(719, 600);
            this.cleanDbBtn.Name = "cleanDbBtn";
            this.cleanDbBtn.Size = new System.Drawing.Size(80, 23);
            this.cleanDbBtn.TabIndex = 7;
            this.cleanDbBtn.Text = "Delete";
            this.myToolTip.SetToolTip(this.cleanDbBtn, "Delete metadata stored in the database for the files in the list.");
            this.cleanDbBtn.UseVisualStyleBackColor = true;
            this.cleanDbBtn.Click += new System.EventHandler(this.cleanDbBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::mediaFileProcessor.Properties.Resources.folderOpen0;
            this.button1.Location = new System.Drawing.Point(636, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.SystemColors.Control;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Navy;
            this.searchBtn.Location = new System.Drawing.Point(537, 600);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(161, 23);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.myToolTip.SetToolTip(this.searchBtn, "Search metadata in the database that have extracted and saved previously from the" +
        " file system.");
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // metaProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 623);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cleanDbBtn);
            this.Controls.Add(this.CleanListBtn);
            this.Controls.Add(this.saveDbBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.fileLst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderTxt);
            this.Controls.Add(this.startBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "metaProcessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department of Conservation - Metadata Processor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox folderTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.ListBox fileLst;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button saveDbBtn;
        private System.Windows.Forms.Button CleanListBtn;
        private System.Windows.Forms.Button cleanDbBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Button searchBtn;
    }
}

