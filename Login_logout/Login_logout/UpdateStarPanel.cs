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
    public partial class UpdateStarPanel : Form
    {
        DBHelper db = new DBHelper();
        Star star;

        public UpdateStarPanel(Star newStar)
        {
            InitializeComponent();

            star = newStar;

            FillFields();
        }

        private void btnUpdateStar_Click(object sender, EventArgs e)
        {
            Star newStar = new Star();

            newStar.Name = txtName.Text;
            newStar.SecondName = txtSecondName.Text;
            newStar.Birthday = txtBirthday.Text;
            newStar.CareerDate = Convert.ToInt32(txtCareer.Text);
            newStar.BornPlace = txtPlace.Text;

            db.UpdateStar(star, newStar);

            MessageBox.Show("Star has been updated");
        }

        private void FillFields()
        {
            txtName.Text = star.Name;
            txtSecondName.Text = star.SecondName;
            txtBirthday.Text = star.Birthday;
            txtCareer.Text = "" + star.CareerDate;
            txtPlace.Text = star.BornPlace;
        }
    }
}
