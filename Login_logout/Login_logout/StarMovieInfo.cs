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
    public partial class StarMovieInfo : Form
    {
        private DBHelper db = new DBHelper();
        private Movie temp;
        private Star star;

        public StarMovieInfo(Movie newMovie, Star newStar)
        {
            InitializeComponent();

            temp = newMovie;
            star = newStar;

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
    }
}
