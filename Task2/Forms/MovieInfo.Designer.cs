namespace ZipFilmIzle.Forms
{
    partial class MovieInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_descrip = new System.Windows.Forms.Label();
            this.lbl_imdb = new System.Windows.Forms.Label();
            this.lbl_languages = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_actors = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_writer = new System.Windows.Forms.Label();
            this.lbl_film_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.lbl_descrip);
            this.panel1.Controls.Add(this.lbl_imdb);
            this.panel1.Controls.Add(this.lbl_languages);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Controls.Add(this.lbl_actors);
            this.panel1.Controls.Add(this.lbl_country);
            this.panel1.Controls.Add(this.lbl_writer);
            this.panel1.Controls.Add(this.lbl_film_name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 0;
            // 
            // lbl_descrip
            // 
            this.lbl_descrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_descrip.AutoSize = true;
            this.lbl_descrip.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_descrip.Location = new System.Drawing.Point(318, 374);
            this.lbl_descrip.Name = "lbl_descrip";
            this.lbl_descrip.Size = new System.Drawing.Size(195, 35);
            this.lbl_descrip.TabIndex = 1;
            this.lbl_descrip.Text = "Description:   ";
            // 
            // lbl_imdb
            // 
            this.lbl_imdb.AutoSize = true;
            this.lbl_imdb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_imdb.Location = new System.Drawing.Point(318, 330);
            this.lbl_imdb.Name = "lbl_imdb";
            this.lbl_imdb.Size = new System.Drawing.Size(116, 35);
            this.lbl_imdb.TabIndex = 1;
            this.lbl_imdb.Text = "IMDB: ";
            // 
            // lbl_languages
            // 
            this.lbl_languages.AutoSize = true;
            this.lbl_languages.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_languages.Location = new System.Drawing.Point(318, 284);
            this.lbl_languages.Name = "lbl_languages";
            this.lbl_languages.Size = new System.Drawing.Size(168, 35);
            this.lbl_languages.TabIndex = 1;
            this.lbl_languages.Text = "Languages: ";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_time.Location = new System.Drawing.Point(318, 237);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(97, 35);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "Time: ";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_type.Location = new System.Drawing.Point(318, 191);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(95, 35);
            this.lbl_type.TabIndex = 1;
            this.lbl_type.Text = "Type: ";
            // 
            // lbl_actors
            // 
            this.lbl_actors.AutoSize = true;
            this.lbl_actors.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_actors.Location = new System.Drawing.Point(317, 145);
            this.lbl_actors.Name = "lbl_actors";
            this.lbl_actors.Size = new System.Drawing.Size(116, 35);
            this.lbl_actors.TabIndex = 1;
            this.lbl_actors.Text = "Actors: ";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_country.Location = new System.Drawing.Point(318, 99);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(138, 35);
            this.lbl_country.TabIndex = 1;
            this.lbl_country.Text = "Country: ";
            // 
            // lbl_writer
            // 
            this.lbl_writer.AutoSize = true;
            this.lbl_writer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_writer.Location = new System.Drawing.Point(318, 53);
            this.lbl_writer.Name = "lbl_writer";
            this.lbl_writer.Size = new System.Drawing.Size(115, 35);
            this.lbl_writer.TabIndex = 1;
            this.lbl_writer.Text = "Writer: ";
            // 
            // lbl_film_name
            // 
            this.lbl_film_name.AutoSize = true;
            this.lbl_film_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_film_name.Location = new System.Drawing.Point(318, 9);
            this.lbl_film_name.Name = "lbl_film_name";
            this.lbl_film_name.Size = new System.Drawing.Size(173, 35);
            this.lbl_film_name.TabIndex = 1;
            this.lbl_film_name.Text = "Film Name: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.Color.Wheat;
            this.txt_description.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_description.Location = new System.Drawing.Point(321, 412);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(476, 85);
            this.txt_description.TabIndex = 2;
            // 
            // MovieInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.Name = "MovieInfo";
            this.Text = "MovieInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl_film_name;
        private Label lbl_writer;
        private Label lbl_country;
        private Label lbl_type;
        private Label lbl_actors;
        private Label lbl_time;
        private Label lbl_languages;
        private Label lbl_imdb;
        private Label lbl_descrip;
        private TextBox txt_description;
    }
}