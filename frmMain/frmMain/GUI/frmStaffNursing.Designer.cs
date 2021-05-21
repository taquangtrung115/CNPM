namespace frmMain.GUI
{
    partial class frmStaffNursing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffNursing));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtSDTNguoiThan = new DevExpress.XtraEditors.TextEdit();
            this.dgvDieuDuong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.txtTim = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNguoiThan = new DevExpress.XtraEditors.TextEdit();
            this.txtGioiTinh = new DevExpress.XtraEditors.TextEdit();
            this.txtTenBN = new DevExpress.XtraEditors.TextEdit();
            this.txtCanNang = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.btnDieuChinh = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnChoKham = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDTNguoiThan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuDuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNguoiThan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCanNang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Tải Lại", ((System.Drawing.Image)(resources.GetObject("groupControl1.CustomHeaderButtons")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xuất Word", global::frmMain.Properties.Resources.Word_icon),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xuất Excel", global::frmMain.Properties.Resources.Excel_icon)});
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1194, 606);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl1_CustomButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnXoa);
            this.layoutControl1.Controls.Add(this.btnChoKham);
            this.layoutControl1.Controls.Add(this.btnDieuChinh);
            this.layoutControl1.Controls.Add(this.txtSDTNguoiThan);
            this.layoutControl1.Controls.Add(this.dgvDieuDuong);
            this.layoutControl1.Controls.Add(this.btnTim);
            this.layoutControl1.Controls.Add(this.txtTim);
            this.layoutControl1.Controls.Add(this.txtTenNguoiThan);
            this.layoutControl1.Controls.Add(this.txtGioiTinh);
            this.layoutControl1.Controls.Add(this.txtTenBN);
            this.layoutControl1.Controls.Add(this.txtCanNang);
            this.layoutControl1.Controls.Add(this.txtNgaySinh);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 49);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(286, 148, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1190, 555);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtSDTNguoiThan
            // 
            this.txtSDTNguoiThan.Location = new System.Drawing.Point(121, 156);
            this.txtSDTNguoiThan.Name = "txtSDTNguoiThan";
            this.txtSDTNguoiThan.Size = new System.Drawing.Size(1053, 22);
            this.txtSDTNguoiThan.StyleController = this.layoutControl1;
            this.txtSDTNguoiThan.TabIndex = 13;
            // 
            // dgvDieuDuong
            // 
            this.dgvDieuDuong.Location = new System.Drawing.Point(21, 230);
            this.dgvDieuDuong.MainView = this.gridView1;
            this.dgvDieuDuong.Name = "dgvDieuDuong";
            this.dgvDieuDuong.Size = new System.Drawing.Size(1153, 263);
            this.dgvDieuDuong.TabIndex = 12;
            this.dgvDieuDuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvDieuDuong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(913, 184);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(261, 40);
            this.btnTim.StyleController = this.layoutControl1;
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm Kiếm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(121, 184);
            this.txtTim.Name = "txtTim";
            this.txtTim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTim.Properties.Appearance.Options.UseFont = true;
            this.txtTim.Size = new System.Drawing.Size(786, 40);
            this.txtTim.StyleController = this.layoutControl1;
            this.txtTim.TabIndex = 10;
            // 
            // txtTenNguoiThan
            // 
            this.txtTenNguoiThan.Location = new System.Drawing.Point(121, 128);
            this.txtTenNguoiThan.Name = "txtTenNguoiThan";
            this.txtTenNguoiThan.Size = new System.Drawing.Size(1053, 22);
            this.txtTenNguoiThan.StyleController = this.layoutControl1;
            this.txtTenNguoiThan.TabIndex = 8;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(121, 72);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(1053, 22);
            this.txtGioiTinh.StyleController = this.layoutControl1;
            this.txtGioiTinh.TabIndex = 7;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(121, 16);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(1053, 22);
            this.txtTenBN.StyleController = this.layoutControl1;
            this.txtTenBN.TabIndex = 5;
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(121, 100);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(1053, 22);
            this.txtCanNang.StyleController = this.layoutControl1;
            this.txtCanNang.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem12});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1190, 555);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTenBN;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1164, 28);
            this.layoutControlItem2.Text = "Tên Bệnh Nhân";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(101, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtNgaySinh;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1164, 28);
            this.layoutControlItem3.Text = "Ngày Sinh";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(101, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtGioiTinh;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1164, 28);
            this.layoutControlItem4.Text = "Giới Tính";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(101, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCanNang;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1164, 28);
            this.layoutControlItem1.Text = "Cân Nặng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(101, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtTenNguoiThan;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1164, 28);
            this.layoutControlItem5.Text = "Tên Người Thân";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(101, 17);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtTim;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(897, 46);
            this.layoutControlItem9.Text = "Tìm Kiếm";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(101, 17);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnTim;
            this.layoutControlItem10.Location = new System.Drawing.Point(897, 168);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(267, 46);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.dgvDieuDuong;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 214);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(1164, 269);
            this.layoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtSDTNguoiThan;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1164, 28);
            this.layoutControlItem6.Text = "SĐT Người Thân";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(101, 17);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.EditValue = null;
            this.txtNgaySinh.Location = new System.Drawing.Point(121, 44);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Properties.DisplayFormat.FormatString = "";
            this.txtNgaySinh.Properties.EditFormat.FormatString = "";
            this.txtNgaySinh.Size = new System.Drawing.Size(1053, 22);
            this.txtNgaySinh.StyleController = this.layoutControl1;
            this.txtNgaySinh.TabIndex = 6;
            // 
            // btnDieuChinh
            // 
            this.btnDieuChinh.Image = ((System.Drawing.Image)(resources.GetObject("btnDieuChinh.Image")));
            this.btnDieuChinh.Location = new System.Drawing.Point(16, 499);
            this.btnDieuChinh.Name = "btnDieuChinh";
            this.btnDieuChinh.Size = new System.Drawing.Size(397, 40);
            this.btnDieuChinh.StyleController = this.layoutControl1;
            this.btnDieuChinh.TabIndex = 14;
            this.btnDieuChinh.Text = "Điều Chỉnh";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnDieuChinh;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 483);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(403, 46);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // btnChoKham
            // 
            this.btnChoKham.Image = ((System.Drawing.Image)(resources.GetObject("btnChoKham.Image")));
            this.btnChoKham.Location = new System.Drawing.Point(419, 499);
            this.btnChoKham.Name = "btnChoKham";
            this.btnChoKham.Size = new System.Drawing.Size(421, 40);
            this.btnChoKham.StyleController = this.layoutControl1;
            this.btnChoKham.TabIndex = 15;
            this.btnChoKham.Text = "Chờ Khám";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnChoKham;
            this.layoutControlItem8.Location = new System.Drawing.Point(403, 483);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(427, 46);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(846, 499);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(328, 40);
            this.btnXoa.StyleController = this.layoutControl1;
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnXoa;
            this.layoutControlItem12.Location = new System.Drawing.Point(830, 483);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(334, 46);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // frmStaffNursing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 606);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStaffNursing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhân Viên Điều Dưỡng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSDTNguoiThan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuDuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNguoiThan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCanNang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtSDTNguoiThan;
        private DevExpress.XtraGrid.GridControl dgvDieuDuong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.TextEdit txtTim;
        private DevExpress.XtraEditors.TextEdit txtTenNguoiThan;
        private DevExpress.XtraEditors.TextEdit txtGioiTinh;
        private DevExpress.XtraEditors.TextEdit txtTenBN;
        private DevExpress.XtraEditors.TextEdit txtCanNang;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.DateEdit txtNgaySinh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnChoKham;
        private DevExpress.XtraEditors.SimpleButton btnDieuChinh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
    }
}