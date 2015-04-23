namespace Login_logout
{
    partial class AddStarsToMovie
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioComp = new System.Windows.Forms.RadioButton();
            this.radioEditor = new System.Windows.Forms.RadioButton();
            this.radioOper = new System.Windows.Forms.RadioButton();
            this.radioProducer = new System.Windows.Forms.RadioButton();
            this.radioDirector = new System.Windows.Forms.RadioButton();
            this.radioActor = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chooseMov.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseMov
            // 
            this.chooseMov.Controls.Add(this.comboBox1);
            this.chooseMov.Location = new System.Drawing.Point(12, 12);
            this.chooseMov.Name = "chooseMov";
            this.chooseMov.Size = new System.Drawing.Size(387, 56);
            this.chooseMov.TabIndex = 1;
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
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 75);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(386, 229);
            this.checkedListBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioComp);
            this.groupBox1.Controls.Add(this.radioEditor);
            this.groupBox1.Controls.Add(this.radioOper);
            this.groupBox1.Controls.Add(this.radioProducer);
            this.groupBox1.Controls.Add(this.radioDirector);
            this.groupBox1.Controls.Add(this.radioActor);
            this.groupBox1.Location = new System.Drawing.Point(13, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 161);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set type";
            // 
            // radioComp
            // 
            this.radioComp.AutoSize = true;
            this.radioComp.Location = new System.Drawing.Point(7, 138);
            this.radioComp.Name = "radioComp";
            this.radioComp.Size = new System.Drawing.Size(72, 17);
            this.radioComp.TabIndex = 5;
            this.radioComp.Text = "Composer";
            this.radioComp.UseVisualStyleBackColor = true;
            // 
            // radioEditor
            // 
            this.radioEditor.AutoSize = true;
            this.radioEditor.Location = new System.Drawing.Point(7, 114);
            this.radioEditor.Name = "radioEditor";
            this.radioEditor.Size = new System.Drawing.Size(52, 17);
            this.radioEditor.TabIndex = 4;
            this.radioEditor.Text = "Editor";
            this.radioEditor.UseVisualStyleBackColor = true;
            // 
            // radioOper
            // 
            this.radioOper.AutoSize = true;
            this.radioOper.Location = new System.Drawing.Point(7, 90);
            this.radioOper.Name = "radioOper";
            this.radioOper.Size = new System.Drawing.Size(66, 17);
            this.radioOper.TabIndex = 3;
            this.radioOper.Text = "Operator";
            this.radioOper.UseVisualStyleBackColor = true;
            // 
            // radioProducer
            // 
            this.radioProducer.AutoSize = true;
            this.radioProducer.Location = new System.Drawing.Point(7, 68);
            this.radioProducer.Name = "radioProducer";
            this.radioProducer.Size = new System.Drawing.Size(68, 17);
            this.radioProducer.TabIndex = 2;
            this.radioProducer.Text = "Producer";
            this.radioProducer.UseVisualStyleBackColor = true;
            // 
            // radioDirector
            // 
            this.radioDirector.AutoSize = true;
            this.radioDirector.Location = new System.Drawing.Point(7, 44);
            this.radioDirector.Name = "radioDirector";
            this.radioDirector.Size = new System.Drawing.Size(62, 17);
            this.radioDirector.TabIndex = 1;
            this.radioDirector.Text = "Director";
            this.radioDirector.UseVisualStyleBackColor = true;
            // 
            // radioActor
            // 
            this.radioActor.AutoSize = true;
            this.radioActor.Checked = true;
            this.radioActor.Location = new System.Drawing.Point(7, 20);
            this.radioActor.Name = "radioActor";
            this.radioActor.Size = new System.Drawing.Size(50, 17);
            this.radioActor.TabIndex = 0;
            this.radioActor.TabStop = true;
            this.radioActor.Text = "Actor";
            this.radioActor.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddStarsToMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 474);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.chooseMov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddStarsToMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStarsToMovie";
            this.chooseMov.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox chooseMov;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEditor;
        private System.Windows.Forms.RadioButton radioOper;
        private System.Windows.Forms.RadioButton radioProducer;
        private System.Windows.Forms.RadioButton radioDirector;
        private System.Windows.Forms.RadioButton radioActor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton radioComp;
    }
}