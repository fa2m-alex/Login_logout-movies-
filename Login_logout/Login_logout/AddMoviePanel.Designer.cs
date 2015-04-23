namespace Login_logout
{
    partial class AddMoviePanel
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxContrNames = new System.Windows.Forms.CheckedListBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtRotTom = new System.Windows.Forms.TextBox();
            this.lblRotTom = new System.Windows.Forms.Label();
            this.txtMetacritic = new System.Windows.Forms.TextBox();
            this.lblMetacritic = new System.Windows.Forms.Label();
            this.lblImdb = new System.Windows.Forms.Label();
            this.txtImdb = new System.Windows.Forms.TextBox();
            this.txtKinoPoisk = new System.Windows.Forms.TextBox();
            this.lblKinoPoisk = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chBoxGenres = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chBoxStudios = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(100, 10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(100, 37);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(13, 40);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(13, 67);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(100, 64);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxContrNames);
            this.groupBox1.Location = new System.Drawing.Point(16, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Countries";
            // 
            // chBoxContrNames
            // 
            this.chBoxContrNames.FormattingEnabled = true;
            this.chBoxContrNames.Location = new System.Drawing.Point(6, 20);
            this.chBoxContrNames.Name = "chBoxContrNames";
            this.chBoxContrNames.Size = new System.Drawing.Size(172, 109);
            this.chBoxContrNames.TabIndex = 0;
            this.chBoxContrNames.SelectedIndexChanged += new System.EventHandler(this.chBoxContrNames_SelectedIndexChanged);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(185, 418);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 7;
            this.btnAddMovie.Text = "Add movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(13, 94);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(55, 13);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age rating";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(100, 91);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 9;
            // 
            // txtRotTom
            // 
            this.txtRotTom.Location = new System.Drawing.Point(331, 91);
            this.txtRotTom.Name = "txtRotTom";
            this.txtRotTom.Size = new System.Drawing.Size(100, 20);
            this.txtRotTom.TabIndex = 17;
            // 
            // lblRotTom
            // 
            this.lblRotTom.AutoSize = true;
            this.lblRotTom.Location = new System.Drawing.Point(227, 94);
            this.lblRotTom.Name = "lblRotTom";
            this.lblRotTom.Size = new System.Drawing.Size(89, 13);
            this.lblRotTom.TabIndex = 16;
            this.lblRotTom.Text = "Rotten Tomatoes";
            // 
            // txtMetacritic
            // 
            this.txtMetacritic.Location = new System.Drawing.Point(331, 64);
            this.txtMetacritic.Name = "txtMetacritic";
            this.txtMetacritic.Size = new System.Drawing.Size(100, 20);
            this.txtMetacritic.TabIndex = 15;
            // 
            // lblMetacritic
            // 
            this.lblMetacritic.AutoSize = true;
            this.lblMetacritic.Location = new System.Drawing.Point(227, 67);
            this.lblMetacritic.Name = "lblMetacritic";
            this.lblMetacritic.Size = new System.Drawing.Size(53, 13);
            this.lblMetacritic.TabIndex = 14;
            this.lblMetacritic.Text = "Metacritic";
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.Location = new System.Drawing.Point(227, 40);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(33, 13);
            this.lblImdb.TabIndex = 13;
            this.lblImdb.Text = "IMDb";
            // 
            // txtImdb
            // 
            this.txtImdb.Location = new System.Drawing.Point(331, 37);
            this.txtImdb.Name = "txtImdb";
            this.txtImdb.Size = new System.Drawing.Size(100, 20);
            this.txtImdb.TabIndex = 12;
            // 
            // txtKinoPoisk
            // 
            this.txtKinoPoisk.Location = new System.Drawing.Point(331, 10);
            this.txtKinoPoisk.Name = "txtKinoPoisk";
            this.txtKinoPoisk.Size = new System.Drawing.Size(100, 20);
            this.txtKinoPoisk.TabIndex = 11;
            // 
            // lblKinoPoisk
            // 
            this.lblKinoPoisk.AutoSize = true;
            this.lblKinoPoisk.Location = new System.Drawing.Point(227, 13);
            this.lblKinoPoisk.Name = "lblKinoPoisk";
            this.lblKinoPoisk.Size = new System.Drawing.Size(64, 13);
            this.lblKinoPoisk.TabIndex = 10;
            this.lblKinoPoisk.Text = "КиноПоиск";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chBoxGenres);
            this.groupBox2.Location = new System.Drawing.Point(16, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 132);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genres";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chBoxGenres
            // 
            this.chBoxGenres.FormattingEnabled = true;
            this.chBoxGenres.Location = new System.Drawing.Point(6, 20);
            this.chBoxGenres.Name = "chBoxGenres";
            this.chBoxGenres.Size = new System.Drawing.Size(172, 109);
            this.chBoxGenres.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chBoxStudios);
            this.groupBox3.Location = new System.Drawing.Point(230, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 269);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Studios";
            // 
            // chBoxStudios
            // 
            this.chBoxStudios.FormattingEnabled = true;
            this.chBoxStudios.Location = new System.Drawing.Point(7, 20);
            this.chBoxStudios.Name = "chBoxStudios";
            this.chBoxStudios.Size = new System.Drawing.Size(187, 244);
            this.chBoxStudios.TabIndex = 0;
            // 
            // AddMoviePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtRotTom);
            this.Controls.Add(this.lblRotTom);
            this.Controls.Add(this.txtMetacritic);
            this.Controls.Add(this.lblMetacritic);
            this.Controls.Add(this.lblImdb);
            this.Controls.Add(this.txtImdb);
            this.Controls.Add(this.txtKinoPoisk);
            this.Controls.Add(this.lblKinoPoisk);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddMoviePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMoviePanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chBoxContrNames;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtRotTom;
        private System.Windows.Forms.Label lblRotTom;
        private System.Windows.Forms.TextBox txtMetacritic;
        private System.Windows.Forms.Label lblMetacritic;
        private System.Windows.Forms.Label lblImdb;
        private System.Windows.Forms.TextBox txtImdb;
        private System.Windows.Forms.TextBox txtKinoPoisk;
        private System.Windows.Forms.Label lblKinoPoisk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox chBoxGenres;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox chBoxStudios;
    }
}