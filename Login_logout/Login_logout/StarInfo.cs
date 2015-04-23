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
    public partial class StarInfo : Form
    {
        private DBHelper db = new DBHelper();

        private Star star;

        public StarInfo(Star newStar)
        {
            InitializeComponent();

            star = newStar;

            UpdateInfo();
        }

        private void UpdateInfo()
        {
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
    }
}
