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
    public partial class ClassForm : Form
    {
        //string classsql;    //쿼리문 저장 변수

        DBClass dbc = new DBClass(); //*****DBClass 객체 생성

        public ClassForm()
        {
            InitializeComponent();
        }

        public void class_counter()
        {
            int i;
            i = DBGrid.RowCount;
            classcnt.Text = "총 " + (i - 1) + " 클래스";
        }
        private void ClearTextBoxes()
        {
            cl_name.Clear();
            cl_date.Clear();
            cl_usernum.Clear();
            cl_limit.Clear();
            cl_id.Clear();
            emp_id.Clear();
            pool_id.Clear();
        }

        public void class_header()
        {
            DBGrid.Columns[0].HeaderText = "강의명";
            DBGrid.Columns[1].HeaderText = "강의날짜";
            DBGrid.Columns[2].HeaderText = "수강인원";
            DBGrid.Columns[3].HeaderText = "제한인원";
            DBGrid.Columns[4].HeaderText = "강의코드";
            DBGrid.Columns[5].HeaderText = "강사코드";
            DBGrid.Columns[6].HeaderText = "수영장코드";

            DBGrid.Columns[0].Width = 130;
            DBGrid.Columns[1].Width = 130;
            DBGrid.Columns[2].Width = 90;
            DBGrid.Columns[3].Width = 90;
            DBGrid.Columns[4].Width = 90;
            DBGrid.Columns[5].Width = 90;
            DBGrid.Columns[6].Width = 90;
        }


        //불러오기
        private void ClassForm_Load(object sender, EventArgs e)
        {
            try
            {
                /* */
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open_class();

                dbc.DS.Clear();

                dbc.DBAdapter.Fill(dbc.DS, "class");
                DBGrid.DataSource = dbc.DS.Tables["class"].DefaultView;

                //
                class_counter();
                class_header();
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
        {
            try
            {

                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open_class();//*****
                dbc.DS.Clear();

                dbc.DBAdapter.Fill(dbc.DS, "class");

                DataTable classTable = dbc.DS.Tables["class"];
                if (e.RowIndex < 0)
                {
                    // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메시지도 띄우지 않습니다.
                    return;
                }
                else if (e.RowIndex > classTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = classTable.Rows[e.RowIndex];
                cl_name.Text = currRow["cl_name"].ToString();
                cl_date.Text = currRow["cl_date"].ToString();
                cl_usernum.Text = currRow["cl_usernum"].ToString();
                cl_limit.Text = currRow["cl_limit"].ToString();
                cl_id.Text = currRow["cl_id"].ToString();
                emp_id.Text = currRow["emp_id"].ToString();
                pool_id.Text = currRow["pool_id"].ToString();

                dbc.SelectedRowIndex = Convert.ToInt32(currRow["cl_id"]);
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
        //추가버튼
        private void AppendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("텍스트 상자에 모든 데이터 입력 하셨으면 추가합니다!");

                dbc.ClassTable = dbc.DS.Tables["class"];//*
                DataRow newRow = dbc.ClassTable.NewRow();

                newRow["cl_name"] = cl_name.Text;
                newRow["cl_date"] = cl_date.Text;
                newRow["cl_usernum"] = cl_usernum.Text;
                newRow["cl_limit"] = cl_limit.Text;
                newRow["cl_id"] = cl_id.Text;
                newRow["emp_id"] = emp_id.Text;
                newRow["pool_id"] = pool_id.Text;

                dbc.ClassTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "class");

                dbc.DS.AcceptChanges();//*
                ClearTextBoxes(); //*
                DBGrid.DataSource = dbc.DS.Tables["class"].DefaultView;
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
                dbc.ClassTable = dbc.DS.Tables["class"];//*

                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.ClassTable.Columns["cl_id"];
                dbc.ClassTable.PrimaryKey = PrimaryKey;

                DataRow currRow = dbc.ClassTable.Rows.Find(dbc.SelectedRowIndex);
                currRow.BeginEdit();
                currRow["cl_name"] = cl_name.Text;
                currRow["cl_date"] = cl_date.Text;
                currRow["cl_usernum"] = cl_usernum.Text;
                currRow["cl_limit"] = cl_limit.Text;
                currRow["cl_id"] = cl_id.Text;
                currRow["emp_id"] = emp_id.Text;
                currRow["pool_id"] = pool_id.Text;

                currRow.EndEdit();
                DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    dbc.DBAdapter.Update(UpdatedSet, "class");
                    dbc.DS.AcceptChanges();
                }
                ClearTextBoxes();
                DBGrid.DataSource = dbc.DS.Tables["class"].DefaultView;
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
                dbc.ClassTable = dbc.DS.Tables["class"];//*

                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.ClassTable.Columns["cl_id"];
                dbc.ClassTable.PrimaryKey = PrimaryKey;
                //                     
                if(MessageBox.Show("정말 삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    MessageBox.Show("취소했습니다.", "경고");
                }
                else
                {
                    DataRow currRow = dbc.ClassTable.Rows.Find(dbc.SelectedRowIndex);
                    currRow.Delete();

                    dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "class");
                    DBGrid.DataSource = dbc.DS.Tables["class"].DefaultView;
                    //
                    MessageBox.Show("삭제했습니다.", "경고");   //
                    //
                    ClearTextBoxes();
                }
                //
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
        /*
        public void list_search(String Find, String Sort)  // 검색과 정렬에 해당하는 SQL 작성 
        {
            if (Find == "" && Sort == "")  //기본
            {
                classsql = "Select * From class";
                sql_execute(classsql, dbc.DS);
            }
            
            else if (Find == "" && Sort != "")  //정렬
            {
                if (Sort == "title")
                { classsql = "Select * From book ORDER BY b_title ASC"; }
                else if (Sort == "name")
                { classsql = "Select * From book ORDER BY b_name ASC"; }
                else if (Sort == "publishing")
                { classsql = "Select * From book ORDER BY b_publishing ASC"; }
                else if (Sort == "lent")
                { classsql = "Select * From book ORDER BY b_lent ASC"; }

                sql_execute(classsql, dbc.DS);
            }
            else if (Find != "")  //검색
            {
                if (RadioButton1.Checked)  //제목 검색 //강의명
                { classsql = "Select * From class Where cl_name Like '%" + Find + "%'"; }
                else if (RadioButton2.Checked)  //도서 코드 검색 //강사코드
                { classsql = "Select * From class Where emp_id = '" + Find + "'"; }

                sql_execute(classsql, dbc.DS);
                if (dbc.DS.Tables["class"].Rows.Count == 0)
                {
                    MessageBox.Show("해당 강의가 없습니다");
                    classsql = "Select * From class";
                    sql_execute(classsql, dbc.DS);
                }
            }
        }
        */
        //검색버튼
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DBAdapter.Fill(dbc.DS, "class");
            dbc.ClassTable = dbc.DS.Tables["class"];

            DataRow[] ResultRows = dbc.ClassTable.Select("cl_name like '%" + txtSearch.Text + "%'");
            NameList.Items.Clear();
            foreach (DataRow currRow in ResultRows)
            {
                NameList.Items.Add(currRow["cl_id"].ToString() + " " + currRow["cl_name"].ToString());
            }
        }
        //검색 - NameList
        private void NameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbc.DS.Clear();
            dbc.DBAdapter.Fill(dbc.DS, "class");
            dbc.ClassTable = dbc.DS.Tables["class"];
            DataRow[] ResultRows = dbc.ClassTable.Select("cl_name like '%" + txtSearch.Text + "%'");

            DataColumn[] PrimaryKey = new DataColumn[1];
            PrimaryKey[0] = dbc.ClassTable.Columns["cl_id"];
            dbc.ClassTable.PrimaryKey = PrimaryKey;
            DataRow currRow = dbc.ClassTable.Rows.Find(NameList.Text.Substring(0, 2));//*

            dbc.SelectedKeyValue = Convert.ToInt32(currRow["cl_id"].ToString());
            cl_name.Text = currRow["cl_name"].ToString();
            cl_date.Text = currRow["cl_date"].ToString();
            cl_usernum.Text = currRow["cl_usernum"].ToString();
            cl_limit.Text = currRow["cl_limit"].ToString();
            cl_id.Text = currRow["cl_id"].ToString();
            emp_id.Text = currRow["emp_id"].ToString();
            pool_id.Text = currRow["pool_id"].ToString();

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
            if (NameList.SelectedIndex != NameList.Items.Count - 1)
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
