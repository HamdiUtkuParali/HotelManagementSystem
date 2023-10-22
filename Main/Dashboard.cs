using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Main.UserControls;

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

        private void pbx_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            
            uc_Customer1.Visible = true;
            uc_Customer1.BringToFront();
            uc_Customer1.LoadCustomers();
            uc_Customer1.LoadBoolList();
            uc_Customer1.LoadOperationList();
            
        }

        public uc_Customer GetUcCustomer() 
        {
            return uc_Customer1;
        }


        // dgwMain.DataSource = _customerService.GetByIsAdult(Convert.ToBoolean(cbx_IsAdult.SelectedValue));

    }
}
