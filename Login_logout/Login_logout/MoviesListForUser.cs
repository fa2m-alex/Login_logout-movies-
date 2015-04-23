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
    public partial class MoviesListForUser : Form
    {
        private DBHelper db = new DBHelper();
        private Movie temp;

        private User user;

        public MoviesListForUser(User newUser)
        {
            InitializeComponent();

            user = newUser;

            UpdateMovies();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("StarInfo"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }
        }

        private void UpdateMovies()
        {
            comboBox1.DataSource = db.getMovies();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp = comboBox1.SelectedItem as Movie;

            double avRating = 0;

            /**************************/
            if (db.CountRatingsForMovie(temp) > 0)
            {
                avRating = db.getAvRatingForMovie(temp);
            }

            lblAvRating.Text = "Average rating: " + avRating;

          
            
            /****************************/

            lblTitle.Text = "Title: " + temp.Title;
            lblYear.Text = "Year: " + temp.Year;
            lblDuration.Text = "Duration: " + temp.Duration + " minutes";

            lblKinoPoisk.Text = "КиноПоиск: " + temp.KinoPoisk + "/10";
            lblImdb.Text = "IMDb: " + temp.Imdb + "/10";
            lblMetacritic.Text = "Metacritic: " + temp.Metacritic + "/100";
            lblRotTom.Text = "RottenTomatoes: " + temp.RottentTomatoes + "/100";
            lblAge.Text = "Age: " + temp.Age + "+";

            lblMyRating.Text = "My rating: " + db.getUserRating(temp, user);

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


            comboDir.DataSource = db.getStarWithRole(temp, "director");
            comboAct.DataSource = db.getStarWithRole(temp, "actor");
            comboPro.DataSource = db.getStarWithRole(temp, "producer");
            comboEd.DataSource = db.getStarWithRole(temp, "editor");
            comboOp.DataSource = db.getStarWithRole(temp, "operator");
            comboComp.DataSource = db.getStarWithRole(temp, "composer");
        }

        private void btnGeneralUpdate_Click(object sender, EventArgs e)
        {
            UpdateMovies();
        }


        /*********************************/
        private void btnRate1_Click(object sender, EventArgs e)
        {
            int rate = 1;

            Movie m = new Movie();
            m = comboBox1.SelectedItem as Movie;

            db.DeleteUserMovie(m, user);

            db.AddUserMovie(m, user, rate);
            UpdateMovies();
        }

        private void btnRate2_Click(object sender, EventArgs e)
        {
            int rate = 2;

            Movie m = new Movie();
            m = comboBox1.SelectedItem as Movie;

            db.DeleteUserMovie(m, user);
            db.AddUserMovie(m, user, rate);
            UpdateMovies();
        }

        private void btnRate3_Click(object sender, EventArgs e)
        {
            int rate = 3;

            Movie m = new Movie();
            m = comboBox1.SelectedItem as Movie;

            db.DeleteUserMovie(m, user);
            db.AddUserMovie(m, user, rate);
            UpdateMovies();
        }

        private void btnRate4_Click(object sender, EventArgs e)
        {
            int rate = 4;

            Movie m = new Movie();
            m = comboBox1.SelectedItem as Movie;

            db.DeleteUserMovie(m, user);
            db.AddUserMovie(m, user, rate);
            UpdateMovies();
        }

        private void brnRate5_Click(object sender, EventArgs e)
        {
            int rate = 5;

            Movie m = new Movie();
            m = comboBox1.SelectedItem as Movie;

            db.DeleteUserMovie(m, user);
            db.AddUserMovie(m, user, rate);
            UpdateMovies();
        }

        private void brnRate6_Click(object sender, EventArgs e)
        {
            int rate = 6;

            Movie m = new Movie();
            m = comboBox1.SelectedItem as Movie;

            db.DeleteUserMovie(m, user);
            db.AddUserMovie(m, user, rate);
            UpdateMovies();
        }

        private void brnRate7_Click(object sender, EventArgs e)
        {
            int rate = 7;

            Movie m = new Movie();
            m = comboBox1.SelectedItem as Movie;

            db.DeleteUserMovie(m, user);
            db.AddUserMovie(m, user, rate);
            UpdateMovies();
        }

        private void brnRate8_Click(object sender, EventArgs e)
        {
            int rate = 8;

            Movie m = new Movie();
            m = comboBox1.SelectedItem as Movie;

            db.DeleteUserMovie(m, user);
            db.AddUserMovie(m, user, rate);
            UpdateMovies();
        }

        private void brnRate9_Click(object sender, EventArgs e)
        {
            int rate = 9;

            Movie m = new Movie();
            m = comboBox1.SelectedItem as Movie;

            db.DeleteUserMovie(m, user);
            db.AddUserMovie(m, user, rate);
            UpdateMovies();
        }

        private void brnRate10_Click(object sender, EventArgs e)
        {
            int rate = 10;

            Movie m = new Movie();
            m = comboBox1.SelectedItem as Movie;

            db.DeleteUserMovie(m, user);
            db.AddUserMovie(m, user, rate);
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
        /********************************/


    }
}
