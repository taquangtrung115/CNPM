namespace frmMain.GUI
{
    partial class frmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbTenXetNghiem = new DevExpress.XtraEditors.LookUpEdit();
            this.cbNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.cbBenhNhan = new DevExpress.XtraEditors.LookUpEdit();
            this.dgvXetNghiem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtKetQuaXN = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayThucHien = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTenXetNghiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBenhNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKetQuaXN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThucHien.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThucHien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1278, 652);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thao Tác";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl1);
            this.groupControl2.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lập Phiếu", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lưu", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons1")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons2")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Sửa", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons3")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xem Phiếu", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons4")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("In Phiếu", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons5")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thoát", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons6"))))});
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 25);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1274, 625);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl2_CustomButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbTenXetNghiem);
            this.layoutControl1.Controls.Add(this.cbNhanVien);
            this.layoutControl1.Controls.Add(this.cbBenhNhan);
            this.layoutControl1.Controls.Add(this.dgvXetNghiem);
            this.layoutControl1.Controls.Add(this.txtKetQuaXN);
            this.layoutControl1.Controls.Add(this.txtNgayThucHien);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 49);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1270, 574);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbTenXetNghiem
            // 
            this.cbTenXetNghiem.Location = new System.Drawing.Point(143, 100);
            this.cbTenXetNghiem.Name = "cbTenXetNghiem";
            this.cbTenXetNghiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTenXetNghiem.Size = new System.Drawing.Size(1111, 22);
            this.cbTenXetNghiem.StyleController = this.layoutControl1;
            this.cbTenXetNghiem.TabIndex = 10;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.Location = new System.Drawing.Point(143, 72);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbNhanVien.Size = new System.Drawing.Size(1111, 22);
            this.cbNhanVien.StyleController = this.layoutControl1;
            this.cbNhanVien.TabIndex = 9;
            // 
            // cbBenhNhan
            // 
            this.cbBenhNhan.Location = new System.Drawing.Point(143, 16);
            this.cbBenhNhan.Name = "cbBenhNhan";
            this.cbBenhNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBenhNhan.Size = new System.Drawing.Size(1111, 22);
            this.cbBenhNhan.StyleController = this.layoutControl1;
            this.cbBenhNhan.TabIndex = 8;
            // 
            // dgvXetNghiem
            // 
            this.dgvXetNghiem.Location = new System.Drawing.Point(21, 156);
            this.dgvXetNghiem.MainView = this.gridView1;
            this.dgvXetNghiem.Name = "dgvXetNghiem";
            this.dgvXetNghiem.Size = new System.Drawing.Size(1233, 402);
            this.dgvXetNghiem.TabIndex = 7;
            this.dgvXetNghiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.dgvXetNghiem;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Loại Thuốc";
            this.gridColumn1.FieldName = "MALOAI";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Loại Thuốc";
            this.gridColumn2.FieldName = "TENLOAI";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // txtKetQuaXN
            // 
            this.txtKetQuaXN.Location = new System.Drawing.Point(143, 128);
            this.txtKetQuaXN.Name = "txtKetQuaXN";
            this.txtKetQuaXN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtKetQuaXN.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtKetQuaXN.Properties.Mask.EditMask = "d";
            this.txtKetQuaXN.Size = new System.Drawing.Size(1111, 22);
            this.txtKetQuaXN.StyleController = this.layoutControl1;
            this.txtKetQuaXN.TabIndex = 4;
            // 
            // txtNgayThucHien
            // 
            this.txtNgayThucHien.EditValue = null;
            this.txtNgayThucHien.Location = new System.Drawing.Point(143, 44);
            this.txtNgayThucHien.Name = "txtNgayThucHien";
            this.txtNgayThucHien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayThucHien.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayThucHien.Properties.DisplayFormat.FormatString = "";
            this.txtNgayThucHien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayThucHien.Properties.EditFormat.FormatString = "";
            this.txtNgayThucHien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayThucHien.Size = new System.Drawing.Size(1111, 22);
            this.txtNgayThucHien.StyleController = this.layoutControl1;
            this.txtNgayThucHien.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem15,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1270, 574);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.dgvXetNghiem;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(1244, 408);
            this.layoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNgayThucHien;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1244, 28);
            this.layoutControlItem2.Text = "Ngày Thực Hiện";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(123, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtKetQuaXN;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1244, 28);
            this.layoutControlItem5.Text = "Kết Quả Xét Nghiệm";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(123, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbBenhNhan;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1244, 28);
            this.layoutControlItem1.Text = "Bệnh Nhân";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(123, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbNhanVien;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1244, 28);
            this.layoutControlItem3.Text = "Nhân Viên";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(123, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbTenXetNghiem;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1244, 28);
            this.layoutControlItem4.Text = "Tên Xét Nghiệm";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(123, 17);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 652);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbTenXetNghiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBenhNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKetQuaXN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThucHien.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThucHien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl dgvXetNghiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit txtKetQuaXN;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.DateEdit txtNgayThucHien;
        private DevExpress.XtraEditors.LookUpEdit cbTenXetNghiem;
        private DevExpress.XtraEditors.LookUpEdit cbNhanVien;
        private DevExpress.XtraEditors.LookUpEdit cbBenhNhan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;

    }
}