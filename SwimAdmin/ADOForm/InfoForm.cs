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
    public partial class InfoForm : Form
    {
        string sqlstr;    //쿼리문 저장 변수
        DataRow currRow;
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성

        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        public void information_display() 
        {

        }
    }
}
