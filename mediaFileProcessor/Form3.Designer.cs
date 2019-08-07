namespace mediaFileProcessor
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orRdi = new System.Windows.Forms.RadioButton();
            this.andRdi = new System.Windows.Forms.RadioButton();
            this.fileLst = new System.Windows.Forms.ListBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.vFilter2Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.field2Cbo = new System.Windows.Forms.ComboBox();
            this.set2Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fFilter2Txt = new System.Windows.Forms.TextBox();
            this.vFilter1Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.field1Cbo = new System.Windows.Forms.ComboBox();
            this.set1Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fFilter1Txt = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.displayBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filterTxt = new System.Windows.Forms.TextBox();
            this.valueLtv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeBtn = new System.Windows.Forms.Button();
            this.myTimer1 = new System.Windows.Forms.Timer(this.components);
            this.myToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1129, 716);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statusLbl);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.fileLst);
            this.tabPage2.Controls.Add(this.searchBtn);
            this.tabPage2.Controls.Add(this.vFilter2Txt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.field2Cbo);
            this.tabPage2.Controls.Add(this.set2Btn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.fFilter2Txt);
            this.tabPage2.Controls.Add(this.vFilter1Txt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.field1Cbo);
            this.tabPage2.Controls.Add(this.set1Btn);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.fFilter1Txt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1121, 690);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matadata File Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(3, 674);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.statusLbl.Size = new System.Drawing.Size(213, 13);
            this.statusLbl.TabIndex = 20;
            this.statusLbl.Text = "Double click on a file to see its metadata.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.orRdi);
            this.groupBox1.Controls.Add(this.andRdi);
            this.groupBox1.Location = new System.Drawing.Point(690, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 53);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // orRdi
            // 
            this.orRdi.AutoSize = true;
            this.orRdi.Location = new System.Drawing.Point(59, 19);
            this.orRdi.Name = "orRdi";
            this.orRdi.Size = new System.Drawing.Size(41, 17);
            this.orRdi.TabIndex = 1;
            this.orRdi.Text = "OR";
            this.orRdi.UseVisualStyleBackColor = true;
            // 
            // andRdi
            // 
            this.andRdi.AutoSize = true;
            this.andRdi.Checked = true;
            this.andRdi.Location = new System.Drawing.Point(9, 19);
            this.andRdi.Name = "andRdi";
            this.andRdi.Size = new System.Drawing.Size(48, 17);
            this.andRdi.TabIndex = 0;
            this.andRdi.TabStop = true;
            this.andRdi.Text = "AND";
            this.andRdi.UseVisualStyleBackColor = true;
            // 
            // fileLst
            // 
            this.fileLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLst.FormattingEnabled = true;
            this.fileLst.Location = new System.Drawing.Point(17, 59);
            this.fileLst.Name = "fileLst";
            this.fileLst.Size = new System.Drawing.Size(1087, 615);
            this.fileLst.TabIndex = 18;
            this.fileLst.DoubleClick += new System.EventHandler(this.fileLst_DoubleClick);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(966, 29);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(138, 23);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Text = "Search Database";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // vFilter2Txt
            // 
            this.vFilter2Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vFilter2Txt.Location = new System.Drawing.Point(549, 32);
            this.vFilter2Txt.Name = "vFilter2Txt";
            this.vFilter2Txt.Size = new System.Drawing.Size(135, 20);
            this.vFilter2Txt.TabIndex = 15;
            this.vFilter2Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vFilter2Txt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Selection filter:";
            // 
            // field2Cbo
            // 
            this.field2Cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.field2Cbo.FormattingEnabled = true;
            this.field2Cbo.Location = new System.Drawing.Point(244, 31);
            this.field2Cbo.Name = "field2Cbo";
            this.field2Cbo.Size = new System.Drawing.Size(220, 21);
            this.field2Cbo.TabIndex = 13;
            this.field2Cbo.Enter += new System.EventHandler(this.field2Cbo_Enter);
            this.field2Cbo.Leave += new System.EventHandler(this.field2Cbo_Leave);
            // 
            // set2Btn
            // 
            this.set2Btn.Location = new System.Drawing.Point(184, 30);
            this.set2Btn.Name = "set2Btn";
            this.set2Btn.Size = new System.Drawing.Size(54, 23);
            this.set2Btn.TabIndex = 12;
            this.set2Btn.Text = "Set List";
            this.set2Btn.UseVisualStyleBackColor = true;
            this.set2Btn.Click += new System.EventHandler(this.set2Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Field List Filter:";
            // 
            // fFilter2Txt
            // 
            this.fFilter2Txt.Location = new System.Drawing.Point(95, 32);
            this.fFilter2Txt.Name = "fFilter2Txt";
            this.fFilter2Txt.Size = new System.Drawing.Size(83, 20);
            this.fFilter2Txt.TabIndex = 10;
            this.fFilter2Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fFilter2Txt_KeyPress);
            // 
            // vFilter1Txt
            // 
            this.vFilter1Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vFilter1Txt.Location = new System.Drawing.Point(549, 5);
            this.vFilter1Txt.Name = "vFilter1Txt";
            this.vFilter1Txt.Size = new System.Drawing.Size(135, 20);
            this.vFilter1Txt.TabIndex = 9;
            this.vFilter1Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vFilter1Txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selection filter:";
            // 
            // field1Cbo
            // 
            this.field1Cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.field1Cbo.FormattingEnabled = true;
            this.field1Cbo.Location = new System.Drawing.Point(244, 4);
            this.field1Cbo.Name = "field1Cbo";
            this.field1Cbo.Size = new System.Drawing.Size(220, 21);
            this.field1Cbo.TabIndex = 7;
            this.field1Cbo.Enter += new System.EventHandler(this.field1Cbo_Enter);
            this.field1Cbo.Leave += new System.EventHandler(this.field1Cbo_Leave);
            // 
            // set1Btn
            // 
            this.set1Btn.Location = new System.Drawing.Point(184, 3);
            this.set1Btn.Name = "set1Btn";
            this.set1Btn.Size = new System.Drawing.Size(54, 23);
            this.set1Btn.TabIndex = 6;
            this.set1Btn.Text = "Set List";
            this.set1Btn.UseVisualStyleBackColor = true;
            this.set1Btn.Click += new System.EventHandler(this.set1Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Field List Filter:";
            // 
            // fFilter1Txt
            // 
            this.fFilter1Txt.Location = new System.Drawing.Point(95, 4);
            this.fFilter1Txt.Name = "fFilter1Txt";
            this.fFilter1Txt.Size = new System.Drawing.Size(83, 20);
            this.fFilter1Txt.TabIndex = 4;
            this.fFilter1Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fFilter1Txt_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.displayBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.filterTxt);
            this.tabPage1.Controls.Add(this.valueLtv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1121, 690);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Metadata Field/Value List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(244, 1);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(56, 23);
            this.displayBtn.TabIndex = 3;
            this.displayBtn.Text = "Set List";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Field List Filter:";
            // 
            // filterTxt
            // 
            this.filterTxt.Location = new System.Drawing.Point(93, 3);
            this.filterTxt.Name = "filterTxt";
            this.filterTxt.Size = new System.Drawing.Size(145, 20);
            this.filterTxt.TabIndex = 1;
            this.filterTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterTxt_KeyPress);
            // 
            // valueLtv
            // 
            this.valueLtv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueLtv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.valueLtv.Location = new System.Drawing.Point(12, 29);
            this.valueLtv.Name = "valueLtv";
            this.valueLtv.Size = new System.Drawing.Size(1093, 655);
            this.valueLtv.TabIndex = 0;
            this.valueLtv.UseCompatibleStateImageBehavior = false;
            this.valueLtv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Field Name";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value List";
            this.columnHeader2.Width = 7110;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(1066, 734);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // myTimer1
            // 
            this.myTimer1.Interval = 1500;
            this.myTimer1.Tick += new System.EventHandler(this.myTimer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 758);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department of Conservation - Metadata Search";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterTxt;
        private System.Windows.Forms.ListView valueLtv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListBox fileLst;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox vFilter2Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox field2Cbo;
        private System.Windows.Forms.Button set2Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fFilter2Txt;
        private System.Windows.Forms.TextBox vFilter1Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox field1Cbo;
        private System.Windows.Forms.Button set1Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fFilter1Txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton orRdi;
        private System.Windows.Forms.RadioButton andRdi;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Timer myTimer1;
        private System.Windows.Forms.ToolTip myToolTip1;
    }
}