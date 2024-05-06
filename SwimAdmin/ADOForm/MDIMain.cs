using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimFlow
{
    public partial class MDIMain : Form
    {
        public MDIMain()
        {
            InitializeComponent();
        }

        //시작 폼 
        StartForm StartForm;
        //수강신청 폼
        registerform registerform;
        //강사 관리 폼 
        EmpForm EmpForm;
        //회원관리
        MemberForm memberform;
        //강습관리 
        ClassForm classform;

        //
        private void MDIMain_Load(object sender, EventArgs e)
        {
            StartForm StartForm = new StartForm();
            StartForm.MdiParent = this;
            StartForm.Show();

        }

        //< menustrip >
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //정보 
        private void 정보확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infForm = new InfoForm();
            infForm.Owner = this;
            infForm.ShowDialog();
            infForm.Dispose();
        }
        //종료
        private void 종료ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //관리 - 수강신청
        private void 수강신청ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            registerform registerform = new registerform();
            registerform.MdiParent = this;
            registerform.Show();
        }
        //관리 - 회원관리 페이지 이동
        private void 회원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberForm memberform = new MemberForm();
            memberform.MdiParent = this;
            memberform.Show();
        }
        //관리 - 강사관리 페이지 이동
        private void 강사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpForm EmpForm = new EmpForm();
            EmpForm.MdiParent = this;
            EmpForm.Show();
        }
        //관리 - 강습관리 페이지 이동
        private void 강습관리페이지이동ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassForm ClassForm = new ClassForm();
            ClassForm.MdiParent = this;
            ClassForm.Show();
        }
    }
}
