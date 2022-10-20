namespace ZipFilmIzle
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reflesh = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_elaqe = new System.Windows.Forms.Button();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.btn_en_izlenen = new System.Windows.Forms.Button();
            this.btn_en_yorumcu = new System.Windows.Forms.Button();
            this.btn_en_beyeni = new System.Windows.Forms.Button();
            this.btn_sign_in = new System.Windows.Forms.Button();
            this.btn_sign_Up = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZipFilmIzle.Com";
            // 
            // btn_reflesh
            // 
            this.btn_reflesh.BackColor = System.Drawing.Color.Transparent;
            this.btn_reflesh.BackgroundImage = global::ZipFilmIzle.Properties.Resources.film;
            this.btn_reflesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reflesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reflesh.Location = new System.Drawing.Point(374, 9);
            this.btn_reflesh.Name = "btn_reflesh";
            this.btn_reflesh.Size = new System.Drawing.Size(76, 64);
            this.btn_reflesh.TabIndex = 1;
            this.btn_reflesh.UseVisualStyleBackColor = false;
            this.btn_reflesh.Click += new System.EventHandler(this.btn_reflesh_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Historic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(10, 98);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.PlaceholderText = "Film, dizi ve ya oyuncu adi";
            this.txt_search.Size = new System.Drawing.Size(466, 64);
            this.txt_search.TabIndex = 2;
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BackgroundImage = global::ZipFilmIzle.Properties.Resources.cancel;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.Location = new System.Drawing.Point(482, 99);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(74, 64);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = global::ZipFilmIzle.Properties.Resources.search__v4;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Location = new System.Drawing.Point(562, 98);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(74, 64);
            this.btn_search.TabIndex = 4;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_elaqe
            // 
            this.btn_elaqe.BackColor = System.Drawing.Color.Transparent;
            this.btn_elaqe.BackgroundImage = global::ZipFilmIzle.Properties.Resources.topic__v2;
            this.btn_elaqe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_elaqe.Enabled = false;
            this.btn_elaqe.Location = new System.Drawing.Point(946, 98);
            this.btn_elaqe.Name = "btn_elaqe";
            this.btn_elaqe.Size = new System.Drawing.Size(94, 65);
            this.btn_elaqe.TabIndex = 5;
            this.btn_elaqe.UseVisualStyleBackColor = false;
            // 
            // btn_yeni
            // 
            this.btn_yeni.BackColor = System.Drawing.Color.Transparent;
            this.btn_yeni.Enabled = false;
            this.btn_yeni.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_yeni.Location = new System.Drawing.Point(10, 191);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(275, 43);
            this.btn_yeni.TabIndex = 6;
            this.btn_yeni.Text = "Yeni eklenenler";
            this.btn_yeni.UseVisualStyleBackColor = false;
            // 
            // btn_en_izlenen
            // 
            this.btn_en_izlenen.BackColor = System.Drawing.Color.Transparent;
            this.btn_en_izlenen.Enabled = false;
            this.btn_en_izlenen.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_en_izlenen.Location = new System.Drawing.Point(292, 191);
            this.btn_en_izlenen.Name = "btn_en_izlenen";
            this.btn_en_izlenen.Size = new System.Drawing.Size(275, 43);
            this.btn_en_izlenen.TabIndex = 6;
            this.btn_en_izlenen.Text = "En cok izlenenler";
            this.btn_en_izlenen.UseVisualStyleBackColor = false;
            // 
            // btn_en_yorumcu
            // 
            this.btn_en_yorumcu.BackColor = System.Drawing.Color.Transparent;
            this.btn_en_yorumcu.Enabled = false;
            this.btn_en_yorumcu.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_en_yorumcu.Location = new System.Drawing.Point(584, 191);
            this.btn_en_yorumcu.Name = "btn_en_yorumcu";
            this.btn_en_yorumcu.Size = new System.Drawing.Size(275, 43);
            this.btn_en_yorumcu.TabIndex = 6;
            this.btn_en_yorumcu.Text = "En cok yorumlananlar";
            this.btn_en_yorumcu.UseVisualStyleBackColor = false;
            // 
            // btn_en_beyeni
            // 
            this.btn_en_beyeni.BackColor = System.Drawing.Color.Transparent;
            this.btn_en_beyeni.Enabled = false;
            this.btn_en_beyeni.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_en_beyeni.Location = new System.Drawing.Point(877, 191);
            this.btn_en_beyeni.Name = "btn_en_beyeni";
            this.btn_en_beyeni.Size = new System.Drawing.Size(275, 43);
            this.btn_en_beyeni.TabIndex = 6;
            this.btn_en_beyeni.Text = "En cok begenilenler";
            this.btn_en_beyeni.UseVisualStyleBackColor = false;
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.BackColor = System.Drawing.Color.Transparent;
            this.btn_sign_in.BackgroundImage = global::ZipFilmIzle.Properties.Resources.singIn;
            this.btn_sign_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sign_in.Location = new System.Drawing.Point(946, 9);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.Size = new System.Drawing.Size(94, 64);
            this.btn_sign_in.TabIndex = 7;
            this.btn_sign_in.UseVisualStyleBackColor = false;
            this.btn_sign_in.Click += new System.EventHandler(this.btn_sign_in_Click);
            // 
            // btn_sign_Up
            // 
            this.btn_sign_Up.BackColor = System.Drawing.Color.Transparent;
            this.btn_sign_Up.BackgroundImage = global::ZipFilmIzle.Properties.Resources.singUp;
            this.btn_sign_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sign_Up.Location = new System.Drawing.Point(1058, 9);
            this.btn_sign_Up.Name = "btn_sign_Up";
            this.btn_sign_Up.Size = new System.Drawing.Size(94, 64);
            this.btn_sign_Up.TabIndex = 7;
            this.btn_sign_Up.UseVisualStyleBackColor = false;
            this.btn_sign_Up.Click += new System.EventHandler(this.btn_sign_Up_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_en_beyeni);
            this.panel1.Controls.Add(this.btn_sign_Up);
            this.panel1.Controls.Add(this.btn_en_yorumcu);
            this.panel1.Controls.Add(this.btn_sign_in);
            this.panel1.Controls.Add(this.btn_en_izlenen);
            this.panel1.Controls.Add(this.btn_reflesh);
            this.panel1.Controls.Add(this.btn_yeni);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.btn_elaqe);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 241);
            this.panel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 241);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1156, 355);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 596);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button btn_reflesh;
        private TextBox txt_search;
        private Button btn_cancel;
        private Button btn_search;
        private Button btn_elaqe;
        private Button btn_yeni;
        private Button btn_en_izlenen;
        private Button btn_en_yorumcu;
        private Button btn_en_beyeni;
        private Button btn_sign_in;
        private Button btn_sign_Up;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}