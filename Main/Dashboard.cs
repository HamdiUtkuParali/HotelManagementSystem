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

namespace Main
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            _customerService = new CustomerManager(new CustomerDal());
        }

        private ICustomerService _customerService;

        private void pbx_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbx_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void StartupSetting()
        {
            if(gbxSearch.Visible == false || dgwMain.Visible == false )
            gbxSearch.Visible = true;
            dgwMain.Visible = true;
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            StartupSetting();
            uc_CustomersSearch1.Visible = true;
            uc_CustomersSearch1.BringToFront();
            dgwMain.DataSource = _customerService.GetAll();
            
        }

        private void btn_Workers_Click(object sender, EventArgs e)
        {
            StartupSetting();
            uc_WorkersSearch1.Visible = true;
            uc_WorkersSearch1.BringToFront();
        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            StartupSetting();
            uc_RoomsSearch1.Visible = true;
            uc_RoomsSearch1.BringToFront();
        }

        private void btn_Tours_Click(object sender, EventArgs e)
        {
            StartupSetting();
            uc_ToursSearch1.Visible = true;
            uc_ToursSearch1.BringToFront();
        }

        private void btn_Reservations_Click(object sender, EventArgs e)
        {
            StartupSetting();
            uc_ReservationSearch1.Visible = true;
            uc_ReservationSearch1.BringToFront();
        }
    }
}
