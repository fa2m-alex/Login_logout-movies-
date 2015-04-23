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
    public partial class StarsList : Form
    {
        private DBHelper db = new DBHelper();

        private Star star;

        public StarsList()
        {
            InitializeComponent();

            UpdateStars();
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


        private void UpdateStars()
        {
            comboBox1.DataSource = db.getStars();
        }

        private void btnDeleteStar_Click(object sender, EventArgs e)
        {
            Star s = new Star();
            s = comboBox1.SelectedItem as Star;

            db.DeleteStar(s);

            MessageBox.Show("Star has been deleted");

            UpdateStars();
        }

        private void btnUpdateStar_Click(object sender, EventArgs e)
        {
            UpdateStarPanel usp = new UpdateStarPanel(star);
            usp.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("UpdateStarPanel"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }
        }

        private void btnGeneralUpdate_Click(object sender, EventArgs e)
        {
            UpdateStars();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            StarMoviesPanel smp = new StarMoviesPanel(star);
            smp.Show();
        }

        private void StarsList_Load(object sender, EventArgs e)
        {

        }

    }
}
