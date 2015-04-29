using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseHelper;
using Tables;

namespace Login_logout
{
    public partial class AddStarPanel : Form
    {
        DBHelper db = new DBHelper();

        public AddStarPanel()
        {
            InitializeComponent();

            StartValues();
        }

        private void btnAddStar_Click(object sender, EventArgs e)
        {
            Star star = new Star();

            star.Name = txtName.Text;
            star.SecondName = txtSecondName.Text;
            star.Birthday = txtBirthday.Text;
            star.CareerDate = Convert.ToInt32(txtCareer.Text);
            star.BornPlace = txtPlace.Text;

            db.AddStar(star);

            MessageBox.Show("Star has been added");
            StartValues();
        }

        private void StartValues()
        {
            txtName.Text = "";
            txtSecondName.Text = "";
            txtBirthday.Text = "";
            txtCareer.Text = "";
            txtPlace.Text = "";
        }

    }
}
