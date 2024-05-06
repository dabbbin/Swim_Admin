
namespace SwimFlow
{
    partial class ClassForm
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
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.classcnt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AppendBtn = new System.Windows.Forms.Button();
            this.pool_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emp_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cl_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cl_limit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cl_usernum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cl_date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cl_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DownBtn = new System.Windows.Forms.Button();
            this.UpBtn = new System.Windows.Forms.Button();
            this.NameList = new System.Windows.Forms.ListBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(33, 241);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 27;
            this.DBGrid.Size = new System.Drawing.Size(866, 367);
            this.DBGrid.TabIndex = 0;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // classcnt
            // 
            this.classcnt.AutoSize = true;
            this.classcnt.Location = new System.Drawing.Point(803, 209);
            this.classcnt.Name = "classcnt";
            this.classcnt.Size = new System.Drawing.Size(96, 15);
            this.classcnt.TabIndex = 20;
            this.classcnt.Text = "총 000클래스";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.UpdateBtn);
            this.groupBox1.Controls.Add(this.AppendBtn);
            this.groupBox1.Controls.Add(this.pool_id);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.emp_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cl_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cl_limit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cl_usernum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cl_date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cl_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1204, 160);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "강습관리";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(1048, 108);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(126, 36);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "삭제";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(1048, 67);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(126, 36);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "수정";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AppendBtn
            // 
            this.AppendBtn.Location = new System.Drawing.Point(1048, 27);
            this.AppendBtn.Name = "AppendBtn";
            this.AppendBtn.Size = new System.Drawing.Size(126, 36);
            this.AppendBtn.TabIndex = 14;
            this.AppendBtn.Text = "추가";
            this.AppendBtn.UseVisualStyleBackColor = true;
            this.AppendBtn.Click += new System.EventHandler(this.AppendBtn_Click);
            // 
            // pool_id
            // 
            this.pool_id.Location = new System.Drawing.Point(575, 92);
            this.pool_id.Name = "pool_id";
            this.pool_id.Size = new System.Drawing.Size(132, 25);
            this.pool_id.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "수영장코드";
            // 
            // emp_id
            // 
            this.emp_id.Location = new System.Drawing.Point(323, 89);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(132, 25);
            this.emp_id.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "강사코드";
            // 
            // cl_id
            // 
            this.cl_id.Location = new System.Drawing.Point(93, 89);
            this.cl_id.Name = "cl_id";
            this.cl_id.Size = new System.Drawing.Size(132, 25);
            this.cl_id.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "강의코드";
            // 
            // cl_limit
            // 
            this.cl_limit.Location = new System.Drawing.Point(818, 42);
            this.cl_limit.Name = "cl_limit";
            this.cl_limit.Size = new System.Drawing.Size(132, 25);
            this.cl_limit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(751, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "제한인원";
            // 
            // cl_usernum
            // 
            this.cl_usernum.Location = new System.Drawing.Point(575, 39);
            this.cl_usernum.Name = "cl_usernum";
            this.cl_usernum.Size = new System.Drawing.Size(132, 25);
            this.cl_usernum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "수강인원";
            // 
            // cl_date
            // 
            this.cl_date.Location = new System.Drawing.Point(323, 39);
            this.cl_date.Name = "cl_date";
            this.cl_date.Size = new System.Drawing.Size(132, 25);
            this.cl_date.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "강의날짜";
            // 
            // cl_name
            // 
            this.cl_name.Location = new System.Drawing.Point(93, 39);
            this.cl_name.Name = "cl_name";
            this.cl_name.Size = new System.Drawing.Size(132, 25);
            this.cl_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "강의명";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DownBtn);
            this.groupBox3.Controls.Add(this.UpBtn);
            this.groupBox3.Controls.Add(this.NameList);
            this.groupBox3.Controls.Add(this.SearchBtn);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(936, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 399);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색";
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(165, 351);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(75, 38);
            this.DownBtn.TabIndex = 5;
            this.DownBtn.Text = "아래로";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(64, 350);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(75, 38);
            this.UpBtn.TabIndex = 4;
            this.UpBtn.Text = "위로";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // NameList
            // 
            this.NameList.FormattingEnabled = true;
            this.NameList.ItemHeight = 15;
            this.NameList.Location = new System.Drawing.Point(26, 107);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(254, 229);
            this.NameList.TabIndex = 3;
            this.NameList.SelectedIndexChanged += new System.EventHandler(this.NameList_SelectedIndexChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(205, 48);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 38);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(26, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(158, 25);
            this.txtSearch.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "강의명으로 검색";
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1268, 641);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.classcnt);
            this.Controls.Add(this.DBGrid);
            this.Name = "ClassForm";
            this.Text = "강습관리";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Label classcnt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AppendBtn;
        private System.Windows.Forms.TextBox pool_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emp_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cl_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cl_limit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cl_usernum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cl_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.ListBox NameList;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
    }
}