namespace DXApplication3
{
    partial class Loaisanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loaisanpham));
            this.lOAISPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aocuoiDataSet = new DXApplication3.aocuoiDataSet();
            this.lOAISPTableAdapter = new DXApplication3.aocuoiDataSetTableAdapters.LOAISPTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_thoat = new DevExpress.XtraEditors.CheckButton();
            this.btn_luu = new DevExpress.XtraEditors.CheckButton();
            this.btn_sua = new DevExpress.XtraEditors.CheckButton();
            this.btn_xoá = new DevExpress.XtraEditors.CheckButton();
            this.btn_them = new DevExpress.XtraEditors.CheckButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.mota_textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.ten_textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.ma_textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.tableAdapterManager = new DXApplication3.aocuoiDataSetTableAdapters.TableAdapterManager();
            this.lOAISPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aocuoiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mota_textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lOAISPBindingSource
            // 
            this.lOAISPBindingSource.DataMember = "LOAISP";
            this.lOAISPBindingSource.DataSource = this.aocuoiDataSet;
            // 
            // aocuoiDataSet
            // 
            this.aocuoiDataSet.DataSetName = "aocuoiDataSet";
            this.aocuoiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAISPTableAdapter
            // 
            this.lOAISPTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_thoat);
            this.groupControl1.Controls.Add(this.btn_luu);
            this.groupControl1.Controls.Add(this.btn_sua);
            this.groupControl1.Controls.Add(this.btn_xoá);
            this.groupControl1.Controls.Add(this.btn_them);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.mota_textEdit3);
            this.groupControl1.Controls.Add(this.ten_textEdit2);
            this.groupControl1.Controls.Add(this.ma_textEdit1);
            this.groupControl1.Location = new System.Drawing.Point(0, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(566, 179);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(486, 117);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 46);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.CheckedChanged += new System.EventHandler(this.btn_thoat_CheckedChanged);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(352, 117);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 46);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.CheckedChanged += new System.EventHandler(this.btn_luu_CheckedChanged);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_sua.Location = new System.Drawing.Point(241, 117);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 46);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.CheckedChanged += new System.EventHandler(this.btn_sua_CheckedChanged);
            // 
            // btn_xoá
            // 
            this.btn_xoá.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoá.Image")));
            this.btn_xoá.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_xoá.Location = new System.Drawing.Point(118, 117);
            this.btn_xoá.Name = "btn_xoá";
            this.btn_xoá.Size = new System.Drawing.Size(75, 46);
            this.btn_xoá.TabIndex = 4;
            this.btn_xoá.Text = "Xoá";
            this.btn_xoá.CheckedChanged += new System.EventHandler(this.btn_xoá_CheckedChanged);
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_them.Location = new System.Drawing.Point(22, 117);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 46);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.CheckedChanged += new System.EventHandler(this.btn_them_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Mô tả";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên loại sản phẩm";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã loại sản phẩm";
            // 
            // mota_textEdit3
            // 
            this.mota_textEdit3.Location = new System.Drawing.Point(156, 89);
            this.mota_textEdit3.Name = "mota_textEdit3";
            this.mota_textEdit3.Size = new System.Drawing.Size(253, 20);
            this.mota_textEdit3.TabIndex = 0;
            // 
            // ten_textEdit2
            // 
            this.ten_textEdit2.Location = new System.Drawing.Point(156, 63);
            this.ten_textEdit2.Name = "ten_textEdit2";
            this.ten_textEdit2.Size = new System.Drawing.Size(253, 20);
            this.ten_textEdit2.TabIndex = 0;
            // 
            // ma_textEdit1
            // 
            this.ma_textEdit1.Location = new System.Drawing.Point(156, 37);
            this.ma_textEdit1.Name = "ma_textEdit1";
            this.ma_textEdit1.Size = new System.Drawing.Size(253, 20);
            this.ma_textEdit1.TabIndex = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LOAISPTableAdapter = this.lOAISPTableAdapter;
            this.tableAdapterManager.UpdateOrder = DXApplication3.aocuoiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOAISPGridControl
            // 
            this.lOAISPGridControl.DataSource = this.lOAISPBindingSource;
            this.lOAISPGridControl.Location = new System.Drawing.Point(0, 197);
            this.lOAISPGridControl.MainView = this.gridView1;
            this.lOAISPGridControl.Name = "lOAISPGridControl";
            this.lOAISPGridControl.Size = new System.Drawing.Size(566, 279);
            this.lOAISPGridControl.TabIndex = 1;
            this.lOAISPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.lOAISPGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // Loaisanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 508);
            this.Controls.Add(this.lOAISPGridControl);
            this.Controls.Add(this.groupControl1);
            this.Name = "Loaisanpham";
            this.Text = "Loaisanpham";
            this.Load += new System.EventHandler(this.Loaisanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOAISPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aocuoiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mota_textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private aocuoiDataSet aocuoiDataSet;
        private System.Windows.Forms.BindingSource lOAISPBindingSource;
        private aocuoiDataSetTableAdapters.LOAISPTableAdapter lOAISPTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit mota_textEdit3;
        private DevExpress.XtraEditors.TextEdit ten_textEdit2;
        private DevExpress.XtraEditors.TextEdit ma_textEdit1;
        private DevExpress.XtraEditors.CheckButton btn_them;
        private aocuoiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOAISPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckButton btn_xoá;
        private DevExpress.XtraEditors.CheckButton btn_sua;
        private DevExpress.XtraEditors.CheckButton btn_thoat;
        private DevExpress.XtraEditors.CheckButton btn_luu;
    }
}