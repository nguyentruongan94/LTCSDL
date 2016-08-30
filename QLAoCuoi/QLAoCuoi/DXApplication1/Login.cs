using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DXApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=aocuoi;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT Count(*) FROM Login where Username='"+txtusername.Text+"'and password='"+txtpassword.Text+"'",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if(dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
               Form1 ss = new Form1();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại username và password");
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

       

        
    }
        
    
}
