using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.UserControls
{
    public partial class uc_CustomersSearch : UserControl
    {
        public uc_CustomersSearch()
        {
            InitializeComponent();
        }

        private void uc_CustomersSearch_Load(object sender, EventArgs e)
        {
            LoadCbxIsAdult();
        }

        private void LoadCbxIsAdult()
        {
            Dictionary<string, bool> Items = new Dictionary<string, bool>();
            Items.Add("Evet", true);
            Items.Add("Hayır", false);

            cbx_IsAdult.DataSource = new BindingSource(Items, null);
            cbx_IsAdult.DisplayMember = "Key";
            cbx_IsAdult.ValueMember = "Value";
        }

        public ComboBox GetCbx_IsAdult()
        {
            return cbx_IsAdult;
        }

    }
}
