using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tables;

namespace Login_logout
{
    public partial class Main : Form
    {
        private User user;

        public Main(User u)
        {
            InitializeComponent();

            this.Text = u.Login + " - Main Menu";
            user = u;
            label.Text = "Hello, " + u.Login;
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
                        //Form1.Show();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("MoviesListForUser"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("MyMovies"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("MyMovieInfo"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("StarListForUser"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("MyStars"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            for (int i = 0; i < Application.OpenForms.Cast<Form>().ToList().Count; i++)
            {
                if (Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Name.Equals("ChangePassPanel"))
                {
                    Application.OpenForms.Cast<Form>().ToList().ToArray()[i].Close();
                }
            }

            Application.OpenForms.Cast<Form>().ToList().ToArray()[0].Show();

        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            MoviesListForUser mlfu = new MoviesListForUser(user);
            mlfu.Show();
        }

        private void btnMyMovies_Click(object sender, EventArgs e)
        {
            MyMovies mm = new MyMovies(user);
            mm.Show();
        }

        private void btnStars_Click(object sender, EventArgs e)
        {
            StarListForUser slfu = new StarListForUser(user);
            slfu.Show();
        }

        private void btnMyStars_Click(object sender, EventArgs e)
        {
            MyStars ms = new MyStars(user);
            ms.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassPanel cpp = new ChangePassPanel(user);
            cpp.Show();
        }  

        
    }
}
