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
    public partial class MyMovieInfo : Form
    {
        private DBHelper db = new DBHelper();
        private Movie temp;
        private User user;

        public MyMovieInfo(Movie newMovie, User newUser)
        {
            InitializeComponent();

            temp = newMovie;
            user = newUser;

            UpdateMovies();
        }

        

        private void UpdateMovies()
        {
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
        }

        private void btnRate1_Click(object sender, EventArgs e)
        {
            int rate = 1;

            db.DeleteUserMovie(temp, user);

            db.AddUserMovie(temp, user, rate);
            UpdateMovies();
        }

        private void btnRate2_Click(object sender, EventArgs e)
        {
            int rate = 2;

            db.DeleteUserMovie(temp, user);

            db.AddUserMovie(temp, user, rate);
            UpdateMovies();
        }

        private void btnRate3_Click(object sender, EventArgs e)
        {
            int rate = 3;

            db.DeleteUserMovie(temp, user);

            db.AddUserMovie(temp, user, rate);
            UpdateMovies();
        }

        private void btnRate4_Click(object sender, EventArgs e)
        {
            int rate = 4;

            db.DeleteUserMovie(temp, user);

            db.AddUserMovie(temp, user, rate);
            UpdateMovies();
        }

        private void brnRate5_Click(object sender, EventArgs e)
        {
            int rate = 5;

            db.DeleteUserMovie(temp, user);

            db.AddUserMovie(temp, user, rate);
            UpdateMovies();
        }

        private void brnRate6_Click(object sender, EventArgs e)
        {
            int rate = 6;

            db.DeleteUserMovie(temp, user);

            db.AddUserMovie(temp, user, rate);
            UpdateMovies();
        }

        private void brnRate7_Click(object sender, EventArgs e)
        {
            int rate = 7;

            db.DeleteUserMovie(temp, user);

            db.AddUserMovie(temp, user, rate);
            UpdateMovies();
        }

        private void brnRate8_Click(object sender, EventArgs e)
        {
            int rate = 8;

            db.DeleteUserMovie(temp, user);

            db.AddUserMovie(temp, user, rate);
            UpdateMovies();
        }

        private void brnRate9_Click(object sender, EventArgs e)
        {
            int rate = 9;

            db.DeleteUserMovie(temp, user);

            db.AddUserMovie(temp, user, rate);
            UpdateMovies();
        }

        private void brnRate10_Click(object sender, EventArgs e)
        {
            int rate = 10;

            db.DeleteUserMovie(temp, user);

            db.AddUserMovie(temp, user, rate);
            UpdateMovies();
        }



    }
}
