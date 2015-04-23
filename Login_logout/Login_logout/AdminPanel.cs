using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_logout
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("AddMoviePanel"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("MoviesList"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("AddStarsToMovie"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("AddCountryPanel"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("AddGenrePanel"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("AddStudioPanel"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("AddStarPanel"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("StarsList"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("UsersList"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

                Application.OpenForms.Cast<Form>().ToList().ToArray()[0].Show();

            

        }  

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (f.Name != "Form1")
                    {
                        f.Close();
                    }
                    else
                    {
                        f.Show();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            MoviesList ml = new MoviesList();
            ml.Show();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMoviePanel amp = new AddMoviePanel();
            amp.Show();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            AddCountryPanel acp = new AddCountryPanel();
            acp.Show();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            AddGenrePanel agp = new AddGenrePanel();
            agp.Show();
        }

        private void btnAddStudio_Click(object sender, EventArgs e)
        {
            AddStudioPanel asp = new AddStudioPanel();
            asp.Show();
        }

        private void btnAddStar_Click(object sender, EventArgs e)
        {
            AddStarPanel asp = new AddStarPanel();
            asp.Show();
        }

        private void btnStars_Click(object sender, EventArgs e)
        {
            StarsList sl = new StarsList();
            sl.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersList ul = new UsersList();
            ul.Show();
        }

        private void btnAddStarsToMovie_Click(object sender, EventArgs e)
        {
            AddStarsToMovie astm = new AddStarsToMovie();
            astm.Show();
        }


    }
}
