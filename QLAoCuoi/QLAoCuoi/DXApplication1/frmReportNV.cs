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
    public partial class frmReportNV : Form
    {
        public frmReportNV()
        {
            InitializeComponent();
        }

        private void frmReportNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aocuoiDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.NHANVIENTableAdapter.Fill(this.aocuoiDataSet.NHANVIEN);

            this.reportViewer1.RefreshReport();
        }
    }
}
