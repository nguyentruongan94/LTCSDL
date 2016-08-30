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
    public partial class frmReportKH : Form
    {
        public frmReportKH()
        {
            InitializeComponent();
        }

        private void frmReportKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aocuoiDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.KHACHHANGTableAdapter.Fill(this.aocuoiDataSet.KHACHHANG);

            this.reportViewer1.RefreshReport();
        }
    }
}
