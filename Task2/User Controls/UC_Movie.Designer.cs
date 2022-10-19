namespace ZipFilmIzle.User_Controls
{
    partial class UC_Movie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_imdb = new System.Windows.Forms.Label();
            this.lbl_movie_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_year);
            this.panel1.Controls.Add(this.lbl_imdb);
            this.panel1.Controls.Add(this.lbl_movie_name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 275);
            this.panel1.TabIndex = 0;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.BackColor = System.Drawing.Color.Transparent;
            this.lbl_year.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_year.Location = new System.Drawing.Point(3, 0);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(29, 26);
            this.lbl_year.TabIndex = 2;
            this.lbl_year.Text = "IL";
            // 
            // lbl_imdb
            // 
            this.lbl_imdb.AutoSize = true;
            this.lbl_imdb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_imdb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_imdb.Location = new System.Drawing.Point(0, 215);
            this.lbl_imdb.Name = "lbl_imdb";
            this.lbl_imdb.Size = new System.Drawing.Size(41, 26);
            this.lbl_imdb.TabIndex = 2;
            this.lbl_imdb.Text = "Xal";
            // 
            // lbl_movie_name
            // 
            this.lbl_movie_name.AutoSize = true;
            this.lbl_movie_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_movie_name.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_movie_name.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_movie_name.Location = new System.Drawing.Point(0, 241);
            this.lbl_movie_name.Name = "lbl_movie_name";
            this.lbl_movie_name.Size = new System.Drawing.Size(89, 34);
            this.lbl_movie_name.TabIndex = 1;
            this.lbl_movie_name.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Movie";
            this.Size = new System.Drawing.Size(252, 275);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl_movie_name;
        private Label lbl_imdb;
        private Label lbl_year;
    }
}
