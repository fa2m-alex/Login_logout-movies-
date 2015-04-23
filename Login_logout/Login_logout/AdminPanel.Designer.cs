namespace Login_logout
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnStars = new System.Windows.Forms.Button();
            this.btnAddStar = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnAddStudio = new System.Windows.Forms.Button();
            this.grBoxAdmin = new System.Windows.Forms.GroupBox();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAddStarsToMovie = new System.Windows.Forms.Button();
            this.grBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMovies
            // 
            this.btnMovies.Location = new System.Drawing.Point(6, 19);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(225, 23);
            this.btnMovies.TabIndex = 0;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(6, 48);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(225, 23);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.Text = "Add movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Location = new System.Drawing.Point(6, 166);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(225, 23);
            this.btnAddCountry.TabIndex = 3;
            this.btnAddCountry.Text = "Add country";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(197, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnStars
            // 
            this.btnStars.Location = new System.Drawing.Point(6, 107);
            this.btnStars.Name = "btnStars";
            this.btnStars.Size = new System.Drawing.Size(225, 23);
            this.btnStars.TabIndex = 5;
            this.btnStars.Text = "Stars";
            this.btnStars.UseVisualStyleBackColor = true;
            this.btnStars.Click += new System.EventHandler(this.btnStars_Click);
            // 
            // btnAddStar
            // 
            this.btnAddStar.Location = new System.Drawing.Point(6, 137);
            this.btnAddStar.Name = "btnAddStar";
            this.btnAddStar.Size = new System.Drawing.Size(225, 23);
            this.btnAddStar.TabIndex = 6;
            this.btnAddStar.Text = "Add star";
            this.btnAddStar.UseVisualStyleBackColor = true;
            this.btnAddStar.Click += new System.EventHandler(this.btnAddStar_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(6, 196);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(225, 23);
            this.btnAddGenre.TabIndex = 7;
            this.btnAddGenre.Text = "Add genre";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnAddStudio
            // 
            this.btnAddStudio.Location = new System.Drawing.Point(6, 226);
            this.btnAddStudio.Name = "btnAddStudio";
            this.btnAddStudio.Size = new System.Drawing.Size(225, 23);
            this.btnAddStudio.TabIndex = 8;
            this.btnAddStudio.Text = "Add studio";
            this.btnAddStudio.UseVisualStyleBackColor = true;
            this.btnAddStudio.Click += new System.EventHandler(this.btnAddStudio_Click);
            // 
            // grBoxAdmin
            // 
            this.grBoxAdmin.Controls.Add(this.btnAddStarsToMovie);
            this.grBoxAdmin.Controls.Add(this.btnUsers);
            this.grBoxAdmin.Controls.Add(this.btnMovies);
            this.grBoxAdmin.Controls.Add(this.btnAddStudio);
            this.grBoxAdmin.Controls.Add(this.btnAddMovie);
            this.grBoxAdmin.Controls.Add(this.btnAddGenre);
            this.grBoxAdmin.Controls.Add(this.btnAddCountry);
            this.grBoxAdmin.Controls.Add(this.btnAddStar);
            this.grBoxAdmin.Controls.Add(this.btnStars);
            this.grBoxAdmin.Location = new System.Drawing.Point(41, 73);
            this.grBoxAdmin.Name = "grBoxAdmin";
            this.grBoxAdmin.Size = new System.Drawing.Size(242, 287);
            this.grBoxAdmin.TabIndex = 9;
            this.grBoxAdmin.TabStop = false;
            this.grBoxAdmin.Text = "Admin Menu";
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(7, 256);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(224, 23);
            this.btnUsers.TabIndex = 9;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnAddStarsToMovie
            // 
            this.btnAddStarsToMovie.Location = new System.Drawing.Point(7, 78);
            this.btnAddStarsToMovie.Name = "btnAddStarsToMovie";
            this.btnAddStarsToMovie.Size = new System.Drawing.Size(224, 23);
            this.btnAddStarsToMovie.TabIndex = 10;
            this.btnAddStarsToMovie.Text = "Add stars to movie";
            this.btnAddStarsToMovie.UseVisualStyleBackColor = true;
            this.btnAddStarsToMovie.Click += new System.EventHandler(this.btnAddStarsToMovie_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 372);
            this.Controls.Add(this.grBoxAdmin);
            this.Controls.Add(this.btnLogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.grBoxAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnStars;
        private System.Windows.Forms.Button btnAddStar;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnAddStudio;
        private System.Windows.Forms.GroupBox grBoxAdmin;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnAddStarsToMovie;
    }
}