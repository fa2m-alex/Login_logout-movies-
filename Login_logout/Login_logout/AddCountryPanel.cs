using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tables;
using DatabaseHelper;

namespace Login_logout
{
    public partial class AddCountryPanel : Form
    {
        private DBHelper db = new DBHelper();

        public AddCountryPanel()
        {
            InitializeComponent();

            UpdateCountries();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Country c = new Country();

            c.Country_name1 = txtCountry.Text;
            db.AddCountry(c);

            MessageBox.Show("Country has been added");

            UpdateCountries();

            txtCountry.Text = "";
        }

        private void UpdateCountries()
        {
            cmbCountry.DataSource = db.getCountries();

        }

        private void AddCountryPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Country c = new Country();
            c = cmbCountry.SelectedItem as Country;

            db.DeleteCountry(c);
            UpdateCountries();
        }
    }
}
