namespace SwimFlow
{
    partial class MemberForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AppendBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.mem_rrn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mem_phone = new System.Windows.Forms.TextBox();
            this.mem_add = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mem_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mem_name = new System.Windows.Forms.TextBox();
            this.mem_date = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memcnt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(44, 123);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(833, 416);
            this.DBGrid.TabIndex = 61;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UpdateBtn);
            this.groupBox1.Controls.Add(this.AppendBtn);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.mem_rrn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mem_phone);
            this.groupBox1.Controls.Add(this.mem_add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mem_id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mem_name);
            this.groupBox1.Controls.Add(this.mem_date);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.phoneLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(895, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 499);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "정보 수정";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(39, 406);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(236, 38);
            this.UpdateBtn.TabIndex = 20;
            this.UpdateBtn.Text = "수정";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AppendBtn
            // 
            this.AppendBtn.Location = new System.Drawing.Point(36, 360);
            this.AppendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AppendBtn.Name = "AppendBtn";
            this.AppendBtn.Size = new System.Drawing.Size(120, 38);
            this.AppendBtn.TabIndex = 19;
            this.AppendBtn.Text = "추가";
            this.AppendBtn.Click += new System.EventHandler(this.AppendBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(162, 360);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(112, 38);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "삭제";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // mem_rrn
            // 
            this.mem_rrn.Location = new System.Drawing.Point(129, 278);
            this.mem_rrn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mem_rrn.Name = "mem_rrn";
            this.mem_rrn.Size = new System.Drawing.Size(146, 25);
            this.mem_rrn.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10F);
            this.label7.Location = new System.Drawing.Point(7, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "주민등록번호";
            // 
            // mem_phone
            // 
            this.mem_phone.Location = new System.Drawing.Point(129, 234);
            this.mem_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mem_phone.Name = "mem_phone";
            this.mem_phone.Size = new System.Drawing.Size(146, 25);
            this.mem_phone.TabIndex = 17;
            // 
            // mem_add
            // 
            this.mem_add.Location = new System.Drawing.Point(128, 188);
            this.mem_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mem_add.Name = "mem_add";
            this.mem_add.Size = new System.Drawing.Size(146, 25);
            this.mem_add.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(31, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "주소";
            // 
            // mem_id
            // 
            this.mem_id.Location = new System.Drawing.Point(128, 147);
            this.mem_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mem_id.Name = "mem_id";
            this.mem_id.Size = new System.Drawing.Size(146, 25);
            this.mem_id.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(31, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "가입날짜";
            // 
            // mem_name
            // 
            this.mem_name.Location = new System.Drawing.Point(128, 100);
            this.mem_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mem_name.Name = "mem_name";
            this.mem_name.Size = new System.Drawing.Size(146, 25);
            this.mem_name.TabIndex = 16;
            // 
            // mem_date
            // 
            this.mem_date.Location = new System.Drawing.Point(128, 51);
            this.mem_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mem_date.Name = "mem_date";
            this.mem_date.Size = new System.Drawing.Size(146, 25);
            this.mem_date.TabIndex = 28;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("굴림", 10F);
            this.nameLabel.Location = new System.Drawing.Point(31, 101);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 17);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "회원명";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("굴림", 10F);
            this.phoneLabel.Location = new System.Drawing.Point(28, 234);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(76, 17);
            this.phoneLabel.TabIndex = 14;
            this.phoneLabel.Text = "전화번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(31, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "회원코드";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(377, 19);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 25);
            this.SearchBtn.TabIndex = 65;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(143, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 25);
            this.txtSearch.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "회원명 입력";
            // 
            // memcnt
            // 
            this.memcnt.AutoSize = true;
            this.memcnt.Location = new System.Drawing.Point(811, 94);
            this.memcnt.Name = "memcnt";
            this.memcnt.Size = new System.Drawing.Size(66, 15);
            this.memcnt.TabIndex = 66;
            this.memcnt.Text = "총 000명";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.SearchBtn);
            this.groupBox2.Location = new System.Drawing.Point(44, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 52);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색";
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1231, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.memcnt);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원관리";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AppendBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox mem_rrn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mem_phone;
        private System.Windows.Forms.TextBox mem_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mem_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mem_name;
        private System.Windows.Forms.TextBox mem_date;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label memcnt;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}