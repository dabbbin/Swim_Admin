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

namespace SwimFlow
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent(); 
        }
        
        registerform registerform;
        EmpForm EmpForm;
        ClassForm ClassForm;
        MemberForm MemberForm;

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }

        private void 인원ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
        //
        private void StartForm_Load(object sender, EventArgs e)
        {
            using (Font fnt = new Font(this.label1.Font.Name, 15))
            {
                this.time.Font = fnt;
            }

            AdminForm AdminForm = new AdminForm();
            DialogResult result = AdminForm.ShowDialog();

        }
        //수강신청 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            registerform registerform = new registerform();
            registerform.Owner = this;
            registerform.ShowDialog();
            registerform.Dispose();
        }

        //강사관리 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            EmpForm EmpForm = new EmpForm();
            EmpForm.Owner = this;
            EmpForm.ShowDialog();
            EmpForm.Dispose();
        }
        //강습관리 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            ClassForm ClassForm = new ClassForm();
            ClassForm.Owner = this;
            ClassForm.ShowDialog();
            ClassForm.Dispose();
        }
        //회원관리 버튼
        private void button5_Click(object sender, EventArgs e)
        {
            MemberForm MemberForm = new MemberForm();
            MemberForm.Owner = this;
            MemberForm.ShowDialog();
            MemberForm.Dispose();
        }
    }
}
