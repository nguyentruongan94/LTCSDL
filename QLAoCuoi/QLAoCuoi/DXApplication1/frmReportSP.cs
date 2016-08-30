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
    public partial class frmReportSP : Form
    {
        public frmReportSP()
        {
            InitializeComponent();
        }

        private void frmReportSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aocuoiDataSet.SANPHAM' table. You can move, or remove it, as needed.
            this.SANPHAMTableAdapter.Fill(this.aocuoiDataSet.SANPHAM);

            this.reportViewer1.RefreshReport();
        }
    }
}
