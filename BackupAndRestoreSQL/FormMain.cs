using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupAndRestoreSQL
{
    public partial class FormMain : Form
    {
        int listBackup = 0;
        String nameDevice = "";
        int listBackupLastest = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.list_BackupTableAdapter.Fill(this.databasesDataSet.List_Backup,Program.database);
            // TODO: This line of code loads data into the 'databasesDataSet.databases' table. You can move, or remove it, as needed.
            this.databasesTableAdapter.Connection.ConnectionString = Program.connStr;
            this.databasesTableAdapter.Fill(this.databasesDataSet.databases);
            Program.database = ((DataRowView)this.databasesBindingSource.Current).Row["name"].ToString();
            this.list_BackupTableAdapter.Connection.ConnectionString = Program.connStr;
            this.list_BackupTableAdapter.Fill(this.databasesDataSet.List_Backup,Program.database);

            databasesBindingSource.Position = 0;
            databasesGridControl_Click(sender, e);
            panelCheckRestore.Hide();
            timeRestore.Time = DateTime.Now;
            dateRestore.DateTime = DateTime.Now.Date;

            
            
        }
        private void LoadListBackup()
        {
            if (tbxNameDatabase.Text.Trim() == "") return;
            try
            {
                this.list_BackupTableAdapter.Connection.ConnectionString = Program.connStr;
                this.list_BackupTableAdapter.Fill(this.databasesDataSet.List_Backup, tbxNameDatabase.Text.Trim());
                if (list_BackupBindingSource.Count == 0)
                {
                    listBackup = 0;
                }
                else
                {
                    listBackup = int.Parse(((DataRowView)list_BackupBindingSource[0])["position"].ToString());

                }
                tbxRowListBackup.Text = listBackup.ToString();
                CheckCountDevive();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "Error in function load list backup");
            }
        }
        private void CheckCountDevive()
        {
            String sql = "SELECT COUNT(name) FROM sys.backup_devices WHERE name= N'DEVICE_" + tbxNameDatabase.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            // có device thì ẩn btn tạo device
            if (Program.myReader.GetInt32(0) > 0)
            {
                if (listBackup == 0)
                {
                    btnRestore.Enabled = cbRestoreTime.Enabled = false;
                }

                else
                {
                    btnRestore.Enabled = cbRestoreTime.Enabled = true;
                }
                btnBackup.Enabled = true;
                btnDevice.Enabled = false;
                nameDevice = "DEVICE_" + tbxNameDatabase.Text.Trim();
            }
            // chưa có device
            else
            {
                btnBackup.Enabled = btnRestore.Enabled = cbRestoreTime.Enabled = false;
                btnDevice.Enabled = true;
            }
            Program.myReader.Close();
        }
        public int CreateDevice(String nameDb)
        {
            String createDevice = "EXEC sp_addumpdevice 'disk', 'DEVICE_" + nameDb.Trim() + "','" + Program.URLDevice.Trim() +"DEVICE_"+nameDb.Trim()+ ".bak' ";
            int kiemtra = Program.ExecSqlNonQuery(createDevice, Program.connStr, "Lỗi tạo device");
            if (kiemtra != 0)
            {
                MessageBox.Show("Lỗi khi tạo mới Device");
                return 0;
            }
            else { return 1; }
        }

        




        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nameDevice.Trim() == "" || tbxNameDatabase.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (cbDeleteBackupOld.Checked == true)
                {
                    DialogResult mess = MessageBox.Show("Bạn muốn sao lưu ghi đè lên file cũ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mess == DialogResult.Yes)
                    {
                        String delDevice = "EXEC sp_dropdevice 'DEVICE_" + tbxNameDatabase.Text.Trim() + "', 'delfile'";
                        int check = Program.ExecSqlNonQuery(delDevice, Program.connStr, "");
                        if (check != 0)
                        {
                            MessageBox.Show("Lỗi xóa Device sao lưu!");
                            return;
                        }
                        int tmp = CreateDevice(tbxNameDatabase.Text.Trim());
                        if (tmp == 0)
                        {
                            MessageBox.Show("Lỗi sao lưu");
                            return;
                        }
                        nameDevice = "DEVICE_" + tbxNameDatabase.Text.Trim();
                        String cmd = " BACKUP DATABASE " + tbxNameDatabase.Text.Trim() + "  TO  " + nameDevice.Trim() + " WITH INIT "; //ghi đè
                        check = Program.ExecSqlNonQuery(cmd, Program.connStr, "");
                        if (check != 0)
                        {
                            MessageBox.Show("Lỗi sao lưu");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Sao lưu thành công");
                            LoadListBackup();
                            cbDeleteBackupOld.Checked = false;
                            return;
                        }
                    }
                }
                else
                {
                    DialogResult mess1 = MessageBox.Show("Bạn có muốn sao lưu?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mess1 == DialogResult.Yes)
                    {
                        String cmd = "BACKUP DATABASE " + tbxNameDatabase.Text.Trim() + "  TO  " + nameDevice.Trim();
                        int check = Program.ExecSqlNonQuery(cmd, Program.connStr, "");
                        if (check != 0)
                        {
                            MessageBox.Show("Lỗi sao lưu!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Sao lưu thành công");
                            LoadListBackup();
                            return;
                        }
                    }
                }
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.list_BackupBindingSource.Count == 0)
            {
                MessageBox.Show("Chưa có bản sao lưu!", "", MessageBoxButtons.OK);
                return;
            }
            if (listBackup == 0)
            {
                MessageBox.Show("Chưa chọn bản sao lưu muốn phục hồi!", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            if (tbxNameDatabase.Text.Trim() == "" || nameDevice == "")
            {
                return;
            }
            String strRestore = "ALTER DATABASE " + tbxNameDatabase.Text.Trim()
                + " SET  SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                " USE tempdb";
            if (cbRestoreTime.Checked == false)
            {
                strRestore += " RESTORE DATABASE " + tbxNameDatabase.Text.Trim()
                    + " FROM " + nameDevice + " WITH FILE =" + listBackup + ", REPLACE "
                    + " ALTER DATABASE " + tbxNameDatabase.Text.Trim() + " SET MULTI_USER";
                int check = Program.ExecSqlNonQuery(strRestore, Program.connStr, "Lỗi phục hồi CSDL");
                if (check != 0)
                {
                    MessageBox.Show("Lỗi phục hồi!");
                    return;
                }
                else
                {
                    MessageBox.Show("Restore về bản thứ " + tbxRowListBackup + "thành công");
                    return;
                }
            }
            else
            {
                DateTime dateTimeBackup = (DateTime)((DataRowView)list_BackupBindingSource[list_BackupBindingSource.Position])["backup_start_date"];
                //Lây thời gian ng dùng chọn
                String timeUser = dateRestore.DateTime.Year + "-" + dateRestore.DateTime.Month + "-" + dateRestore.DateTime.Day + " " +
                    timeRestore.Time.Hour + ":" + (timeRestore.Time.Minute) + ":" + timeRestore.Time.Second;
                DateTime thoiDiemUserSelected;
                thoiDiemUserSelected = DateTime.Parse(timeUser);
                if ((dateRestore.DateTime.Date < dateTimeBackup.Date) || (dateRestore.DateTime.Date == dateTimeBackup.Date && thoiDiemUserSelected.TimeOfDay.Ticks < dateTimeBackup.TimeOfDay.Ticks))
                {
                    MessageBox.Show("Thời điềm muốn phục hồi phài sau thời điểm bản backup đã chọn.", "", MessageBoxButtons.OK);
                    return;
                }
                if (thoiDiemUserSelected > DateTime.Now)
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại", "", MessageBoxButtons.OK);
                    return;
                }
                if ((MessageBox.Show("Bạn chắc chắn muốn phục hồi database " + tbxNameDatabase.Text + " về ngày " + thoiDiemUserSelected + " ? ", "", MessageBoxButtons.OKCancel) == DialogResult.OK))
                {
                    try
                    {
                        strRestore = "ALTER DATABASE " + tbxNameDatabase.Text.Trim() + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE \n" +
                            " BACKUP LOG " + tbxNameDatabase.Text.Trim() + " TO DISK = '" + Program.URL + "/" + "DEVICE_" +
                            tbxNameDatabase.Text.Trim() + ".trn' WITH INIT, NORECOVERY; \n" + " USE tempdb \n" +
                            " RESTORE DATABASE " + tbxNameDatabase.Text.Trim() + " FROM DEVICE_" + tbxNameDatabase.Text.Trim() + " WITH FILE = " + listBackup + ",NORECOVERY; \n" +
                            " RESTORE DATABASE " + tbxNameDatabase.Text.Trim() + " FROM DISK = '" + Program.URL + "/" + "DEVICE_" + tbxNameDatabase.Text.Trim() + ".trn' " +
                            " WITH STOPAT= '" + timeUser + "' \n" +
                            " ALTER DATABASE " + tbxNameDatabase.Text.Trim() + " SET MULTI_USER";
                        int check = Program.ExecSqlNonQuery(strRestore, Program.connStr, "Lỗi phục hồi CSDL.");
                        if (check == 0)
                        {
                            MessageBox.Show("Phục hồi cơ sở dữ liệu thành công.", "", MessageBoxButtons.OK);

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Restore: \n" + ex, "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void cbRestoreTime_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbRestoreTime.Checked == true)
            {
                panelCheckRestore.Show();
                dateRestore.DateTime = DateTime.Now;
                timeRestore.Time = DateTime.Now;
            }
            else
            {
                panelCheckRestore.Hide();
            }
        }

        private void btnDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int tmp = CreateDevice(tbxNameDatabase.Text.Trim());
            Console.WriteLine("đã tạo");
            if (tmp == 0)
            {
                MessageBox.Show("Lỗi khi sao lưu");
                return;
            }
            else
            {
                MessageBox.Show("Đã tạo device.");
            }
            btnBackup.Enabled = true;
            btnDevice.Enabled = false;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult mess = MessageBox.Show("Bạn muốn thoát chương trình?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mess == DialogResult.Yes)
            {
                this.Close();
                Program.fmLogin.Close();
            }
        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                this.list_BackupTableAdapter.Fill(this.databasesDataSet.List_Backup, tbxNameDatabase.Text);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void databasesGridControl_Click(object sender, EventArgs e)
        {
            try
            {
                if(databasesBindingSource.Position == -1 || databasesBindingSource.Count ==0 || databasesBindingSource.DataSource == null)
                {
                    tbxNameDatabase.Text = "";
                }
                else
                {
                    tbxNameDatabase.Text = ((DataRowView)databasesBindingSource[databasesBindingSource.Position])["name"].ToString();
                }
                LoadListBackup();
                
                tbxNameDatabase.Text = ((DataRowView)databasesBindingSource[databasesBindingSource.Position])["name"].ToString();
                CheckCountDevive();
                nameDevice = "DEVICE_" + tbxNameDatabase.Text.Trim();
                listBackupLastest = list_BackupBindingSource.Count;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK);
            }

        }

        private void list_backupGridControl_Click(object sender, EventArgs e)
        {
            listBackup = int.Parse(((DataRowView)list_BackupBindingSource[list_BackupBindingSource.Position])["position"].ToString());
            tbxRowListBackup.Text = listBackup.ToString();
        }
    }



}
