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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aocuoiDataSet);

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aocuoiDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.aocuoiDataSet.KHACHHANG);
            XuLyButton(true);
        }
        public void XuLyButton(bool b)
        {
            this.mAKHTextEdit.Enabled = hOTENKHTextEdit.Enabled = dIACHITextEdit.Enabled
                = sDTTextEdit.Enabled = gIOITINHTextEdit.Enabled = usernameTextEdit.Enabled
                = passwordTextEdit.Enabled = cMNDTextEdit.Enabled = emailTextEdit.Enabled = groupControl1.Enabled = b;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            XuLyButton(true);
            mAKHTextEdit.Focus();
            this.kHACHHANGBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.aocuoiDataSet);
        
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            XuLyButton(true);
            mAKHTextEdit.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.kHACHHANGBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.aocuoiDataSet);
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (mAKHTextEdit.Text.Length == 0)
                MessageBox.Show("Mã sản phẩm không được bỏ trống!");
            else
                if (mAKHTextEdit.Text.Length > 10)
                    MessageBox.Show("Mã sản phẩm không được lớn hơn 10!");
                else
                    if (hOTENKHTextEdit.Text.Length == 0)
                        MessageBox.Show("Tên sản phẩm không được bỏ trống");
                    else
                    {
                        try
                        {
                            this.Validate();
                            this.kHACHHANGBindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(aocuoiDataSet);
                            XuLyButton(true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mã sản phẩm" + mAKHTextEdit.Text + "đã tồn tại", ex.Message);
                        }
                    }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.kHACHHANGBindingSource.CancelEdit();
                this.Close();
                XuLyButton(true);
            }
        }
    }
}
