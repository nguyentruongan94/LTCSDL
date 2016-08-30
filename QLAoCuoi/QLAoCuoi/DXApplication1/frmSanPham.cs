using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aocuoiDataSet);

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aocuoiDataSet.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.aocuoiDataSet.SANPHAM);
            XuLyButton(true);
        }
        public void XuLyButton(bool b)
        {
            this.mASPTextEdit.Enabled = tENSPTextEdit.Enabled=sOLUONGTONSpinEdit.Enabled=dONGIASpinEdit.Enabled=groupControl1.Enabled=b;
        }
        

        private void btsua_Click(object sender, EventArgs e)
        {
            XuLyButton(true);
            mASPTextEdit.Focus();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            XuLyButton(true);
            mASPTextEdit.Focus();
            this.sANPHAMBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.aocuoiDataSet);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.sANPHAMBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.aocuoiDataSet);
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (mASPTextEdit.Text.Length == 0)
                MessageBox.Show("Mã sản phẩm không được bỏ trống!");
            else
                if (mASPTextEdit.Text.Length > 10)
                    MessageBox.Show("Mã sản phẩm không được lớn hơn 10!");
                else
                    if (tENSPTextEdit.Text.Length == 0)
                        MessageBox.Show("Tên sản phẩm không được bỏ trống");
                    else
                    {
                        try
                        {
                            this.Validate();
                            this.sANPHAMBindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(aocuoiDataSet);
                            XuLyButton(true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mã sản phẩm" + mASPTextEdit.Text + "đã tồn tại", ex.Message);
                        }
                    }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn Thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.sANPHAMBindingSource.CancelEdit();
                this.Close();
                XuLyButton(true);
            }
        }
    }
}
