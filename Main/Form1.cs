using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbx_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(tbx_UserName.Text == "Utku Paralı" &&  tbx_Password.Text == "12345")
            {
                lbl_ErrorText.Visible = false;
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();
            }
            else 
            {
                lbl_ErrorText.Visible = true;
                tbx_Password.Clear();
            }
        }
    }
}
