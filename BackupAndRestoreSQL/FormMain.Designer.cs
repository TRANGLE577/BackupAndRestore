
namespace BackupAndRestoreSQL
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.databasesGridControl = new DevExpress.XtraGrid.GridControl();
            this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasesDataSet = new BackupAndRestoreSQL.DatabasesDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatabase_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelCheckRestore = new System.Windows.Forms.Panel();
            this.timeRestore = new DevExpress.XtraEditors.TimeEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.cbRestoreTime = new DevExpress.XtraBars.BarCheckItem();
            this.btnDevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.dateRestore = new DevExpress.XtraEditors.DateEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbDeleteBackupOld = new System.Windows.Forms.CheckBox();
            this.list_backupGridControl = new DevExpress.XtraGrid.GridControl();
            this.list_BackupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.position = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name_backup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.user_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbxNameDatabase = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tbxRowListBackup = new System.Windows.Forms.ToolStripTextBox();
            this.databasesTableAdapter = new BackupAndRestoreSQL.DatabasesDataSetTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new BackupAndRestoreSQL.DatabasesDataSetTableAdapters.TableAdapterManager();
            this.list_BackupTableAdapter = new BackupAndRestoreSQL.DatabasesDataSetTableAdapters.List_BackupTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelCheckRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_backupGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_BackupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.databasesGridControl);
            this.panel2.Location = new System.Drawing.Point(1, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 564);
            this.panel2.TabIndex = 3;
            // 
            // databasesGridControl
            // 
            this.databasesGridControl.DataSource = this.databasesBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.databasesGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.databasesGridControl.Location = new System.Drawing.Point(3, 3);
            this.databasesGridControl.MainView = this.gridView1;
            this.databasesGridControl.Name = "databasesGridControl";
            this.databasesGridControl.Size = new System.Drawing.Size(299, 558);
            this.databasesGridControl.TabIndex = 6;
            this.databasesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.databasesGridControl.Click += new System.EventHandler(this.databasesGridControl_Click);
            // 
            // databasesBindingSource
            // 
            this.databasesBindingSource.DataMember = "databases";
            this.databasesBindingSource.DataSource = this.databasesDataSet;
            // 
            // databasesDataSet
            // 
            this.databasesDataSet.DataSetName = "DatabasesDataSet";
            this.databasesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.name,
            this.coldatabase_id});
            this.gridView1.GridControl = this.databasesGridControl;
            this.gridView1.GroupPanelText = "Cơ sở dữ liệu";
            this.gridView1.Name = "gridView1";
            // 
            // name
            // 
            this.name.Caption = "Tên cơ sở dữ liệu";
            this.name.FieldName = "name";
            this.name.MinWidth = 25;
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            this.name.Width = 94;
            // 
            // coldatabase_id
            // 
            this.coldatabase_id.FieldName = "database_id";
            this.coldatabase_id.MinWidth = 25;
            this.coldatabase_id.Name = "coldatabase_id";
            this.coldatabase_id.Width = 94;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(312, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 666);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.list_backupGridControl);
            this.panel5.Location = new System.Drawing.Point(3, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(883, 610);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Controls.Add(this.panelCheckRestore);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(3, 369);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(880, 215);
            this.panel6.TabIndex = 1;
            // 
            // panelCheckRestore
            // 
            this.panelCheckRestore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelCheckRestore.Controls.Add(this.timeRestore);
            this.panelCheckRestore.Controls.Add(this.dateRestore);
            this.panelCheckRestore.Controls.Add(this.textBox1);
            this.panelCheckRestore.Controls.Add(this.label2);
            this.panelCheckRestore.Location = new System.Drawing.Point(4, 62);
            this.panelCheckRestore.Name = "panelCheckRestore";
            this.panelCheckRestore.Size = new System.Drawing.Size(872, 179);
            this.panelCheckRestore.TabIndex = 2;
            // 
            // timeRestore
            // 
            this.timeRestore.EditValue = new System.DateTime(2022, 4, 26, 0, 0, 0, 0);
            this.timeRestore.Location = new System.Drawing.Point(608, 28);
            this.timeRestore.MenuManager = this.barManager1;
            this.timeRestore.Name = "timeRestore";
            this.timeRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeRestore.Size = new System.Drawing.Size(177, 24);
            this.timeRestore.TabIndex = 5;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBackup,
            this.btnRestore,
            this.barButtonItem2,
            this.cbRestoreTime,
            this.btnDevice,
            this.btnExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBackup),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRestore),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbRestoreTime),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDevice),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBackup
            // 
            this.btnBackup.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnBackup.Caption = "Sao lưu";
            this.btnBackup.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.btnBackup.Id = 0;
            this.btnBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.Image")));
            this.btnBackup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.LargeImage")));
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnBackup.Size = new System.Drawing.Size(80, 30);
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi";
            this.btnRestore.Id = 1;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.LargeImage")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // cbRestoreTime
            // 
            this.cbRestoreTime.Caption = "Tham số phục hồi theo thời gian";
            this.cbRestoreTime.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.cbRestoreTime.Id = 3;
            this.cbRestoreTime.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cbRestoreTime.ImageOptions.Image")));
            this.cbRestoreTime.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cbRestoreTime.ImageOptions.LargeImage")));
            this.cbRestoreTime.Name = "cbRestoreTime";
            this.cbRestoreTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.cbRestoreTime.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.cbRestoreTime_CheckedChanged);
            // 
            // btnDevice
            // 
            this.btnDevice.Caption = "Tạo Device";
            this.btnDevice.Id = 4;
            this.btnDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDevice.ImageOptions.Image")));
            this.btnDevice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDevice.ImageOptions.LargeImage")));
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDevice_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 5;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1220, 58);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 710);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1220, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 58);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 652);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1220, 58);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 652);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // dateRestore
            // 
            this.dateRestore.EditValue = null;
            this.dateRestore.Location = new System.Drawing.Point(385, 29);
            this.dateRestore.MenuManager = this.barManager1;
            this.dateRestore.Name = "dateRestore";
            this.dateRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRestore.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRestore.Size = new System.Drawing.Size(188, 22);
            this.dateRestore.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(47, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(764, 91);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Hướng Dẫn: Ngày giờ ta nhập vào là thời điểm ta muốn phục hồi cơ sở dữ liệu về đó" +
    ". Thời điểm này phải sau thời điểm của bản sao lưu mà ta đã chọn trên lưới và tr" +
    "ước thời điểm hiện tại ít nhất 1 phút.\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày giờ để phục hồi tới thời điểm đó:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbDeleteBackupOld);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(873, 58);
            this.panel7.TabIndex = 1;
            // 
            // cbDeleteBackupOld
            // 
            this.cbDeleteBackupOld.AutoSize = true;
            this.cbDeleteBackupOld.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeleteBackupOld.Location = new System.Drawing.Point(220, 16);
            this.cbDeleteBackupOld.Name = "cbDeleteBackupOld";
            this.cbDeleteBackupOld.Size = new System.Drawing.Size(499, 27);
            this.cbDeleteBackupOld.TabIndex = 0;
            this.cbDeleteBackupOld.Text = "Xóa tất cả các bản sao lưu cũ trong File trước khi sao lưu mới";
            this.cbDeleteBackupOld.UseVisualStyleBackColor = true;
            // 
            // list_backupGridControl
            // 
            this.list_backupGridControl.DataSource = this.list_BackupBindingSource;
            this.list_backupGridControl.Location = new System.Drawing.Point(3, 3);
            this.list_backupGridControl.MainView = this.gridView2;
            this.list_backupGridControl.Name = "list_backupGridControl";
            this.list_backupGridControl.Size = new System.Drawing.Size(880, 360);
            this.list_backupGridControl.TabIndex = 6;
            this.list_backupGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.list_backupGridControl.Click += new System.EventHandler(this.list_backupGridControl_Click);
            // 
            // list_BackupBindingSource
            // 
            this.list_BackupBindingSource.DataMember = "List_Backup";
            this.list_BackupBindingSource.DataSource = this.databasesDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.position,
            this.name_backup,
            this.backup_start_date,
            this.user_name});
            this.gridView2.GridControl = this.list_backupGridControl;
            this.gridView2.GroupPanelText = "Backup List";
            this.gridView2.Name = "gridView2";
            // 
            // position
            // 
            this.position.Caption = "Bản sao lưu thứ";
            this.position.FieldName = "position";
            this.position.MinWidth = 25;
            this.position.Name = "position";
            this.position.Visible = true;
            this.position.VisibleIndex = 0;
            this.position.Width = 94;
            // 
            // name_backup
            // 
            this.name_backup.Caption = "Diễn giải";
            this.name_backup.FieldName = "name";
            this.name_backup.MinWidth = 25;
            this.name_backup.Name = "name_backup";
            this.name_backup.Visible = true;
            this.name_backup.VisibleIndex = 1;
            this.name_backup.Width = 94;
            // 
            // backup_start_date
            // 
            this.backup_start_date.Caption = "Ngày giờ sao lưu";
            this.backup_start_date.FieldName = "backup_start_date";
            this.backup_start_date.MinWidth = 25;
            this.backup_start_date.Name = "backup_start_date";
            this.backup_start_date.Visible = true;
            this.backup_start_date.VisibleIndex = 2;
            this.backup_start_date.Width = 94;
            // 
            // user_name
            // 
            this.user_name.Caption = "Người sao lưu";
            this.user_name.FieldName = "user_name";
            this.user_name.MinWidth = 25;
            this.user_name.Name = "user_name";
            this.user_name.Visible = true;
            this.user_name.VisibleIndex = 3;
            this.user_name.Width = 94;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fillToolStrip);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(883, 44);
            this.panel4.TabIndex = 0;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillToolStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tbxNameDatabase,
            this.toolStripLabel4,
            this.tbxRowListBackup});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(883, 44);
            this.fillToolStrip.TabIndex = 0;
            this.fillToolStrip.Text = "toolStrip";
            this.fillToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillToolStrip_ItemClicked);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.toolStripLabel2.Size = new System.Drawing.Size(151, 41);
            this.toolStripLabel2.Text = "Tên Cơ sở dữ liệu";
            // 
            // tbxNameDatabase
            // 
            this.tbxNameDatabase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxNameDatabase.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tbxNameDatabase.Name = "tbxNameDatabase";
            this.tbxNameDatabase.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tbxNameDatabase.Size = new System.Drawing.Size(220, 34);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.toolStripLabel4.Size = new System.Drawing.Size(164, 41);
            this.toolStripLabel4.Text = "Thứ tự bản sao lưu";
            // 
            // tbxRowListBackup
            // 
            this.tbxRowListBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxRowListBackup.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tbxRowListBackup.Name = "tbxRowListBackup";
            this.tbxRowListBackup.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tbxRowListBackup.Size = new System.Drawing.Size(120, 34);
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.backup_devicesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.databasesTableAdapter = this.databasesTableAdapter;
            this.tableAdapterManager.List_BackupTableAdapter = this.list_BackupTableAdapter;
            this.tableAdapterManager.UpdateOrder = BackupAndRestoreSQL.DatabasesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // list_BackupTableAdapter
            // 
            this.list_BackupTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 730);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMain";
            this.Text = "Backup And Restore Database in SQL Server";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelCheckRestore.ResumeLayout(false);
            this.panelCheckRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_backupGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_BackupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGrid.GridControl list_backupGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl databasesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelCheckRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox cbDeleteBackupOld;
        private DatabasesDataSet databasesDataSet;
        private System.Windows.Forms.BindingSource databasesBindingSource;
        private DatabasesDataSetTableAdapters.databasesTableAdapter databasesTableAdapter;
        private DatabasesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn coldatabase_id;
        private DatabasesDataSetTableAdapters.List_BackupTableAdapter list_BackupTableAdapter;
        private System.Windows.Forms.BindingSource list_BackupBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn position;
        private DevExpress.XtraGrid.Columns.GridColumn name_backup;
        private DevExpress.XtraGrid.Columns.GridColumn backup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn user_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbxNameDatabase;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox tbxRowListBackup;
        private DevExpress.XtraEditors.TimeEdit timeRestore;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarCheckItem cbRestoreTime;
        private DevExpress.XtraBars.BarButtonItem btnDevice;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.DateEdit dateRestore;
    }
}