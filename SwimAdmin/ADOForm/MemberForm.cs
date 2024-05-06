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
    public partial class MemberForm : Form
    {
        DBClass dbc = new DBClass(); //*****DBClass 객체 생성

        public MemberForm()
        {
            InitializeComponent();
        }
        public void member_counter()
        {
            int i;
            i = DBGrid.RowCount;
            memcnt.Text = "총 " + (i - 1) + " 명";
        }
        private void ClearTextBoxes()
        {
            mem_date.Clear();
            mem_name.Clear();
            mem_id.Clear();
            mem_add.Clear();
            mem_phone.Clear();
            mem_rrn.Clear();
        }
        public void member_header()
        {
            DBGrid.Columns[0].HeaderText = "가입날짜";
            DBGrid.Columns[1].HeaderText = "회원명";
            DBGrid.Columns[2].HeaderText = "회원코드"; 
            DBGrid.Columns[3].HeaderText = "주소";
            DBGrid.Columns[4].HeaderText = "연락처";
            DBGrid.Columns[5].HeaderText = "주민등록번호";

            DBGrid.Columns[0].Width = 130;
            DBGrid.Columns[1].Width = 100;
            DBGrid.Columns[2].Width = 100;
            DBGrid.Columns[3].Width = 130;
            DBGrid.Columns[4].Width = 130;
            DBGrid.Columns[5].Width = 130;

        }
        //불러오기
        private void MemberForm_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DS.Clear();

                dbc.DBAdapter.Fill(dbc.DS, "member");
                DBGrid.DataSource = dbc.DS.Tables["member"].DefaultView;//멤버뿌리기

                //
                member_counter();
                member_header();
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
                dbc.DB_Open_member();//*****
                dbc.DS.Clear();

                dbc.DBAdapter.Fill(dbc.DS, "member");

                DataTable memberTable = dbc.DS.Tables["member"];
                if (e.RowIndex < 0)
                {
                    // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메시지도 띄우지 않습니다.
                    return;
                }
                else if (e.RowIndex > memberTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = memberTable.Rows[e.RowIndex];
                mem_date.Text = currRow["mem_date"].ToString();
                mem_name.Text = currRow["mem_name"].ToString();
                mem_id.Text = currRow["mem_id"].ToString();
                mem_add.Text = currRow["mem_add"].ToString();
                mem_phone.Text = currRow["mem_phone"].ToString();
                mem_rrn.Text = currRow["mem_rrn"].ToString();


                dbc.SelectedRowIndex = Convert.ToInt32(currRow["mem_id"]);
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

        //< 정보 수정>
        //추가
        private void AppendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("텍스트 상자에 모든 데이터 입력 하셨으면 추가합니다!");

                dbc.MemberTable = dbc.DS.Tables["member"];//*
                DataRow newRow = dbc.MemberTable.NewRow();

                newRow["mem_date"] = mem_date.Text;
                newRow["mem_name"] = mem_name.Text;
                newRow["mem_id"] = mem_id.Text;
                newRow["mem_add"] = mem_add.Text;
                newRow["mem_phone"] = mem_phone.Text;
                newRow["mem_rrn"] = mem_rrn.Text;

                dbc.MemberTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "member");

                dbc.DS.AcceptChanges();//*
                ClearTextBoxes(); //*
                DBGrid.DataSource = dbc.DS.Tables["member"].DefaultView;
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
        //수정
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.MemberTable = dbc.DS.Tables["member"];//*

                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.MemberTable.Columns["mem_id"];
                dbc.MemberTable.PrimaryKey = PrimaryKey;

                DataRow currRow = dbc.MemberTable.Rows.Find(dbc.SelectedRowIndex);
                currRow.BeginEdit();
                currRow["mem_date"] = mem_date.Text;
                currRow["mem_name"] = mem_name.Text;
                currRow["mem_id"] = mem_id.Text;
                currRow["mem_add"] = mem_add.Text;
                currRow["mem_phone"] = mem_phone.Text;
                currRow["mem_rrn"] = mem_rrn.Text;

                currRow.EndEdit();
                DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    dbc.DBAdapter.Update(UpdatedSet, "member");
                    dbc.DS.AcceptChanges();
                }
                ClearTextBoxes();
                DBGrid.DataSource = dbc.DS.Tables["member"].DefaultView;
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
        //삭제
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.MemberTable = dbc.DS.Tables["member"];//*

                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.MemberTable.Columns["mem_id"];
                dbc.MemberTable.PrimaryKey = PrimaryKey;
                //
                if (MessageBox.Show("정말 삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    MessageBox.Show("취소했습니다.", "경고");
                }
                else
                {
                    //
                    DataRow currRow = dbc.MemberTable.Rows.Find(dbc.SelectedRowIndex);
                    currRow.Delete();

                    dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "member");
                    DBGrid.DataSource = dbc.DS.Tables["member"].DefaultView;
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
        //검색
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dbc.DB_ObjCreate();
            dbc.DB_Open_member();
            dbc.DS.Clear();
            dbc.DBAdapter.Fill(dbc.DS, "member");
            // radioButton3.Checked = true;

            // txtSearch에 입력된 수업 이름을 기반으로 DataTable에 필터 적용
            string filterExpression = $"mem_name like '%{txtSearch.Text}%'";
            dbc.DS.Tables["member"].DefaultView.RowFilter = filterExpression;
            // dataGridView1.DataSource = dbc.DS.Tables["searchclass"].DefaultView;
            // DataGridView의 DataSource를 필터링된 DataTable로 설정
            DBGrid.DataSource = dbc.DS.Tables["member"].DefaultView;

        }
    }
}
