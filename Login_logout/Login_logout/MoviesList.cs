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
    public partial class MoviesList : Form
    {
        private DBHelper db = new DBHelper();

        private Movie temp;

        public MoviesList()
        {
            InitializeComponent();

            UpdateMovies();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ResetCombo();
           

            temp = comboBox1.SelectedItem as Movie;

            double avRating = 0;

            /**************************/
            if (db.CountRatingsForMovie(temp) > 0)
            {
                avRating = db.getAvRatingForMovie(temp);
            }

            lblAvRating.Text = "Average rating: " + avRating;

            lblTitle.Text = "Title: " + temp.Title;
            lblYear.Text = "Year: " + temp.Year;
            lblDuration.Text = "Duration: " + temp.Duration + " minutes";
            lblKinoPoisk.Text = "КиноПоиск: " + temp.KinoPoisk + "/10";
            lblImdb.Text = "IMDb: " + temp.Imdb + "/10";
            lblMetacritic.Text = "Metacritic: " + temp.Metacritic + "/100";
            lblRotTom.Text = "RottenTomatoes: " + temp.RottentTomatoes + "/100";
            lblAge.Text = "Age: " + temp.Age + "+";

            lblCountries.Text = "Countries: ";

            foreach (Country c in db.getCountriesByMovie(temp).ToArray())
            {
                lblCountries.Text += c.Country_name1 + " ";
            }

            lblGenres.Text = "Genres: ";

            foreach (Genre g in db.getGenresByMovie(temp).ToArray())
            {
                lblGenres.Text += g.GenreName + " ";
            }

            lblStudios.Text = "Studios: ";

            foreach (Studio s in db.getStudiosByMovie(temp).ToArray())
            {
                lblStudios.Text += s.StudioName + " ";
            }

            UpdateStars();
            
        }

        private void UpdateMovies()
        {
            comboBox1.DataSource = db.getMovies();

           

        }

        private void ResetCombo()
        {
            comboDir.ResetText();
            comboAct.ResetText();
            comboEd.ResetText();
            comboPro.ResetText();
            comboOp.ResetText();
            comboComp.ResetText();
        }

        private void UpdateStars()
        {
            comboDir.DataSource = db.getStarWithRole(temp, "director");
            comboAct.DataSource = db.getStarWithRole(temp, "actor");
            comboPro.DataSource = db.getStarWithRole(temp, "producer");
            comboEd.DataSource = db.getStarWithRole(temp, "editor");
            comboOp.DataSource = db.getStarWithRole(temp, "operator");
            comboComp.DataSource = db.getStarWithRole(temp, "composer");
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            Movie m = new Movie();
            m = comboBox1.SelectedItem as Movie;

            db.DeleteMovie(m);

            MessageBox.Show("Movie has been deleted");

            UpdateMovies();
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            UpdateMoviePanel ump = new UpdateMoviePanel(temp);
            ump.Show();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("UpdateMoviePanel"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("StarInfo"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }
        }

        private void btnGeneralUpdate_Click(object sender, EventArgs e)
        {
            UpdateMovies();
        }

        private void btnDirInfo_Click(object sender, EventArgs e)
        {
            StarInfo si = new StarInfo(comboDir.SelectedItem as Star);
            si.Show();
        }

        private void btnActInfo_Click(object sender, EventArgs e)
        {
            StarInfo si = new StarInfo(comboAct.SelectedItem as Star);
            si.Show();
        }

        private void btnProInfo_Click(object sender, EventArgs e)
        {
            StarInfo si = new StarInfo(comboPro.SelectedItem as Star);
            si.Show();
        }

        private void btnOpInfo_Click(object sender, EventArgs e)
        {
            StarInfo si = new StarInfo(comboOp.SelectedItem as Star);
            si.Show();
        }

        private void btnEdInfo_Click(object sender, EventArgs e)
        {
            StarInfo si = new StarInfo(comboEd.SelectedItem as Star);
            si.Show();
        }

        private void btnCompInfo_Click(object sender, EventArgs e)
        {
            StarInfo si = new StarInfo(comboComp.SelectedItem as Star);
            si.Show();
        }

        private void btnDelDir_Click(object sender, EventArgs e)
        {
            db.DeleteStarFromMovie(temp, comboDir.SelectedItem as Star, "director");
            MessageBox.Show("Director has been deleted from the movie: " + temp);
            UpdateStars();
        }

        private void btnDelAct_Click(object sender, EventArgs e)
        {
            db.DeleteStarFromMovie(temp, comboAct.SelectedItem as Star, "actor");
            MessageBox.Show("Actor has been deleted from the movie: " + temp);
            UpdateStars();
        }

        private void btnDelPro_Click(object sender, EventArgs e)
        {
            db.DeleteStarFromMovie(temp, comboPro.SelectedItem as Star, "producer");
            MessageBox.Show("Producer has been deleted from the movie: " + temp);
            UpdateStars();
        }

        private void btnDelOp_Click(object sender, EventArgs e)
        {
            db.DeleteStarFromMovie(temp, comboOp.SelectedItem as Star, "operator");
            MessageBox.Show("Operator has been deleted from the movie: " + temp);
            UpdateStars();
        }

        private void btnDelEd_Click(object sender, EventArgs e)
        {
            db.DeleteStarFromMovie(temp, comboEd.SelectedItem as Star, "editor");
            MessageBox.Show("Editor has been deleted from the movie: " + temp);
            UpdateStars();
        }

        private void btnDelComp_Click(object sender, EventArgs e)
        {
            db.DeleteStarFromMovie(temp, comboComp.SelectedItem as Star, "composer");
            MessageBox.Show("Composer has been deleted from the movie: " + temp);
            UpdateStars();
        }



    }
}
