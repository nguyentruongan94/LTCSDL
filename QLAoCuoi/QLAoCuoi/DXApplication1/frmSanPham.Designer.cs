namespace DXApplication1
{
    partial class frmSanPham
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
            System.Windows.Forms.Label mASPLabel;
            System.Windows.Forms.Label tENSPLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btthoat = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.mASPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aocuoiDataSet = new DXApplication1.aocuoiDataSet();
            this.tENSPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sOLUONGTONSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dONGIASpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sANPHAMTableAdapter = new DXApplication1.aocuoiDataSetTableAdapters.SANPHAMTableAdapter();
            this.tableAdapterManager = new DXApplication1.aocuoiDataSetTableAdapters.TableAdapterManager();
            this.sANPHAMBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sANPHAMBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sANPHAMGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            mASPLabel = new System.Windows.Forms.Label();
            tENSPLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mASPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aocuoiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENSPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTONSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingNavigator)).BeginInit();
            this.sANPHAMBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mASPLabel
            // 
            mASPLabel.AutoSize = true;
            mASPLabel.Location = new System.Drawing.Point(18, 31);
            mASPLabel.Name = "mASPLabel";
            mASPLabel.Size = new System.Drawing.Size(75, 13);
            mASPLabel.TabIndex = 0;
            mASPLabel.Text = "Mã Sản Phẩm:";
            // 
            // tENSPLabel
            // 
            tENSPLabel.AutoSize = true;
            tENSPLabel.Location = new System.Drawing.Point(18, 57);
            tENSPLabel.Name = "tENSPLabel";
            tENSPLabel.Size = new System.Drawing.Size(75, 13);
            tENSPLabel.TabIndex = 2;
            tENSPLabel.Text = "Tên Sản Phẩm";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(244, 31);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(77, 13);
            sOLUONGTONLabel.TabIndex = 4;
            sOLUONGTONLabel.Text = "Số Lượng Tồn:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(244, 57);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(49, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn Giá:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btthoat);
            this.groupControl1.Controls.Add(this.btluu);
            this.groupControl1.Controls.Add(this.btxoa);
            this.groupControl1.Controls.Add(this.btsua);
            this.groupControl1.Controls.Add(this.btthem);
            this.groupControl1.Controls.Add(mASPLabel);
            this.groupControl1.Controls.Add(this.mASPTextEdit);
            this.groupControl1.Controls.Add(tENSPLabel);
            this.groupControl1.Controls.Add(this.tENSPTextEdit);
            this.groupControl1.Controls.Add(sOLUONGTONLabel);
            this.groupControl1.Controls.Add(this.sOLUONGTONSpinEdit);
            this.groupControl1.Controls.Add(dONGIALabel);
            this.groupControl1.Controls.Add(this.dONGIASpinEdit);
            this.groupControl1.Location = new System.Drawing.Point(12, 28);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(613, 167);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Sản Phẩm";
            // 
            // btthoat
            // 
            this.btthoat.Image = global::DXApplication1.Properties.Resources.close;
            this.btthoat.Location = new System.Drawing.Point(486, 122);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 38);
            this.btthoat.TabIndex = 12;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btluu
            // 
            this.btluu.Image = global::DXApplication1.Properties.Resources.Save;
            this.btluu.Location = new System.Drawing.Point(356, 122);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(75, 38);
            this.btluu.TabIndex = 11;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btxoa
            // 
            this.btxoa.Image = global::DXApplication1.Properties.Resources.del;
            this.btxoa.Location = new System.Drawing.Point(246, 122);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 38);
            this.btxoa.TabIndex = 10;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Image = global::DXApplication1.Properties.Resources.refresh;
            this.btsua.Location = new System.Drawing.Point(138, 122);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 38);
            this.btsua.TabIndex = 9;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Image = global::DXApplication1.Properties.Resources.add;
            this.btthem.Location = new System.Drawing.Point(21, 122);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 38);
            this.btthem.TabIndex = 8;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // mASPTextEdit
            // 
            this.mASPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sANPHAMBindingSource, "MASP", true));
            this.mASPTextEdit.Location = new System.Drawing.Point(104, 28);
            this.mASPTextEdit.Name = "mASPTextEdit";
            this.mASPTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mASPTextEdit.TabIndex = 1;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.aocuoiDataSet;
            // 
            // aocuoiDataSet
            // 
            this.aocuoiDataSet.DataSetName = "aocuoiDataSet";
            this.aocuoiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tENSPTextEdit
            // 
            this.tENSPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sANPHAMBindingSource, "TENSP", true));
            this.tENSPTextEdit.Location = new System.Drawing.Point(104, 54);
            this.tENSPTextEdit.Name = "tENSPTextEdit";
            this.tENSPTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENSPTextEdit.TabIndex = 3;
            // 
            // sOLUONGTONSpinEdit
            // 
            this.sOLUONGTONSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sANPHAMBindingSource, "SOLUONGTON", true));
            this.sOLUONGTONSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOLUONGTONSpinEdit.Location = new System.Drawing.Point(356, 28);
            this.sOLUONGTONSpinEdit.Name = "sOLUONGTONSpinEdit";
            this.sOLUONGTONSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOLUONGTONSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.sOLUONGTONSpinEdit.TabIndex = 5;
            // 
            // dONGIASpinEdit
            // 
            this.dONGIASpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sANPHAMBindingSource, "DONGIA", true));
            this.dONGIASpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dONGIASpinEdit.Location = new System.Drawing.Point(356, 54);
            this.dONGIASpinEdit.Name = "dONGIASpinEdit";
            this.dONGIASpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dONGIASpinEdit.Size = new System.Drawing.Size(100, 20);
            this.dONGIASpinEdit.TabIndex = 7;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = this.sANPHAMTableAdapter;
            this.tableAdapterManager.UpdateOrder = DXApplication1.aocuoiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sANPHAMBindingNavigator
            // 
            this.sANPHAMBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sANPHAMBindingNavigator.BindingSource = this.sANPHAMBindingSource;
            this.sANPHAMBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sANPHAMBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sANPHAMBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sANPHAMBindingNavigatorSaveItem});
            this.sANPHAMBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sANPHAMBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sANPHAMBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sANPHAMBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sANPHAMBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sANPHAMBindingNavigator.Name = "sANPHAMBindingNavigator";
            this.sANPHAMBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sANPHAMBindingNavigator.Size = new System.Drawing.Size(648, 25);
            this.sANPHAMBindingNavigator.TabIndex = 1;
            this.sANPHAMBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sANPHAMBindingNavigatorSaveItem
            // 
            this.sANPHAMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sANPHAMBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sANPHAMBindingNavigatorSaveItem.Image")));
            this.sANPHAMBindingNavigatorSaveItem.Name = "sANPHAMBindingNavigatorSaveItem";
            this.sANPHAMBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sANPHAMBindingNavigatorSaveItem.Text = "Save Data";
            this.sANPHAMBindingNavigatorSaveItem.Click += new System.EventHandler(this.sANPHAMBindingNavigatorSaveItem_Click);
            // 
            // sANPHAMGridControl
            // 
            this.sANPHAMGridControl.DataSource = this.sANPHAMBindingSource;
            this.sANPHAMGridControl.Location = new System.Drawing.Point(12, 201);
            this.sANPHAMGridControl.MainView = this.gridView1;
            this.sANPHAMGridControl.Name = "sANPHAMGridControl";
            this.sANPHAMGridControl.Size = new System.Drawing.Size(613, 220);
            this.sANPHAMGridControl.TabIndex = 2;
            this.sANPHAMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sANPHAMGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 471);
            this.Controls.Add(this.sANPHAMGridControl);
            this.Controls.Add(this.sANPHAMBindingNavigator);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mASPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aocuoiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENSPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTONSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingNavigator)).EndInit();
            this.sANPHAMBindingNavigator.ResumeLayout(false);
            this.sANPHAMBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private aocuoiDataSet aocuoiDataSet;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private aocuoiDataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private aocuoiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sANPHAMBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sANPHAMBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private DevExpress.XtraEditors.TextEdit mASPTextEdit;
        private DevExpress.XtraEditors.TextEdit tENSPTextEdit;
        private DevExpress.XtraEditors.SpinEdit sOLUONGTONSpinEdit;
        private DevExpress.XtraEditors.SpinEdit dONGIASpinEdit;
        private DevExpress.XtraGrid.GridControl sANPHAMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}