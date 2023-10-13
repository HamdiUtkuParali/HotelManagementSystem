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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pbx_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CreateRes_Click(object sender, EventArgs e)
        {
            pnl_UnderLine.Left = btn_CreateRes.Left;
            uc_CreateRes1.Visible = true;
            uc_CreateRes1.BringToFront();
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            pnl_UnderLine.Left = btn_CheckIn.Left;
            uc_CheckIn1.Visible = true;
            uc_CheckIn1.BringToFront();

        }

        private void btn_TourRegister_Click(object sender, EventArgs e)
        {
            pnl_UnderLine.Left = btn_TourRegister.Left;
            uc_TourRegister1.Visible = true;
            uc_TourRegister1.BringToFront();
        }

        private void btn_Lists_Click(object sender, EventArgs e)
        {
            pnl_UnderLine.Left = btn_Lists.Left;
            uc_Lists1.Visible = true;
            uc_Lists1.BringToFront();
        }

        private void pbx_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uc_CreateRes1.Visible = false;
            uc_CheckIn1.Visible = false;
            uc_TourRegister1.Visible=false;
            uc_Lists1.Visible=false;
        }
    }
}
