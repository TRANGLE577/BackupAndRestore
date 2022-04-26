using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BackupAndRestoreSQL
{
    static class Program
    {
        
        public static SqlConnection conn = new SqlConnection();
        public static String connStr;
        public static SqlDataReader myReader;
        public static String servername = "";
        public  static String username = "";
        public static String login = "";
        public static String password = "";

        public static String URL = "D:/PTIT/ChuyenDeCNPM/BACKUP/TIME";
        public static String URLDevice = "D:/PTIT/ChuyenDeCNPM/BACKUP/DEVICE/";
        public static String database = "TN_CSDLPT";
        public static FormLogin fmLogin;
        public static FormMain fmMain;

        public static int ketNoiDB()
        {
            if(Program.conn !=null && Program.conn.State == System.Data.ConnectionState.Open)
            {
                Program.conn.Close();

            }
            try
            {
                Program.connStr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" + Program.login + ";Password=" + Program.password;
                Program.conn.ConnectionString = Program.connStr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(Program.connStr);
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu." + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; // Đợi lệnh chạy. đơn vị: giây.
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static int ExecSqlNonQuery(String lenh, String connect, string error)
        {
            conn = new SqlConnection(connect);
            SqlCommand Sqlcmd = new SqlCommand(lenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600; //10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int loi = Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                {
                    MessageBox.Show("Format lại các cột kiểu char qua int");
                }
                else
                {
                    MessageBox.Show(error + "\n" + ex.Message);
                }
                conn.Close();
                return (ex.State);// trạng thái lỗi gửi từ RAISERROR trong sql server qua
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fmLogin = new FormLogin();
            fmMain = new FormMain();
            Application.Run(fmLogin);
        }
    }
}
