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
    public partial class UserclassSearch : Form
    {

        new registerform Parent;
        //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다.
        private int SelectedRowIndex;
        // Data Provider인 DBAdapter 입니다.
        OracleDataAdapter DBAdapter;
        // DataSet 객체입니다.
        DataSet DS;
        // 추가, 수정, 삭제시에 필요한 명령문을 
        // 자동으로 작성해주는 객체입니다.
        OracleCommandBuilder myCommandBuilder;
        // ataTable 객체입니다.
        DataTable myclassTable;
        // 수정, 삭제할 때 필요한 레코드의 키값을 보관할 필드
        private int SelectedKeyValue;

        private void ClearTextBoxes()
        {
            txtid.Clear();
            txtName.Clear();
            txtPhone.Clear();
        }

        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=swim; Password=1111; Data Source=" +
            "(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)" +
            "(PORT = 1522))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = "select * from member m, class c, myclass my WHERE m.mem_id = my.mem_id and my.cl_id=c.cl_id";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
                DBAdapter.Fill(DS, "myclass"); // 데이터 가져오기

            }
           //"select my.mycl_id, my.mem_id, m.mem_name, c.cl_name from member m, class c, myclass my WHERE m.mem_id = my.mem_id and my.cl_id=c.cl_id";
           
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public UserclassSearch()
        {
            InitializeComponent();
            DB_Open();
        }

        private void NameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();
                DBAdapter.Fill(DS, "myclass"); // 데이터 다시 가져오기

                myclassTable = DS.Tables["myclass"];
                DataRow[] ResultRows = myclassTable.Select($"mem_name like '%{Parent.Txt}%'");

                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = myclassTable.Columns["mycl_id"];
                myclassTable.PrimaryKey = PrimaryKey;

                DataRow currRow = myclassTable.Rows.Find(NameList.Text.Substring(0, 2));

                if (currRow != null)
                {
                    SelectedKeyValue = Convert.ToInt32(currRow["mycl_id"].ToString());
                    textBox1.Text = currRow["mycl_id"].ToString();
                    txtid.Text = currRow["mem_id"].ToString();
                    txtName.Text = currRow["mem_name"].ToString();
                    txtPhone.Text = currRow["cl_name"].ToString();
                }
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void UserclassSearch_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label2.Visible = false;
            DS.Clear();
            DBAdapter.Fill(DS, "myclass");
            Parent = (registerform)Owner;
            myclassTable = DS.Tables["myclass"];
            DataRow[] ResultRows = myclassTable.Select("mem_name like '%" + Parent.Txt + "%'");
            NameList.Items.Clear();
            foreach (DataRow currRow in ResultRows)
            {
                NameList.Items.Add(currRow["mycl_id"].ToString() + " " + currRow["mem_id"].ToString() + " " + currRow["mem_name"].ToString() + " " + currRow["cl_name"].ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
   
}
