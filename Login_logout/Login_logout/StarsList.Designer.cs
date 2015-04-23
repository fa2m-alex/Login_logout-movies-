namespace Login_logout
{
    partial class StarsList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblCareer = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDeleteStar = new System.Windows.Forms.Button();
            this.btnUpdateStar = new System.Windows.Forms.Button();
            this.btnGeneralUpdate = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose star";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(342, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPlace);
            this.groupBox2.Controls.Add(this.lblCareer);
            this.groupBox2.Controls.Add(this.lblBirthday);
            this.groupBox2.Controls.Add(this.lblSecondName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Star info";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(7, 109);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(72, 13);
            this.lblPlace.TabIndex = 4;
            this.lblPlace.Text = "Place of birth:";
            // 
            // lblCareer
            // 
            this.lblCareer.AutoSize = true;
            this.lblCareer.Location = new System.Drawing.Point(7, 87);
            this.lblCareer.Name = "lblCareer";
            this.lblCareer.Size = new System.Drawing.Size(77, 13);
            this.lblCareer.TabIndex = 3;
            this.lblCareer.Text = "Start of career:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(7, 64);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(48, 13);
            this.lblBirthday.TabIndex = 2;
            this.lblBirthday.Text = "Birthday:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(7, 42);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(76, 13);
            this.lblSecondName.TabIndex = 1;
            this.lblSecondName.Text = "Second name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnDeleteStar
            // 
            this.btnDeleteStar.Location = new System.Drawing.Point(12, 215);
            this.btnDeleteStar.Name = "btnDeleteStar";
            this.btnDeleteStar.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStar.TabIndex = 3;
            this.btnDeleteStar.Text = "Delete star";
            this.btnDeleteStar.UseVisualStyleBackColor = true;
            this.btnDeleteStar.Click += new System.EventHandler(this.btnDeleteStar_Click);
            // 
            // btnUpdateStar
            // 
            this.btnUpdateStar.Location = new System.Drawing.Point(93, 215);
            this.btnUpdateStar.Name = "btnUpdateStar";
            this.btnUpdateStar.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStar.TabIndex = 4;
            this.btnUpdateStar.Text = "Update star";
            this.btnUpdateStar.UseVisualStyleBackColor = true;
            this.btnUpdateStar.Click += new System.EventHandler(this.btnUpdateStar_Click);
            // 
            // btnGeneralUpdate
            // 
            this.btnGeneralUpdate.Location = new System.Drawing.Point(273, 215);
            this.btnGeneralUpdate.Name = "btnGeneralUpdate";
            this.btnGeneralUpdate.Size = new System.Drawing.Size(93, 23);
            this.btnGeneralUpdate.TabIndex = 5;
            this.btnGeneralUpdate.Text = "General update";
            this.btnGeneralUpdate.UseVisualStyleBackColor = true;
            this.btnGeneralUpdate.Click += new System.EventHandler(this.btnGeneralUpdate_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Location = new System.Drawing.Point(174, 215);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(75, 23);
            this.btnMovies.TabIndex = 6;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // StarsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 253);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnGeneralUpdate);
            this.Controls.Add(this.btnUpdateStar);
            this.Controls.Add(this.btnDeleteStar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StarsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StarsList";
            this.Load += new System.EventHandler(this.StarsList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblCareer;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDeleteStar;
        private System.Windows.Forms.Button btnUpdateStar;
        private System.Windows.Forms.Button btnGeneralUpdate;
        private System.Windows.Forms.Button btnMovies;
    }
}