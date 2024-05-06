
namespace SwimFlow
{
    partial class MDIMain
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
            this.수강신청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수강신청ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.회원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.강사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.강습관리페이지이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수강신청ToolStripMenuItem,
            this.정보확인ToolStripMenuItem,
            this.종료ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 수강신청ToolStripMenuItem
            // 
            this.수강신청ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수강신청ToolStripMenuItem1,
            this.회원ToolStripMenuItem,
            this.강사ToolStripMenuItem,
            this.강습관리페이지이동ToolStripMenuItem});
            this.수강신청ToolStripMenuItem.Name = "수강신청ToolStripMenuItem";
            this.수강신청ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.수강신청ToolStripMenuItem.Text = "관리";
            // 
            // 수강신청ToolStripMenuItem1
            // 
            this.수강신청ToolStripMenuItem1.Name = "수강신청ToolStripMenuItem1";
            this.수강신청ToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.수강신청ToolStripMenuItem1.Text = "수강신청";
            this.수강신청ToolStripMenuItem1.Click += new System.EventHandler(this.수강신청ToolStripMenuItem1_Click);
            // 
            // 회원ToolStripMenuItem
            // 
            this.회원ToolStripMenuItem.Name = "회원ToolStripMenuItem";
            this.회원ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.회원ToolStripMenuItem.Text = "회원 관리 페이지 이동";
            this.회원ToolStripMenuItem.Click += new System.EventHandler(this.회원ToolStripMenuItem_Click);
            // 
            // 강사ToolStripMenuItem
            // 
            this.강사ToolStripMenuItem.Name = "강사ToolStripMenuItem";
            this.강사ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.강사ToolStripMenuItem.Text = "강사 관리 페이지 이동";
            this.강사ToolStripMenuItem.Click += new System.EventHandler(this.강사ToolStripMenuItem_Click);
            // 
            // 정보확인ToolStripMenuItem
            // 
            this.정보확인ToolStripMenuItem.Name = "정보확인ToolStripMenuItem";
            this.정보확인ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.정보확인ToolStripMenuItem.Text = "정보";
            this.정보확인ToolStripMenuItem.Click += new System.EventHandler(this.정보확인ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem1
            // 
            this.종료ToolStripMenuItem1.Name = "종료ToolStripMenuItem1";
            this.종료ToolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.종료ToolStripMenuItem1.Text = "종료";
            this.종료ToolStripMenuItem1.Click += new System.EventHandler(this.종료ToolStripMenuItem1_Click);
            // 
            // 강습관리페이지이동ToolStripMenuItem
            // 
            this.강습관리페이지이동ToolStripMenuItem.Name = "강습관리페이지이동ToolStripMenuItem";
            this.강습관리페이지이동ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.강습관리페이지이동ToolStripMenuItem.Text = "강습 관리 페이지 이동";
            this.강습관리페이지이동ToolStripMenuItem.Click += new System.EventHandler(this.강습관리페이지이동ToolStripMenuItem_Click);
            // 
            // MDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "MDIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "노원구민체육센터 관리 프로그램";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 정보확인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 수강신청ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수강신청ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 회원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 강사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 강습관리페이지이동ToolStripMenuItem;
    }
}