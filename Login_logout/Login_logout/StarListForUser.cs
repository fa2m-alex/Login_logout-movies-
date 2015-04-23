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
    public partial class StarListForUser : Form
    {
        private DBHelper db = new DBHelper();

        private Star star;

        private User user;

        public StarListForUser(User newUser)
        {
            InitializeComponent();

            user = newUser;

            UpdateStars();


        }

        private void UpdateStars()
        {
            comboBox1.DataSource = db.getStars();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            star = comboBox1.SelectedItem as Star;

            lblName.Text = "Name: " + star.Name;
            lblSecondName.Text = "Second name: " + star.SecondName;
            lblBirthday.Text = "Birthday: " + star.Birthday;
            lblCareer.Text = "Start of career: " + star.CareerDate;
            lblPlace.Text = "Place of birth: " + star.BornPlace;
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            StarMoviesPanel smp = new StarMoviesPanel(star);
            smp.Show();
        }

        private void btnAddToMyStars_Click(object sender, EventArgs e)
        {
            db.AddUserStar(star, user);

            MessageBox.Show("Star has been added to My Stars");
        }


    }
}
