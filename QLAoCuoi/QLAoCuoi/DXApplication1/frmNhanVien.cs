using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aocuoiDataSet);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aocuoiDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.aocuoiDataSet.NHANVIEN);
            XuLyButton(true);
        }
        public void XuLyButton(bool b)
        {
            this.mANVTextEdit.Enabled=hOTENNVTextEdit.Enabled=dIACHITextEdit.Enabled
                =sDTTextEdit.Enabled=gIOITINHTextEdit.Enabled=
                aNHPictureEdit.Enabled=b;
        }
       
        
        
        

        private void btthem_Click(object sender, EventArgs e)
        {
            XuLyButton(true);
            mANVTextEdit.Focus();
            this.nHANVIENBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.aocuoiDataSet);
        }

        

       

        private void btxoa_Click(object sender, EventArgs e)
        {
            XuLyButton(true);
            mANVTextEdit.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.nHANVIENBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.aocuoiDataSet);
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (mANVTextEdit.Text.Length == 0)
                MessageBox.Show("Mã sản phẩm không được bỏ trống!");
            else
                if (mANVTextEdit.Text.Length > 10)
                    MessageBox.Show("Mã sản phẩm không được lớn hơn 10!");
                else
                    if (hOTENNVTextEdit.Text.Length == 0)
                        MessageBox.Show("Tên sản phẩm không được bỏ trống");
                    else
                    {
                        try
                        {
                            this.Validate();
                            this.nHANVIENBindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(aocuoiDataSet);
                            XuLyButton(true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mã sản phẩm" + mANVTextEdit.Text + "đã tồn tại", ex.Message);
                        }
                    }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.nHANVIENBindingSource.CancelEdit();
                this.Close();
                XuLyButton(true);
            }
        }

        private void nHANVIENGridControl_Click(object sender, EventArgs e)
        {

        }


    }
}
