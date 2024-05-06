using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;//ADO.Net 개체 참조
using System.Data; //DataSet 개체 참조
using System.Windows.Forms; //MessageBox 개체 참조

namespace SwimFlow
{
    public class DBClass //DBClass 정의 시작
    {
        /**/
        private int selectedRowIndex;//수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다.
        private int selectedKeyValue; // 수정, 삭제할 때 필요한 레코드의 키값을 보관할 필드

        OracleDataAdapter dBAdapter; //Data Provider인 DBAdapter 입니다.
        DataSet dS;// DataSet 객체입니다.
        OracleCommandBuilder myCommandBuilder; // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체입니다.

        DataTable phoneTable;// DataTable 객체입니다.

        DataTable classTable;
        DataTable myclassTable;
        DataTable searchmyclassTable;
        DataTable empTable; //
        DataTable memberTable;



        /**/

        public int SelectedRowIndex { get { return selectedRowIndex; } set { selectedRowIndex = value; } }
        public int SelectedKeyValue { get { return selectedKeyValue; } set { selectedKeyValue = value; } }
        public OracleDataAdapter DBAdapter { get { return dBAdapter; } set { dBAdapter = value; } }
        public DataSet DS { get { return dS; } set { dS = value; } }
        public OracleCommandBuilder MyCommandBuilder { get { return myCommandBuilder; } set { myCommandBuilder = value; } }
        public DataTable PhoneTable { get { return phoneTable; } set { phoneTable = value; } }
        //
        public DataTable ClassTable { get { return classTable; } set { classTable = value; } }
        public DataTable MyclassTable { get { return myclassTable; } set { myclassTable = value; } }

        public DataTable SearchmyclassTable { get { return searchmyclassTable; } set { searchmyclassTable = value; } }
        public DataTable EmpTable { get { return empTable; } set { empTable = value; } }
        public DataTable MemberTable { get { return memberTable; } set { memberTable = value; } }



        //DB_Open
        public void DB_Open()
        {
            try
            {
                string connectionString = "User Id=swim; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = "select * from member";  //member
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        //DB_Open_Class
        public void DB_Open_class()
        {
            try
            {
                string connectionString = "User Id=swim; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = "select * from class";   //class
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        //DB_Open_myclass
        public void DB_Open_myclass()
        {
            try
            {
                string connectionString = "User Id=swim; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = "select m.mem_name, c.cl_name, my.mem_id, my.mycl_id,my.cl_id from member m, class c, myclass my WHERE m.mem_id = my.mem_id and my.cl_id=c.cl_id";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        //DB_Open_searchmyclass
        public void DB_Open_searchmyclass()
        {
            try
            {
                string connectionString = "User Id=swim; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = "select m.mem_id, c.cl_id, my.mycl_id " +
                                        "from member m, class c, myclass my " +
                                        "WHERE m.mem_id = my.mem_id AND m.mem_id = '{mem_id}'";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        //DB_Open_emp
        public void DB_Open_emp()
        {
            try
            {
                string connectionString = "User Id=swim; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = "select * from emp";  //emp
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }        
        //DB_Open_member
        public void DB_Open_member()
        {
            try
            {
                string connectionString = "User Id=swim; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = "select * from member";  //emp
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        //DB_ObjCreate
        public void DB_ObjCreate()
        {
            PhoneTable = new DataTable();
            ClassTable = new DataTable();
            MyclassTable = new DataTable();
            SearchmyclassTable = new DataTable();
            EmpTable = new DataTable();
            MemberTable = new DataTable();
        }


        //
        public int GetSequenceValue(string seq)
        {
            try
            {
                string connectionString = "User Id=swim; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
                OracleDataAdapter DBAdapter = new OracleDataAdapter("select " + seq + ".nextval as n from dual", connectionString);
                OracleCommandBuilder MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "admin");
                return int.Parse(DS.Tables["admin"].Rows[0]["n"].ToString());
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            return -1;
        }
    }//DBClass 정의 끝
}
