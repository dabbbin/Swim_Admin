using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace SwimFlow
{
    public partial class AdminForm : Form
    {
        DBClass dbc = new DBClass();
        public AdminForm()
        {
            InitializeComponent();
        }

        //확인 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            string adminId = id.Text;
            string adminPasssword = password.Text;

            try
            {
                if (id.Text == "")
                {
                    MessageBox.Show("관리자 ID를 입력해주세요!");
                    return;
                }
                if (password.Text == "")
                {
                    MessageBox.Show("관리자 비밀번호를 입력해주세요!");
                    return;
                }
                if (adminId.Equals("admin") && adminPasssword.Equals("1111") ) {
                    MessageBox.Show("관리자 계정에 접속이 되었습니다.");
                    DialogResult = System.Windows.Forms.DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("관리자 계정에 접속에 실패했습니다."); 
                }
                //int seq = dbc.GetSequenceValue("MANAGER_SEQ");
                //string adminid = id.Text;
                //string adminpasswd = password.Text;

                //string strConn = "User Id=swim; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                //OracleConnection conn = new OracleConnection(strConn);
                //conn.Open();
                //OracleCommand cmd = new OracleCommand();
                //cmd.Connection = conn;
                //cmd.CommandText = $"INSERT INTO admininfo(adminid,adminpasswd,adminregdate,adminposition,adminexdate) VALUES('{adminid}','{adminpasswd}','2022-11-11','관리자','2023-11-11') ";
                //cmd.ExecuteNonQuery();
                //conn.Close();
                //this.Close();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        //취소 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


    }
}
