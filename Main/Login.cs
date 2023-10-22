using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Main.UserControls;
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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            _workerService = new WorkerManager(new WorkerDal());
        }

        private IWorkerService _workerService;

        private void pbx_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Worker worker = _workerService.GetByUserName(tbx_UserName.Text);
            if(worker != null && tbx_Password.Text==worker.Password)
            {
                lbl_ErrorText.Visible = false;
                Dashboard ds = new Dashboard();
                this.Hide();
                if(worker.Position)
                {
                    uc_Customer myUcCustomer = ds.GetUcCustomer();
                    myUcCustomer.ChangeVisibleGbxADU();
                }
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
