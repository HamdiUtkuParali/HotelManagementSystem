using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Main.UserControls
{
    public partial class uc_Customer : UserControl
    {
        public uc_Customer()
        {
            InitializeComponent();
            _customerService = new CustomerManager(new CustomerDal());
            
        }
        private ICustomerService _customerService;


        private void uc_Customer_Load(object sender, EventArgs e)
        {
        }

        public void LoadCustomers()
        {
            dgw_Customers.DataSource = _customerService.GetAll();
        }

        public void LoadBoolList()
        {
            Dictionary<string, bool> MyDictionary = new Dictionary<string, bool>();
            MyDictionary.Add("Evet", true);
            MyDictionary.Add("Hayır", false);
            cbx_SearchIsAdult.DataSource = new BindingSource(MyDictionary, null);
            cbx_SearchIsAdult.DisplayMember = "Key";
            cbx_SearchIsAdult.ValueMember = "Value";
            cbx_IsAdult.DataSource = new BindingSource(MyDictionary, null);
            cbx_IsAdult.DisplayMember= "Key";
            cbx_IsAdult.ValueMember= "Value";
        }

        public void LoadOperationList()
        {
            Dictionary<string,string> MyDictionary = new Dictionary<string,string>();
            MyDictionary.Add("Ekle", "Add");
            MyDictionary.Add("Sil", "Delete");
            MyDictionary.Add("Güncelle", "Update");
            cbx_Operation.DataSource = new BindingSource(MyDictionary, null);
            cbx_Operation.DisplayMember = "Key";
            cbx_Operation.ValueMember = "Value";
        }

        private void cbx_SearchIsAdult_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgw_Customers.DataSource = _customerService.GetByIsAdult(Convert.ToBoolean(cbx_SearchIsAdult.SelectedValue));
            }
            catch { }
        }

        private void tbx_SearchName_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbx_SearchName.Text))
            {
                dgw_Customers.DataSource = _customerService.GetByName(tbx_SearchName.Text);
            }
            else
            {
                LoadCustomers();
            }
        }

        private void btn_Okey_Click(object sender, EventArgs e)
        {
            string Operation = Convert.ToString(cbx_Operation.SelectedValue);
            
            if(!(String.IsNullOrEmpty(tbx_Name.Text)) && !(String.IsNullOrEmpty(tbx_TourId.Text)))
            {
                switch (Operation)
                {
                    case "Add":
                        _customerService.Add(new Customer
                        {
                            Name = tbx_Name.Text,
                            TcNo = Convert.ToInt64(tbx_TcNo.Text),
                            IsAdult = Convert.ToBoolean(cbx_IsAdult.SelectedValue),
                            PhoneNo = (String.IsNullOrEmpty(tbx_PhoneNo.Text)) ? 0 : Convert.ToInt64(tbx_PhoneNo.Text),
                            RoomNo = (String.IsNullOrEmpty(tbx_RoomNo.Text)) ? 0 : Convert.ToInt32(tbx_RoomNo.Text),
                            TourId = (String.IsNullOrEmpty(tbx_TourId.Text)) ? 0 : Convert.ToInt32(tbx_TourId.Text)
                        }
                        );
                        LoadCustomers();
                        break;
                    case "Delete":
                        _customerService.Delete(new Customer
                        {
                            Id = Convert.ToInt32(dgw_Customers.CurrentRow.Cells[0].Value)
                        });
                        LoadCustomers();
                        break;
                    case "Update":
                        _customerService.Update(new Customer
                        {
                            Id = Convert.ToInt32(dgw_Customers.CurrentRow.Cells[0].Value),
                            Name = tbx_Name.Text,
                            TcNo = Convert.ToInt64(tbx_TcNo.Text),
                            IsAdult = Convert.ToBoolean(cbx_IsAdult.SelectedValue),
                            PhoneNo = (String.IsNullOrEmpty(tbx_PhoneNo.Text)) ? 0 : Convert.ToInt64(tbx_PhoneNo.Text),
                            RoomNo = (String.IsNullOrEmpty(tbx_RoomNo.Text)) ? 0 : Convert.ToInt32(tbx_RoomNo.Text),
                            TourId = (String.IsNullOrEmpty(tbx_TourId.Text)) ? 0 : Convert.ToInt32(tbx_TourId.Text)
                        });
                        LoadCustomers();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Boş alanları doldurun");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbx_Name.Clear();
            tbx_TcNo.Clear();
            tbx_PhoneNo.Clear();
            tbx_RoomNo.Clear();
            tbx_TourId.Clear();
        }

        private void dgw_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgw_Customers.CurrentRow;
            tbx_Name.Text = row.Cells[1].Value.ToString();
            tbx_TcNo.Text = row.Cells[2].Value.ToString();
            cbx_IsAdult.SelectedValue = row.Cells[3].Value;
            tbx_PhoneNo.Text = (row.Cells[4].Value == null) ? "" : row.Cells[4].Value.ToString();
            tbx_RoomNo.Text = (row.Cells[5].Value == null) ? "" : row.Cells[5].Value.ToString();
            tbx_TourId.Text = (row.Cells[6].Value == null) ? "" : row.Cells[6].Value.ToString();

        }

        public void ChangeVisibleGbxADU()
        {
            gbx_ADU.Visible = true;
        }
    }
}
