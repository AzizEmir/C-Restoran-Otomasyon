
namespace RestorantFikir2
{
    partial class MenuDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDüzenle));
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYemekAdı = new System.Windows.Forms.TextBox();
            this.nYemekFiyatı = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResimGuncelle = new System.Windows.Forms.Button();
            this.btnResimSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbYemekTuru = new System.Windows.Forms.ComboBox();
            this.btnYemekTuruEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYemekFiyatı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw1
            // 
            this.dgw1.AllowUserToAddRows = false;
            this.dgw1.AllowUserToDeleteRows = false;
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.Location = new System.Drawing.Point(13, 230);
            this.dgw1.Margin = new System.Windows.Forms.Padding(4);
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.Size = new System.Drawing.Size(814, 292);
            this.dgw1.TabIndex = 0;
            this.dgw1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yemek Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yemek Fiyatı :";
            // 
            // txtYemekAdı
            // 
            this.txtYemekAdı.Location = new System.Drawing.Point(123, 66);
            this.txtYemekAdı.Name = "txtYemekAdı";
            this.txtYemekAdı.Size = new System.Drawing.Size(196, 27);
            this.txtYemekAdı.TabIndex = 1;
            // 
            // nYemekFiyatı
            // 
            this.nYemekFiyatı.Location = new System.Drawing.Point(123, 97);
            this.nYemekFiyatı.Name = "nYemekFiyatı";
            this.nYemekFiyatı.Size = new System.Drawing.Size(195, 27);
            this.nYemekFiyatı.TabIndex = 2;
            this.nYemekFiyatı.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(391, 120);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(72, 72);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(501, 120);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(84, 72);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(623, 120);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(72, 72);
            this.btnSil.TabIndex = 3;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yemek Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID :";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(123, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 27);
            this.txtid.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(834, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimGuncelle
            // 
            this.btnResimGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResimGuncelle.BackgroundImage")));
            this.btnResimGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResimGuncelle.FlatAppearance.BorderSize = 0;
            this.btnResimGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResimGuncelle.Location = new System.Drawing.Point(872, 273);
            this.btnResimGuncelle.Name = "btnResimGuncelle";
            this.btnResimGuncelle.Size = new System.Drawing.Size(119, 100);
            this.btnResimGuncelle.TabIndex = 4;
            this.btnResimGuncelle.UseVisualStyleBackColor = true;
            this.btnResimGuncelle.Click += new System.EventHandler(this.btnResimGuncelle_Click);
            // 
            // btnResimSil
            // 
            this.btnResimSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResimSil.BackgroundImage")));
            this.btnResimSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResimSil.FlatAppearance.BorderSize = 0;
            this.btnResimSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResimSil.Location = new System.Drawing.Point(997, 273);
            this.btnResimSil.Name = "btnResimSil";
            this.btnResimSil.Size = new System.Drawing.Size(130, 87);
            this.btnResimSil.TabIndex = 5;
            this.btnResimSil.UseVisualStyleBackColor = true;
            this.btnResimSil.Click += new System.EventHandler(this.btnResimSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.cbYemekTuru);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtYemekAdı);
            this.groupBox1.Controls.Add(this.nYemekFiyatı);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(31, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // cbYemekTuru
            // 
            this.cbYemekTuru.FormattingEnabled = true;
            this.cbYemekTuru.Location = new System.Drawing.Point(123, 131);
            this.cbYemekTuru.Name = "cbYemekTuru";
            this.cbYemekTuru.Size = new System.Drawing.Size(196, 27);
            this.cbYemekTuru.TabIndex = 9;
            // 
            // btnYemekTuruEkle
            // 
            this.btnYemekTuruEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnYemekTuruEkle.FlatAppearance.BorderSize = 0;
            this.btnYemekTuruEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnYemekTuruEkle.Location = new System.Drawing.Point(419, 12);
            this.btnYemekTuruEkle.Name = "btnYemekTuruEkle";
            this.btnYemekTuruEkle.Size = new System.Drawing.Size(155, 39);
            this.btnYemekTuruEkle.TabIndex = 11;
            this.btnYemekTuruEkle.Text = "Yemek Türü Ekle";
            this.btnYemekTuruEkle.UseVisualStyleBackColor = false;
            this.btnYemekTuruEkle.Click += new System.EventHandler(this.btnYemekTuruEkle_Click);
            // 
            // MenuDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1152, 535);
            this.Controls.Add(this.btnYemekTuruEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResimSil);
            this.Controls.Add(this.btnResimGuncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgw1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MenuDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuDüzenle";
            this.Load += new System.EventHandler(this.MenuDüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYemekFiyatı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYemekAdı;
        private System.Windows.Forms.NumericUpDown nYemekFiyatı;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResimGuncelle;
        private System.Windows.Forms.Button btnResimSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbYemekTuru;
        private System.Windows.Forms.Button btnYemekTuruEkle;
    }
}