using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace SwimFlow
{
    public partial class registerform : Form
    {

        private void ClearTextBoxes()
        {
            /*
            txtdate.Clear();
            txtName.Clear();
            txtid.Clear();
            txtadd.Clear();
            txtPhone.Clear();
            txtrrn.Clear();
            */
        }

        DBClass dbc = new DBClass(); //*****DBClass 객체 생성


        public registerform()
        {
            InitializeComponent();
            //  dbc.DB_ObjCreate(); //*****
            // dbc.DB_Open_class();//*****
        }
        public void member_header()
        {
            DBGrid.Columns[0].HeaderText = "가입날짜";
            DBGrid.Columns[1].HeaderText = "회원명";
            DBGrid.Columns[2].HeaderText = "회원코드";
            DBGrid.Columns[3].HeaderText = "주소";
            DBGrid.Columns[4].HeaderText = "연락처";
            DBGrid.Columns[5].HeaderText = "주민등록번호";

            DBGrid.Columns[0].Width = 110;
            DBGrid.Columns[1].Width = 100;
            DBGrid.Columns[2].Width = 90;
            DBGrid.Columns[3].Width = 120;
            DBGrid.Columns[4].Width = 120;
            DBGrid.Columns[5].Width = 120;

        }
        public void class_header()
        {
            dataGridView1.Columns[0].HeaderText = "강의명";
            dataGridView1.Columns[1].HeaderText = "강의날짜";
            dataGridView1.Columns[2].HeaderText = "수강인원";
            dataGridView1.Columns[3].HeaderText = "제한인원";
            dataGridView1.Columns[4].HeaderText = "강의코드";
            dataGridView1.Columns[5].HeaderText = "강사코드";
            dataGridView1.Columns[6].HeaderText = "수영장코드";

            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].Width = 120;

        }

        //불러오기
        private void registerform_Load(object sender, EventArgs e)
        {
            try
            {
                //textbox1.Visible = false;

                radioButton1.Checked = true;

                //== member ==
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DS.Clear();

                dbc.DBAdapter.Fill(dbc.DS, "member");
                //  phoneTable = DS.Tables["Phone"];//*
                DBGrid.DataSource = dbc.DS.Tables["member"].DefaultView;//멤버뿌리기

                //== class ==
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open_class();//*****
                dbc.DS.Clear();

                dbc.DBAdapter.Fill(dbc.DS, "class");
                //  phoneTable = DS.Tables["Phone"];//*
                dataGridView1.DataSource = dbc.DS.Tables["class"].DefaultView;//클래스뿌리기

                //
                member_header();
                //class_header();


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
        /*
        private void AppendBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                MessageBox.Show("텍스트 상자에 모든 데이터 입력 하셨으면 추가합니다!");
                // DS.Clear();//*
                // DBAdapter.Fill(DS, "Phone");//*
                dbc.PhoneTable = dbc.DS.Tables["member"];//*
                DataRow newRow = dbc.PhoneTable.NewRow();
                newRow["mem_date"] = txtdate.Text;
                newRow["mem_id"] = txtid.Text;
                newRow["mem_add"] = txtadd.Text;
                newRow["mem_name"] = txtName.Text;
                newRow["mem_phone"] = txtPhone.Text;
                newRow["mem_rrn"] = txtrrn.Text;
                dbc.PhoneTable.Rows.Add(newRow);
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
        }*/
        //수정버튼
        /*
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                //DS.Clear(); 
                //DBAdapter.Fill(DS, "Phone");
                dbc.PhoneTable = dbc.DS.Tables["member"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.PhoneTable.Columns["mem_id"];
                dbc.PhoneTable.PrimaryKey = PrimaryKey;
                DataRow currRow = dbc.PhoneTable.Rows.Find(dbc.SelectedRowIndex);
                currRow.BeginEdit();
                currRow["mem_date"] = txtdate.Text;
                currRow["mem_add"] = txtadd.Text;
                currRow["mem_id"] = txtid.Text;
                currRow["mem_name"] = txtName.Text;
                currRow["mem_phone"] = txtPhone.Text;
                currRow["mem_rrn"] = txtrrn.Text;

                // currRow["mem_id"] = textBox2.Text;

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
        */
        //삭제버튼
        /*
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                // DS.Clear();
                // DBAdapter.Fill(DS, "Phone");
                dbc.PhoneTable = dbc.DS.Tables["member"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.PhoneTable.Columns["mem_id"];
                dbc.PhoneTable.PrimaryKey = PrimaryKey;
                DataRow currRow = dbc.PhoneTable.Rows.Find(dbc.SelectedRowIndex);
                currRow.Delete();
                dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted),
               "member");
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
        */
        //회원으로 검색버튼
        /*
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            MemberForm frm2 = new MemberForm();
            frm2.Owner = this;
            frm2.ShowDialog();
            frm2.Dispose();
        }
        */

        //왼쪽DB
        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //오른쪽DB
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DS.Clear();

                dbc.DBAdapter.Fill(dbc.DS, "member");
                //  phoneTable = DS.Tables["Phone"];//*
                DBGrid.DataSource = dbc.DS.Tables["member"].DefaultView;
                DataTable phoneTable = dbc.DS.Tables["member"];
                if (e.RowIndex < 0)
                {
                    // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메시지도 띄우지 않습니다. return;
                }
                else if (e.RowIndex > phoneTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = phoneTable.Rows[e.RowIndex];
                /*
                txtdate.Text = currRow["mem_date"].ToString();
                txtid.Text = currRow["mem_id"].ToString();
                txtadd.Text = currRow["mem_add"].ToString();
                txtName.Text = currRow["mem_name"].ToString();

                txtPhone.Text = currRow["mem_phone"].ToString();
                txtrrn.Text = currRow["mem_rrn"].ToString();
                */
                textBox2.Text = currRow["mem_id"].ToString();


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
        
        //dataGridView (오른쪽)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    // DataSet DS = new DataSet();//*
                    //DBAdapter.Fill(DS, "Phone");

                    dbc.DB_ObjCreate(); //*****
                    dbc.DB_Open_class();//*****
                    dbc.DS.Clear();

                    dbc.DBAdapter.Fill(dbc.DS, "class");
                    DataTable classTable = dbc.DS.Tables["class"];
                    if (e.RowIndex < 0)
                    {
                        // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                        // 아무 메시지도 띄우지 않습니다. return;
                    }
                    else if (e.RowIndex > classTable.Rows.Count - 1)
                    {
                        MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                        return;
                    }
                    DataRow currRow = classTable.Rows[e.RowIndex];
                    textBox5.Text = currRow["cl_id"].ToString();


                    dbc.SelectedRowIndex = Convert.ToInt32(currRow["cl_id"]);
                }
                if (radioButton2.Checked == true)
                {
                    // DataSet DS = new DataSet();//*
                    //DBAdapter.Fill(DS, "Phone");

                    dbc.DB_ObjCreate(); //*****
                    dbc.DB_Open_myclass();//*****
                    dbc.DS.Clear();

                    dbc.DBAdapter.Fill(dbc.DS, "myclass");
                    DataTable myclassTable = dbc.DS.Tables["myclass"];
                    if (e.RowIndex < 0)
                    {
                        // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                        // 아무 메시지도 띄우지 않습니다. return;
                    }
                    else if (e.RowIndex > myclassTable.Rows.Count - 1)
                    {
                        MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                        return;
                    }
                    DataRow currRow = myclassTable.Rows[e.RowIndex];
                    textbox1.Text = currRow["mycl_id"].ToString();
                    textBox5.Text = currRow["cl_id"].ToString();
                    textBox2.Text = currRow["cl_id"].ToString();


                    dbc.SelectedRowIndex = Convert.ToInt32(currRow["mycl_id"]);
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

        //< 수강신청기능(수강인원 체크 및 증가/ 중복체크) >
        //수강신청 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String mem_id = textBox2.Text;
                String cl_id = textBox5.Text;
                String mycl_id = textbox1.Text;

                // DS.Clear();//*
                // DBAdapter.Fill(DS, "Phone");//*
                dbc.DB_ObjCreate();
                dbc.DB_Open_myclass();
                dbc.DS.Clear();
                string strConn = "User Id=swim; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                string selectQuery = $"SELECT CL_USERNUM, CL_LIMIT FROM class WHERE cl_id = '{cl_id}'";

                int userNum = 0;
                int limit = 0;

                using (OracleCommand selectCommand = new OracleCommand(selectQuery, conn))
                {
                    // 다른 필요한 설정들 추가 (예: 트랜잭션, 연결 열기 등)

                    // 실행 및 결과 가져오기
                    using (OracleDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // CL_USERNUM과 CL_LIMIT 값을 가져오기
                            userNum = Convert.ToInt32(reader["CL_USERNUM"]);
                            limit = Convert.ToInt32(reader["CL_LIMIT"]);
                        }
                    }
                }

                Console.WriteLine("After checkQuery execution");
                string checkQuery = $"SELECT cl_id FROM myclass WHERE cl_id = '{cl_id}' AND mem_id = '{mem_id}'";

                using (OracleCommand checkCommand = new OracleCommand(checkQuery, conn))
                {
                    // 실행 및 결과 가져오기
                    using (OracleDataReader checkReader = checkCommand.ExecuteReader())
                    {
                        if (checkReader.Read())
                        {
                            // 이미 수강신청한 강의인 경우
                            MessageBox.Show("이미 수강신청한 강의입니다.");
                            return; // 메소드 종료
                        }
                    }
                }

                if (limit <= userNum)
                {
                    Console.WriteLine("수강인원이 초과되었습니다.");
                }
                else
                {


                    cmd.CommandText = $"INSERT INTO myclass (mycl_id, mem_id, cl_id) VALUES('{mycl_id}','{mem_id}','{cl_id}')";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("수강신청완료!");
                    userNum++; // 혹은 다른 증가 로직을 적용하실 수 있습니다.

                    // cl_usernum 값을 업데이트하는 UPDATE 쿼리 실행
                    string updateQuery = $"UPDATE class SET CL_USERNUM = {userNum} WHERE cl_id = '{cl_id}'";

                    using (OracleCommand updateCommand = new OracleCommand(updateQuery, conn))
                    {
                        // 다른 필요한 설정들 추가 (예: 트랜잭션, 연결 열기 등)

                        // 실행
                        updateCommand.ExecuteNonQuery();
                    }

                    conn.Close();
                }
            }         

            catch (OracleException ex)
            {
                if (ex.Number == 1) // 예상 가능한 오류 번호 (예: 중복된 키 제약 조건 위반)
                {
                    MessageBox.Show("수강번호를 다시 입력해주세요.");
                }
                else
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //수강취소기능
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                String mem_id = textBox2.Text;
                String cl_id = textBox5.Text;
                String mycl_id = textbox1.Text;

                // DS.Clear();//*
                // DBAdapter.Fill(DS, "Phone");//*
                dbc.DB_ObjCreate();
                dbc.DB_Open_myclass();
                dbc.DS.Clear();
                string strConn = "User Id=swim; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                //해당 강의의 수강인원 가져오는 쿼리문
                string selectQuery = $"SELECT CL_USERNUM FROM class WHERE cl_id = '{cl_id}'";

                int userNum = 0;

                using (OracleCommand selectCommand = new OracleCommand(selectQuery, conn))
                {
                    // 다른 필요한 설정들 추가 (예: 트랜잭션, 연결 열기 등)

                    // 실행 및 결과 가져오기
                    using (OracleDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // CL_USERNUM과 CL_LIMIT 값을 가져오기
                            userNum = Convert.ToInt32(reader["CL_USERNUM"]);//연산을 위해 int형 변환후 변수에 넣어줍니다
                           
                        }
                    }               

                //수강강의인지 확인하는 쿼리문
               
                bool classis = false;

                // string checkQuery = $"SELECT mycl_id FROM myclass WHERE cl_id = '{cl_id}' AND mem_id = '{mem_id}'";
                string checkQuery = $"SELECT mycl_id FROM myclass WHERE cl_id = '{cl_id}' AND mem_id = '{mem_id}'";

                using (OracleCommand checkCommand = new OracleCommand(checkQuery, conn))
                {
                    // 실행 및 결과 가져오기
                    using (OracleDataReader checkReader = checkCommand.ExecuteReader())
                    {
                        if (checkReader.Read())
                        {

                            classis = true;
                        }                          
                            if (classis = true)
                            {

                                cmd.CommandText = $"DELETE FROM myclass WHERE mycl_id = '{mycl_id}'";

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("수강취소완료!");
                                userNum--; //수강인원 감소

                                // cl_usernum 값을 업데이트하는 UPDATE 쿼리 실행
                                string updateQuery = $"UPDATE class SET CL_USERNUM = {userNum} WHERE cl_id = '{cl_id}'";

                                using (OracleCommand updateCommand = new OracleCommand(updateQuery, conn))
                                {
                                    // 다른 필요한 설정들 추가 (예: 트랜잭션, 연결 열기 등)

                                    // 실행
                                    updateCommand.ExecuteNonQuery();
                                }

                                conn.Close();
                                //
                                dbc.DB_ObjCreate();
                                dbc.DS.Clear();
                                dbc.DB_Open_myclass();
                                dbc.DBAdapter.Fill(dbc.DS, "myclass");
                                dataGridView1.DataSource = dbc.DS.Tables["myclass"].DefaultView;
                            }
                            else
                            {
                                MessageBox.Show("수강강의가 아닙니다입니다.");
                            }
                           
                        }
                    }
                }
              
            }
            catch (OracleException ex)
            {
                if (ex.Number == 2292) // Oracle error number for referential integrity constraint violation (DELETE statement conflicted with a reference constraint)
                {
                    MessageBox.Show("수강 취소에 실패했습니다. 다른 의존 관계로 인해 삭제할 수 없습니다.");
                }
                else
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //수강강의코드 textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //조회버튼
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {              
                if (radioButton2.Checked == true)
                {
                    dbc.DB_ObjCreate();
                    dbc.DS.Clear();
                    dbc.DB_Open_myclass();
                    dbc.DBAdapter.Fill(dbc.DS, "myclass");
                    dataGridView1.DataSource = dbc.DS.Tables["myclass"].DefaultView;
                }
                else if (radioButton1.Checked == true)
                {
                    //class_header(); //
                    dbc.DB_ObjCreate();
                    dbc.DS.Clear();
                    dbc.DB_Open_class();
                    dbc.DBAdapter.Fill(dbc.DS, "class");
                    
                    dataGridView1.DataSource = dbc.DS.Tables["class"].DefaultView;
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

     
        //회원의수강목록검색 textbox
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
       
        }

        //회원의수강목록검색 button
        private void button4_Click(object sender, EventArgs e)
        {
            UserclassSearch frm3 = new UserclassSearch();
            frm3.Owner = this;
            frm3.ShowDialog();
            frm3.Dispose();
        }
        public String Txt //속성 설정
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value.ToString(); }
        }

        //수강취소 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open_class();//*****
                dbc.DS.Clear();

                dbc.DBAdapter.Fill(dbc.DS, "class");
                //  phoneTable = DS.Tables["Phone"];//*
                dataGridView1.DataSource = dbc.DS.Tables["class"].DefaultView;
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

        //강의명으로 수업검색 버튼
        //수업명으로 검색하는 기능입니다. 해당 기능을 수행한 후 셀 콘택트시 디비의 cl_id가 다르게 찾아지는 오류가 발생합니다.
        private void button5_Click(object sender, EventArgs e)
        {
            dbc.DB_ObjCreate();
            dbc.DB_Open_class();
            dbc.DS.Clear();
            dbc.DBAdapter.Fill(dbc.DS, "class");
           // radioButton3.Checked = true;

            // textBox4에 입력된 수업 이름을 기반으로 DataTable에 필터 적용
             string filterExpression = $"cl_name like '%{textBox4.Text}%'";
             dbc.DS.Tables["class"].DefaultView.RowFilter = filterExpression;
           // dataGridView1.DataSource = dbc.DS.Tables["searchclass"].DefaultView;
            // DataGridView의 DataSource를 필터링된 DataTable로 설정
         dataGridView1.DataSource = dbc.DS.Tables["class"].DefaultView;
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void AppendBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
