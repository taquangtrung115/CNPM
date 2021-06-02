namespace frmMain.GUI
{
    partial class frmMedicalBill
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
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalBill));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbTrangThai = new DevExpress.XtraEditors.LookUpEdit();
            this.cbHinhThucKham = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTinhTrangSK = new DevExpress.XtraEditors.TextEdit();
            this.cbPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.btnChoKham = new DevExpress.XtraEditors.SimpleButton();
            this.dgvPhieuKhamBenh = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtTenBN = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtDeNghiKham = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHinhThucKham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrangSK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKhamBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeNghiKham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Tải Lại", true, buttonImageOptions1)});
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1132, 647);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl1_CustomButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtDeNghiKham);
            this.layoutControl1.Controls.Add(this.txtTenBN);
            this.layoutControl1.Controls.Add(this.cbTrangThai);
            this.layoutControl1.Controls.Add(this.cbHinhThucKham);
            this.layoutControl1.Controls.Add(this.txtTinhTrangSK);
            this.layoutControl1.Controls.Add(this.cbPhong);
            this.layoutControl1.Controls.Add(this.btnChoKham);
            this.layoutControl1.Controls.Add(this.dgvPhieuKhamBenh);
            this.layoutControl1.Controls.Add(this.txtNhanVien);
            this.layoutControl1.Controls.Add(this.txtNgayLap);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 49);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(286, 148, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1128, 596);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Location = new System.Drawing.Point(149, 212);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTrangThai.Size = new System.Drawing.Size(963, 22);
            this.cbTrangThai.StyleController = this.layoutControl1;
            this.cbTrangThai.TabIndex = 21;
            // 
            // cbHinhThucKham
            // 
            this.cbHinhThucKham.Location = new System.Drawing.Point(149, 184);
            this.cbHinhThucKham.Name = "cbHinhThucKham";
            this.cbHinhThucKham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbHinhThucKham.Size = new System.Drawing.Size(963, 22);
            this.cbHinhThucKham.StyleController = this.layoutControl1;
            this.cbHinhThucKham.TabIndex = 20;
            // 
            // txtTinhTrangSK
            // 
            this.txtTinhTrangSK.Location = new System.Drawing.Point(149, 128);
            this.txtTinhTrangSK.Name = "txtTinhTrangSK";
            this.txtTinhTrangSK.Size = new System.Drawing.Size(963, 22);
            this.txtTinhTrangSK.StyleController = this.layoutControl1;
            this.txtTinhTrangSK.TabIndex = 18;
            // 
            // cbPhong
            // 
            this.cbPhong.Location = new System.Drawing.Point(149, 100);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPhong.Size = new System.Drawing.Size(963, 22);
            this.cbPhong.StyleController = this.layoutControl1;
            this.cbPhong.TabIndex = 17;
            // 
            // btnChoKham
            // 
            this.btnChoKham.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChoKham.Appearance.Options.UseFont = true;
            this.btnChoKham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChoKham.ImageOptions.Image")));
            this.btnChoKham.Location = new System.Drawing.Point(16, 540);
            this.btnChoKham.Name = "btnChoKham";
            this.btnChoKham.Size = new System.Drawing.Size(1096, 40);
            this.btnChoKham.StyleController = this.layoutControl1;
            this.btnChoKham.TabIndex = 15;
            this.btnChoKham.Text = "Chờ Khám";
     
            // 
            // dgvPhieuKhamBenh
            // 
            this.dgvPhieuKhamBenh.Location = new System.Drawing.Point(21, 240);
            this.dgvPhieuKhamBenh.MainView = this.gridView1;
            this.dgvPhieuKhamBenh.Name = "dgvPhieuKhamBenh";
            this.dgvPhieuKhamBenh.Size = new System.Drawing.Size(1091, 294);
            this.dgvPhieuKhamBenh.TabIndex = 12;
            this.dgvPhieuKhamBenh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvPhieuKhamBenh;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(149, 44);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(963, 22);
            this.txtNhanVien.StyleController = this.layoutControl1;
            this.txtNhanVien.TabIndex = 7;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.EditValue = null;
            this.txtNgayLap.Location = new System.Drawing.Point(149, 72);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLap.Properties.DisplayFormat.FormatString = "";
            this.txtNgayLap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayLap.Properties.EditFormat.FormatString = "";
            this.txtNgayLap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayLap.Properties.Mask.EditMask = "";
            this.txtNgayLap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtNgayLap.Size = new System.Drawing.Size(963, 22);
            this.txtNgayLap.StyleController = this.layoutControl1;
            this.txtNgayLap.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem11,
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem14,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1128, 596);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtNhanVien;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1102, 28);
            this.layoutControlItem4.Text = "Nhân Viên";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(129, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtNgayLap;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1102, 28);
            this.layoutControlItem5.Text = "Ngày Lập";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(129, 17);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.dgvPhieuKhamBenh;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 224);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(1102, 300);
            this.layoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextToControlDistance = 5;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnChoKham;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 524);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(1102, 46);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbPhong;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1102, 28);
            this.layoutControlItem3.Text = "Mã Phòng";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(129, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtTinhTrangSK;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1102, 28);
            this.layoutControlItem6.Text = "Tình Trạng Sức Khỏe";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(129, 17);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.cbHinhThucKham;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(1102, 28);
            this.layoutControlItem14.Text = "Hình Thức Khám";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(129, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbTrangThai;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 196);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1102, 28);
            this.layoutControlItem1.Text = "Trạng Thái";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(129, 17);
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(149, 16);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(963, 22);
            this.txtTenBN.StyleController = this.layoutControl1;
            this.txtTenBN.TabIndex = 23;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTenBN;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1102, 28);
            this.layoutControlItem2.Text = "Tên Bệnh Nhân";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(129, 17);
            // 
            // txtDeNghiKham
            // 
            this.txtDeNghiKham.Location = new System.Drawing.Point(149, 156);
            this.txtDeNghiKham.Name = "txtDeNghiKham";
            this.txtDeNghiKham.Size = new System.Drawing.Size(963, 22);
            this.txtDeNghiKham.StyleController = this.layoutControl1;
            this.txtDeNghiKham.TabIndex = 24;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtDeNghiKham;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(1102, 28);
            this.layoutControlItem7.Text = "Đề Nghị Khám";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(129, 17);
            // 
            // frmMedicalBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 647);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicalBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu Khám Bệnh";
            this.Load += new System.EventHandler(this.frmMedicalBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHinhThucKham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrangSK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKhamBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeNghiKham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit cbHinhThucKham;
        private DevExpress.XtraEditors.TextEdit txtTinhTrangSK;
        private DevExpress.XtraEditors.LookUpEdit cbPhong;
        private DevExpress.XtraEditors.SimpleButton btnChoKham;
        private DevExpress.XtraGrid.GridControl dgvPhieuKhamBenh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtNhanVien;
        private DevExpress.XtraEditors.DateEdit txtNgayLap;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraEditors.LookUpEdit cbTrangThai;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtDeNghiKham;
        private DevExpress.XtraEditors.TextEdit txtTenBN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}