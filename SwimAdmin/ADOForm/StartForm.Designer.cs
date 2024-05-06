
namespace SwimFlow
{
    partial class StartForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.나가기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.강습관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.강사관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("굴림", 15F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(156, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "수강 신청";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("굴림", 15F);
            this.button3.Location = new System.Drawing.Point(156, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(800, 95);
            this.button3.TabIndex = 2;
            this.button3.Text = "강습 관리";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(313, 50);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.label1.Size = new System.Drawing.Size(515, 87);
            this.label1.TabIndex = 3;
            this.label1.Text = "노원구민체육센터\r\n(수영장 강습 관리 시스템)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.나가기ToolStripMenuItem,
            this.강습관리ToolStripMenuItem,
            this.강사관리ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 100);
            // 
            // 나가기ToolStripMenuItem
            // 
            this.나가기ToolStripMenuItem.Name = "나가기ToolStripMenuItem";
            this.나가기ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.나가기ToolStripMenuItem.Text = "회원 관리";
            // 
            // 강습관리ToolStripMenuItem
            // 
            this.강습관리ToolStripMenuItem.Name = "강습관리ToolStripMenuItem";
            this.강습관리ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.강습관리ToolStripMenuItem.Text = "강습 관리";
            // 
            // 강사관리ToolStripMenuItem
            // 
            this.강사관리ToolStripMenuItem.Name = "강사관리ToolStripMenuItem";
            this.강사관리ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.강사관리ToolStripMenuItem.Text = "강사 관리";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(1512, 18);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(37, 15);
            this.time.TabIndex = 6;
            this.time.Text = "Time";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("굴림", 15F);
            this.button5.Location = new System.Drawing.Point(156, 509);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(800, 95);
            this.button5.TabIndex = 9;
            this.button5.Text = "회원 정보 수정";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("굴림", 15F);
            this.button2.Location = new System.Drawing.Point(156, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(800, 95);
            this.button2.TabIndex = 1;
            this.button2.Text = "강사 관리";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1112, 668);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "노원구민체육센터 관리 프로그램";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 나가기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 강습관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 강사관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}