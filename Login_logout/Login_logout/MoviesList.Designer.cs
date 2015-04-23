namespace Login_logout
{
    partial class MoviesList
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
            this.chooseMov = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.movInfo = new System.Windows.Forms.GroupBox();
            this.lblStudios = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblRotTom = new System.Windows.Forms.Label();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblMetacritic = new System.Windows.Forms.Label();
            this.lblImdb = new System.Windows.Forms.Label();
            this.lblKinoPoisk = new System.Windows.Forms.Label();
            this.lblAvRating = new System.Windows.Forms.Label();
            this.lblCountries = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnGeneralUpdate = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboComp = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboEd = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboOp = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboPro = new System.Windows.Forms.ComboBox();
            this.btnProInfo = new System.Windows.Forms.Button();
            this.btnDelPro = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboAct = new System.Windows.Forms.ComboBox();
            this.btnActInfo = new System.Windows.Forms.Button();
            this.btnDelAct = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboDir = new System.Windows.Forms.ComboBox();
            this.btnDirInfo = new System.Windows.Forms.Button();
            this.btnDelDir = new System.Windows.Forms.Button();
            this.btnOpInfo = new System.Windows.Forms.Button();
            this.btnEdInfo = new System.Windows.Forms.Button();
            this.btnCompInfo = new System.Windows.Forms.Button();
            this.btnDelOp = new System.Windows.Forms.Button();
            this.btnDelEd = new System.Windows.Forms.Button();
            this.btnDelComp = new System.Windows.Forms.Button();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.chooseMov.SuspendLayout();
            this.movInfo.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseMov
            // 
            this.chooseMov.Controls.Add(this.comboBox1);
            this.chooseMov.Location = new System.Drawing.Point(17, 12);
            this.chooseMov.Name = "chooseMov";
            this.chooseMov.Size = new System.Drawing.Size(387, 56);
            this.chooseMov.TabIndex = 0;
            this.chooseMov.TabStop = false;
            this.chooseMov.Text = "Choose the movie";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // movInfo
            // 
            this.movInfo.Controls.Add(this.lblStudios);
            this.movInfo.Controls.Add(this.lblAge);
            this.movInfo.Controls.Add(this.lblRotTom);
            this.movInfo.Controls.Add(this.lblGenres);
            this.movInfo.Controls.Add(this.lblMetacritic);
            this.movInfo.Controls.Add(this.lblImdb);
            this.movInfo.Controls.Add(this.lblKinoPoisk);
            this.movInfo.Controls.Add(this.lblAvRating);
            this.movInfo.Controls.Add(this.lblCountries);
            this.movInfo.Controls.Add(this.lblDuration);
            this.movInfo.Controls.Add(this.lblYear);
            this.movInfo.Controls.Add(this.lblTitle);
            this.movInfo.Location = new System.Drawing.Point(17, 83);
            this.movInfo.Name = "movInfo";
            this.movInfo.Size = new System.Drawing.Size(386, 287);
            this.movInfo.TabIndex = 1;
            this.movInfo.TabStop = false;
            this.movInfo.Text = "Movie info";
            // 
            // lblStudios
            // 
            this.lblStudios.AutoSize = true;
            this.lblStudios.Location = new System.Drawing.Point(7, 131);
            this.lblStudios.Name = "lblStudios";
            this.lblStudios.Size = new System.Drawing.Size(48, 13);
            this.lblStudios.TabIndex = 11;
            this.lblStudios.Text = "Studios: ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(7, 263);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 13);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Age: ";
            // 
            // lblRotTom
            // 
            this.lblRotTom.AutoSize = true;
            this.lblRotTom.Location = new System.Drawing.Point(7, 241);
            this.lblRotTom.Name = "lblRotTom";
            this.lblRotTom.Size = new System.Drawing.Size(95, 13);
            this.lblRotTom.TabIndex = 9;
            this.lblRotTom.Text = "Rotten Tomatoes: ";
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Location = new System.Drawing.Point(7, 109);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(47, 13);
            this.lblGenres.TabIndex = 8;
            this.lblGenres.Text = "Genres: ";
            // 
            // lblMetacritic
            // 
            this.lblMetacritic.AutoSize = true;
            this.lblMetacritic.Location = new System.Drawing.Point(7, 219);
            this.lblMetacritic.Name = "lblMetacritic";
            this.lblMetacritic.Size = new System.Drawing.Size(59, 13);
            this.lblMetacritic.TabIndex = 7;
            this.lblMetacritic.Text = "Metacritic: ";
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.Location = new System.Drawing.Point(7, 197);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(39, 13);
            this.lblImdb.TabIndex = 6;
            this.lblImdb.Text = "IMDb: ";
            // 
            // lblKinoPoisk
            // 
            this.lblKinoPoisk.AutoSize = true;
            this.lblKinoPoisk.Location = new System.Drawing.Point(7, 175);
            this.lblKinoPoisk.Name = "lblKinoPoisk";
            this.lblKinoPoisk.Size = new System.Drawing.Size(70, 13);
            this.lblKinoPoisk.TabIndex = 5;
            this.lblKinoPoisk.Text = "КиноПоиск: ";
            // 
            // lblAvRating
            // 
            this.lblAvRating.AutoSize = true;
            this.lblAvRating.Location = new System.Drawing.Point(7, 153);
            this.lblAvRating.Name = "lblAvRating";
            this.lblAvRating.Size = new System.Drawing.Size(82, 13);
            this.lblAvRating.TabIndex = 4;
            this.lblAvRating.Text = "Avarage rating: ";
            // 
            // lblCountries
            // 
            this.lblCountries.AutoSize = true;
            this.lblCountries.Location = new System.Drawing.Point(7, 87);
            this.lblCountries.Name = "lblCountries";
            this.lblCountries.Size = new System.Drawing.Size(57, 13);
            this.lblCountries.TabIndex = 3;
            this.lblCountries.Text = "Countries: ";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(7, 65);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(53, 13);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration: ";
            this.lblDuration.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(7, 42);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(35, 13);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(7, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title: ";
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(17, 376);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteMovie.TabIndex = 2;
            this.btnDeleteMovie.Text = "Delete movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(112, 376);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(85, 23);
            this.btnUpdateMovie.TabIndex = 3;
            this.btnUpdateMovie.Text = "Update movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnGeneralUpdate
            // 
            this.btnGeneralUpdate.Location = new System.Drawing.Point(314, 376);
            this.btnGeneralUpdate.Name = "btnGeneralUpdate";
            this.btnGeneralUpdate.Size = new System.Drawing.Size(90, 23);
            this.btnGeneralUpdate.TabIndex = 4;
            this.btnGeneralUpdate.Text = "General update";
            this.btnGeneralUpdate.UseVisualStyleBackColor = true;
            this.btnGeneralUpdate.Click += new System.EventHandler(this.btnGeneralUpdate_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.comboComp);
            this.groupBox9.Location = new System.Drawing.Point(430, 410);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(274, 62);
            this.groupBox9.TabIndex = 30;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Composers";
            // 
            // comboComp
            // 
            this.comboComp.FormattingEnabled = true;
            this.comboComp.Location = new System.Drawing.Point(7, 20);
            this.comboComp.Name = "comboComp";
            this.comboComp.Size = new System.Drawing.Size(261, 21);
            this.comboComp.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboEd);
            this.groupBox8.Location = new System.Drawing.Point(430, 346);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(274, 58);
            this.groupBox8.TabIndex = 29;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Editors";
            // 
            // comboEd
            // 
            this.comboEd.FormattingEnabled = true;
            this.comboEd.Location = new System.Drawing.Point(7, 20);
            this.comboEd.Name = "comboEd";
            this.comboEd.Size = new System.Drawing.Size(261, 21);
            this.comboEd.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboOp);
            this.groupBox7.Location = new System.Drawing.Point(430, 277);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(274, 63);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Operators";
            // 
            // comboOp
            // 
            this.comboOp.FormattingEnabled = true;
            this.comboOp.Location = new System.Drawing.Point(7, 19);
            this.comboOp.Name = "comboOp";
            this.comboOp.Size = new System.Drawing.Size(261, 21);
            this.comboOp.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboPro);
            this.groupBox6.Controls.Add(this.btnProInfo);
            this.groupBox6.Controls.Add(this.btnDelPro);
            this.groupBox6.Location = new System.Drawing.Point(430, 192);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(274, 79);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Producers";
            // 
            // comboPro
            // 
            this.comboPro.FormattingEnabled = true;
            this.comboPro.Location = new System.Drawing.Point(7, 20);
            this.comboPro.Name = "comboPro";
            this.comboPro.Size = new System.Drawing.Size(261, 21);
            this.comboPro.TabIndex = 0;
            // 
            // btnProInfo
            // 
            this.btnProInfo.Location = new System.Drawing.Point(7, 47);
            this.btnProInfo.Name = "btnProInfo";
            this.btnProInfo.Size = new System.Drawing.Size(75, 20);
            this.btnProInfo.TabIndex = 33;
            this.btnProInfo.Text = "Info";
            this.btnProInfo.UseVisualStyleBackColor = true;
            this.btnProInfo.Click += new System.EventHandler(this.btnProInfo_Click);
            // 
            // btnDelPro
            // 
            this.btnDelPro.Location = new System.Drawing.Point(88, 47);
            this.btnDelPro.Name = "btnDelPro";
            this.btnDelPro.Size = new System.Drawing.Size(75, 20);
            this.btnDelPro.TabIndex = 39;
            this.btnDelPro.Text = "Del";
            this.btnDelPro.UseVisualStyleBackColor = true;
            this.btnDelPro.Click += new System.EventHandler(this.btnDelPro_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboAct);
            this.groupBox5.Controls.Add(this.btnActInfo);
            this.groupBox5.Controls.Add(this.btnDelAct);
            this.groupBox5.Location = new System.Drawing.Point(430, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 80);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actors";
            // 
            // comboAct
            // 
            this.comboAct.FormattingEnabled = true;
            this.comboAct.Location = new System.Drawing.Point(7, 20);
            this.comboAct.Name = "comboAct";
            this.comboAct.Size = new System.Drawing.Size(261, 21);
            this.comboAct.TabIndex = 0;
            // 
            // btnActInfo
            // 
            this.btnActInfo.Location = new System.Drawing.Point(7, 47);
            this.btnActInfo.Name = "btnActInfo";
            this.btnActInfo.Size = new System.Drawing.Size(75, 24);
            this.btnActInfo.TabIndex = 32;
            this.btnActInfo.Text = "Info";
            this.btnActInfo.UseVisualStyleBackColor = true;
            this.btnActInfo.Click += new System.EventHandler(this.btnActInfo_Click);
            // 
            // btnDelAct
            // 
            this.btnDelAct.Location = new System.Drawing.Point(88, 47);
            this.btnDelAct.Name = "btnDelAct";
            this.btnDelAct.Size = new System.Drawing.Size(75, 24);
            this.btnDelAct.TabIndex = 38;
            this.btnDelAct.Text = "Del";
            this.btnDelAct.UseVisualStyleBackColor = true;
            this.btnDelAct.Click += new System.EventHandler(this.btnDelAct_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboDir);
            this.groupBox4.Controls.Add(this.btnDirInfo);
            this.groupBox4.Controls.Add(this.btnDelDir);
            this.groupBox4.Location = new System.Drawing.Point(430, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 87);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Directors";
            // 
            // comboDir
            // 
            this.comboDir.FormattingEnabled = true;
            this.comboDir.Location = new System.Drawing.Point(7, 20);
            this.comboDir.Name = "comboDir";
            this.comboDir.Size = new System.Drawing.Size(261, 21);
            this.comboDir.TabIndex = 0;
            // 
            // btnDirInfo
            // 
            this.btnDirInfo.Location = new System.Drawing.Point(7, 49);
            this.btnDirInfo.Name = "btnDirInfo";
            this.btnDirInfo.Size = new System.Drawing.Size(75, 32);
            this.btnDirInfo.TabIndex = 31;
            this.btnDirInfo.Text = "Info";
            this.btnDirInfo.UseVisualStyleBackColor = true;
            this.btnDirInfo.Click += new System.EventHandler(this.btnDirInfo_Click);
            // 
            // btnDelDir
            // 
            this.btnDelDir.Location = new System.Drawing.Point(88, 49);
            this.btnDelDir.Name = "btnDelDir";
            this.btnDelDir.Size = new System.Drawing.Size(75, 32);
            this.btnDelDir.TabIndex = 37;
            this.btnDelDir.Text = "Del";
            this.btnDelDir.UseVisualStyleBackColor = true;
            this.btnDelDir.Click += new System.EventHandler(this.btnDelDir_Click);
            // 
            // btnOpInfo
            // 
            this.btnOpInfo.Location = new System.Drawing.Point(710, 284);
            this.btnOpInfo.Name = "btnOpInfo";
            this.btnOpInfo.Size = new System.Drawing.Size(75, 21);
            this.btnOpInfo.TabIndex = 34;
            this.btnOpInfo.Text = "Info";
            this.btnOpInfo.UseVisualStyleBackColor = true;
            this.btnOpInfo.Click += new System.EventHandler(this.btnOpInfo_Click);
            // 
            // btnEdInfo
            // 
            this.btnEdInfo.Location = new System.Drawing.Point(711, 346);
            this.btnEdInfo.Name = "btnEdInfo";
            this.btnEdInfo.Size = new System.Drawing.Size(75, 24);
            this.btnEdInfo.TabIndex = 35;
            this.btnEdInfo.Text = "Info";
            this.btnEdInfo.UseVisualStyleBackColor = true;
            this.btnEdInfo.Click += new System.EventHandler(this.btnEdInfo_Click);
            // 
            // btnCompInfo
            // 
            this.btnCompInfo.Location = new System.Drawing.Point(711, 411);
            this.btnCompInfo.Name = "btnCompInfo";
            this.btnCompInfo.Size = new System.Drawing.Size(75, 26);
            this.btnCompInfo.TabIndex = 36;
            this.btnCompInfo.Text = "Info";
            this.btnCompInfo.UseVisualStyleBackColor = true;
            this.btnCompInfo.Click += new System.EventHandler(this.btnCompInfo_Click);
            // 
            // btnDelOp
            // 
            this.btnDelOp.Location = new System.Drawing.Point(711, 312);
            this.btnDelOp.Name = "btnDelOp";
            this.btnDelOp.Size = new System.Drawing.Size(75, 28);
            this.btnDelOp.TabIndex = 40;
            this.btnDelOp.Text = "Del";
            this.btnDelOp.UseVisualStyleBackColor = true;
            this.btnDelOp.Click += new System.EventHandler(this.btnDelOp_Click);
            // 
            // btnDelEd
            // 
            this.btnDelEd.Location = new System.Drawing.Point(711, 376);
            this.btnDelEd.Name = "btnDelEd";
            this.btnDelEd.Size = new System.Drawing.Size(75, 28);
            this.btnDelEd.TabIndex = 41;
            this.btnDelEd.Text = "Del";
            this.btnDelEd.UseVisualStyleBackColor = true;
            this.btnDelEd.Click += new System.EventHandler(this.btnDelEd_Click);
            // 
            // btnDelComp
            // 
            this.btnDelComp.Location = new System.Drawing.Point(711, 444);
            this.btnDelComp.Name = "btnDelComp";
            this.btnDelComp.Size = new System.Drawing.Size(75, 28);
            this.btnDelComp.TabIndex = 42;
            this.btnDelComp.Text = "Del";
            this.btnDelComp.UseVisualStyleBackColor = true;
            this.btnDelComp.Click += new System.EventHandler(this.btnDelComp_Click);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(112, 411);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(100, 100);
            this.printPreviewControl1.TabIndex = 43;
            //this.printPreviewControl1.Click += new System.EventHandler(this.printPreviewControl1_Click);
            // 
            // MoviesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 483);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.btnDelComp);
            this.Controls.Add(this.btnDelEd);
            this.Controls.Add(this.btnDelOp);
            this.Controls.Add(this.btnCompInfo);
            this.Controls.Add(this.btnEdInfo);
            this.Controls.Add(this.btnOpInfo);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnGeneralUpdate);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.movInfo);
            this.Controls.Add(this.chooseMov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MoviesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoviesList";
            this.chooseMov.ResumeLayout(false);
            this.movInfo.ResumeLayout(false);
            this.movInfo.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox chooseMov;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox movInfo;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCountries;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblRotTom;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Label lblMetacritic;
        private System.Windows.Forms.Label lblImdb;
        private System.Windows.Forms.Label lblKinoPoisk;
        private System.Windows.Forms.Label lblAvRating;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Label lblStudios;
        private System.Windows.Forms.Button btnGeneralUpdate;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboOp;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboPro;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboAct;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboDir;
        private System.Windows.Forms.ComboBox comboComp;
        private System.Windows.Forms.ComboBox comboEd;
        private System.Windows.Forms.Button btnDirInfo;
        private System.Windows.Forms.Button btnActInfo;
        private System.Windows.Forms.Button btnProInfo;
        private System.Windows.Forms.Button btnOpInfo;
        private System.Windows.Forms.Button btnEdInfo;
        private System.Windows.Forms.Button btnCompInfo;
        private System.Windows.Forms.Button btnDelDir;
        private System.Windows.Forms.Button btnDelAct;
        private System.Windows.Forms.Button btnDelPro;
        private System.Windows.Forms.Button btnDelOp;
        private System.Windows.Forms.Button btnDelEd;
        private System.Windows.Forms.Button btnDelComp;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;

    }
}