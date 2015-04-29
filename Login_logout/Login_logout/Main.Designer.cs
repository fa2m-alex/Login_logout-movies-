namespace Login_logout
{
    partial class Main
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnMyStars = new System.Windows.Forms.Button();
            this.btnStars = new System.Windows.Forms.Button();
            this.btnMyMovies = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(220, 17);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 1;
            this.label.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnChangePass);
            this.groupBox1.Controls.Add(this.btnMyStars);
            this.groupBox1.Controls.Add(this.btnStars);
            this.groupBox1.Controls.Add(this.btnMyMovies);
            this.groupBox1.Controls.Add(this.btnMovies);
            this.groupBox1.Location = new System.Drawing.Point(65, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Menu";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(7, 140);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(217, 23);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "Change password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnMyStars
            // 
            this.btnMyStars.Location = new System.Drawing.Point(7, 110);
            this.btnMyStars.Name = "btnMyStars";
            this.btnMyStars.Size = new System.Drawing.Size(217, 23);
            this.btnMyStars.TabIndex = 3;
            this.btnMyStars.Text = "My stars";
            this.btnMyStars.UseVisualStyleBackColor = true;
            this.btnMyStars.Click += new System.EventHandler(this.btnMyStars_Click);
            // 
            // btnStars
            // 
            this.btnStars.Location = new System.Drawing.Point(7, 80);
            this.btnStars.Name = "btnStars";
            this.btnStars.Size = new System.Drawing.Size(217, 23);
            this.btnStars.TabIndex = 2;
            this.btnStars.Text = "Stars";
            this.btnStars.UseVisualStyleBackColor = true;
            this.btnStars.Click += new System.EventHandler(this.btnStars_Click);
            // 
            // btnMyMovies
            // 
            this.btnMyMovies.Location = new System.Drawing.Point(7, 50);
            this.btnMyMovies.Name = "btnMyMovies";
            this.btnMyMovies.Size = new System.Drawing.Size(217, 23);
            this.btnMyMovies.TabIndex = 1;
            this.btnMyMovies.Text = "My movies";
            this.btnMyMovies.UseVisualStyleBackColor = true;
            this.btnMyMovies.Click += new System.EventHandler(this.btnMyMovies_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Location = new System.Drawing.Point(7, 20);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(217, 23);
            this.btnMovies.TabIndex = 0;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Користувачі, які поставили високі оцінки поганим фільмам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnLogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMyStars;
        private System.Windows.Forms.Button btnStars;
        private System.Windows.Forms.Button btnMyMovies;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button button1;
    }
}