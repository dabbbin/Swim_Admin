using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using Oracle.DataAccess.Client;

namespace SwimFlow
{
    public partial class EmpForm : Form
    {
        DBClass dbc = new DBClass(); //*****DBClass 객체 생성

        public EmpForm()
        {
            InitializeComponent();
        }

        public void emp_counter()
        {
            int i;
            i = DBGrid.RowCount;
            empcnt.Text = "총 " + (i-1) + " 명";
        }
        private void ClearTextBoxes()
        {
            emp_id.Clear();
            emp_name.Clear();
            emp_career.Clear();
        }

        //
        public void emp_header()
        {
            DBGrid.Columns[0].HeaderText = "강사코드";
            DBGrid.Columns[1].HeaderText = "강사명";
            DBGrid.Columns[2].HeaderText = "경력";

            DBGrid.Columns[0].Width = 150;
            DBGrid.Columns[1].Width = 150;
            DBGrid.Columns[2].Width = 150;

        }

        //불러오기
        private void EmpForm_Load(object sender, EventArgs e)
        {
            try
            {
                /* */
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open_emp();

                dbc.DS.Clear();

                dbc.DBAdapter.Fill(dbc.DS, "emp");
                DBGrid.DataSource = dbc.DS.Tables["emp"].DefaultView;

                //
                emp_counter();
                emp_header();
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

        //텍스트박스에 정보 가져오기
        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/**/
            try
            {
                
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open_emp();//*****
                dbc.DS.Clear();

                dbc.DBAdapter.Fill(dbc.DS, "emp");

                DataTable empTable = dbc.DS.Tables["emp"];
                if (e.RowIndex < 0)
                {
                    // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메시지도 띄우지 않습니다.
                    return;
                }
                else if (e.RowIndex > empTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = empTable.Rows[e.RowIndex];
                emp_id.Text = currRow["emp_id"].ToString();
                emp_name.Text = currRow["emp_name"].ToString();
                emp_career.Text = currRow["emp_career"].ToString();


                dbc.SelectedRowIndex = Convert.ToInt32(currRow["emp_id"]);
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
        //< 강사관리 >
        //조회버튼
        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
            /*
            dbc.DS.Clear();
            dbc.DBAdapter.Fill(dbc.DS, "emp");
            DBGrid.DataSource = dbc.DS.Tables["emp"].DefaultView;
            */
        }

        //추가버튼
        private void AppendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("텍스트 상자에 모든 데이터 입력 하셨으면 추가합니다!");

                dbc.EmpTable = dbc.DS.Tables["emp"];//*
                DataRow newRow = dbc.EmpTable.NewRow();

                newRow["emp_id"] = emp_id.Text;
                newRow["emp_name"] = emp_name.Text;
                newRow["emp_career"] = emp_career.Text;

                dbc.EmpTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "emp");

                dbc.DS.AcceptChanges();//*
                ClearTextBoxes(); //*
                DBGrid.DataSource = dbc.DS.Tables["emp"].DefaultView;
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
        //수정버튼
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.EmpTable = dbc.DS.Tables["emp"];//*

                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.EmpTable.Columns["emp_id"];
                dbc.EmpTable.PrimaryKey = PrimaryKey;
                
                DataRow currRow = dbc.EmpTable.Rows.Find(dbc.SelectedRowIndex);
                currRow.BeginEdit();
                currRow["emp_id"] = emp_id.Text;
                currRow["emp_name"] = emp_name.Text;
                currRow["emp_career"] = emp_career.Text;

                currRow.EndEdit();
                DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    dbc.DBAdapter.Update(UpdatedSet, "emp");
                    dbc.DS.AcceptChanges();
                }
                ClearTextBoxes();
                DBGrid.DataSource = dbc.DS.Tables["emp"].DefaultView;
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
        //삭제버튼
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.EmpTable = dbc.DS.Tables["emp"];//*

                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.EmpTable.Columns["emp_id"];
                dbc.EmpTable.PrimaryKey = PrimaryKey;
                //
                if (MessageBox.Show("정말 삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    MessageBox.Show("취소했습니다.", "경고");
                }
                else
                {
                    //
                    DataRow currRow = dbc.EmpTable.Rows.Find(dbc.SelectedRowIndex);
                    currRow.Delete();

                    dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "emp");
                    DBGrid.DataSource = dbc.DS.Tables["emp"].DefaultView;
                    //
                    MessageBox.Show("삭제했습니다.", "경고");   //
                    //
                    ClearTextBoxes();
                }
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
        //< 검색 >
        //검색버튼
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DBAdapter.Fill(dbc.DS, "emp");
            dbc.EmpTable = dbc.DS.Tables["emp"];
            
            DataRow[] ResultRows = dbc.EmpTable.Select("emp_name like '%" + txtSearch.Text + "%'");
            NameList.Items.Clear();
            foreach (DataRow currRow in ResultRows)
            {
                NameList.Items.Add(currRow["emp_id"].ToString() + " " + currRow["emp_name"].ToString());
            }
        }
        //검색 - NameList
        private void NameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DBAdapter.Fill(dbc.DS, "emp");
            dbc.EmpTable = dbc.DS.Tables["emp"];
            DataRow[] ResultRows = dbc.EmpTable.Select("emp_name like '%" + txtSearch.Text + "%'");
           
            DataColumn[] PrimaryKey = new DataColumn[1];
            PrimaryKey[0] = dbc.EmpTable.Columns["emp_id"];
            dbc.EmpTable.PrimaryKey = PrimaryKey;
            DataRow currRow = dbc.EmpTable.Rows.Find(NameList.Text.Substring(0, 2));//*

            dbc.SelectedKeyValue = Convert.ToInt32(currRow["emp_id"].ToString());
            emp_id.Text = currRow["emp_id"].ToString();
            emp_name.Text = currRow["emp_name"].ToString();
            emp_career.Text = currRow["emp_career"].ToString();
        }

        public String TxtS //속성 설정
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value.ToString(); }
        }

        //위로 버튼
        private void UpBtn_Click(object sender, EventArgs e)
        {
            if (NameList.SelectedIndex != 0)
            {
                NameList.SelectedIndex = NameList.SelectedIndex - 1;
            }
            else
            {
                MessageBox.Show("이곳은 레코드의 처음입니다.");
            }
        }
        //아래로 버튼
        private void DownBtn_Click(object sender, EventArgs e)
        {
            if (NameList.SelectedIndex != NameList.Items.Count -1)
            {
                NameList.SelectedIndex = NameList.SelectedIndex + 1;
            }
            else
            {
                MessageBox.Show("이곳은 레코드의 마지막입니다.");
            }
        }
    }
}
