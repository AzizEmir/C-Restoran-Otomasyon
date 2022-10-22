
namespace RestorantFikir2
{
    partial class SiparisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisFormu));
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYemek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSiparisSayisi = new System.Windows.Forms.Label();
            this.btnMenuDuzenle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHesap = new System.Windows.Forms.Label();
            this.lbxMenu = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnHesabıTamamla = new System.Windows.Forms.Button();
            this.btnCiroGoruntule = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw1
            // 
            this.dgw1.AllowDrop = true;
            this.dgw1.AllowUserToAddRows = false;
            this.dgw1.AllowUserToDeleteRows = false;
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.Location = new System.Drawing.Point(5, 286);
            this.dgw1.Margin = new System.Windows.Forms.Padding(4);
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.Size = new System.Drawing.Size(1148, 354);
            this.dgw1.TabIndex = 0;
            this.dgw1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw1_CellClick);
            this.dgw1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yemek Adı :";
            // 
            // txtYemek
            // 
            this.txtYemek.Location = new System.Drawing.Point(153, 28);
            this.txtYemek.Name = "txtYemek";
            this.txtYemek.Size = new System.Drawing.Size(126, 23);
            this.txtYemek.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yemek Fiyatı :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(153, 61);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(126, 23);
            this.txtFiyat.TabIndex = 1;
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuEkle.BackgroundImage")));
            this.btnMenuEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuEkle.FlatAppearance.BorderSize = 0;
            this.btnMenuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEkle.Location = new System.Drawing.Point(113, 115);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(66, 54);
            this.btnMenuEkle.TabIndex = 0;
            this.btnMenuEkle.UseVisualStyleBackColor = true;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sipariş Sayısı :";
            // 
            // lblSiparisSayisi
            // 
            this.lblSiparisSayisi.AutoSize = true;
            this.lblSiparisSayisi.Location = new System.Drawing.Point(464, 201);
            this.lblSiparisSayisi.Name = "lblSiparisSayisi";
            this.lblSiparisSayisi.Size = new System.Drawing.Size(0, 16);
            this.lblSiparisSayisi.TabIndex = 6;
            // 
            // btnMenuDuzenle
            // 
            this.btnMenuDuzenle.BackColor = System.Drawing.Color.Thistle;
            this.btnMenuDuzenle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuDuzenle.Location = new System.Drawing.Point(17, 237);
            this.btnMenuDuzenle.Name = "btnMenuDuzenle";
            this.btnMenuDuzenle.Size = new System.Drawing.Size(129, 33);
            this.btnMenuDuzenle.TabIndex = 2;
            this.btnMenuDuzenle.Text = "Menu Düzenle";
            this.btnMenuDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDuzenle.UseVisualStyleBackColor = false;
            this.btnMenuDuzenle.Click += new System.EventHandler(this.btnMenuDuzenle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(841, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hesap =";
            // 
            // lblHesap
            // 
            this.lblHesap.AutoSize = true;
            this.lblHesap.Location = new System.Drawing.Point(464, 163);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(0, 16);
            this.lblHesap.TabIndex = 11;
            // 
            // lbxMenu
            // 
            this.lbxMenu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbxMenu.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxMenu.FormattingEnabled = true;
            this.lbxMenu.ItemHeight = 21;
            this.lbxMenu.Location = new System.Drawing.Point(579, 12);
            this.lbxMenu.Name = "lbxMenu";
            this.lbxMenu.Size = new System.Drawing.Size(244, 235);
            this.lbxMenu.TabIndex = 12;
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(213, 115);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(66, 54);
            this.btnSil.TabIndex = 1;
            this.btnSil.Tag = "";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnHesabıTamamla
            // 
            this.btnHesabıTamamla.BackColor = System.Drawing.Color.Thistle;
            this.btnHesabıTamamla.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesabıTamamla.Location = new System.Drawing.Point(377, 53);
            this.btnHesabıTamamla.Name = "btnHesabıTamamla";
            this.btnHesabıTamamla.Size = new System.Drawing.Size(161, 36);
            this.btnHesabıTamamla.TabIndex = 13;
            this.btnHesabıTamamla.Text = "Hesabı Tamamla";
            this.btnHesabıTamamla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesabıTamamla.UseVisualStyleBackColor = false;
            this.btnHesabıTamamla.Click += new System.EventHandler(this.btnHesabıTamamla_Click);
            // 
            // btnCiroGoruntule
            // 
            this.btnCiroGoruntule.BackColor = System.Drawing.Color.Thistle;
            this.btnCiroGoruntule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCiroGoruntule.FlatAppearance.BorderSize = 0;
            this.btnCiroGoruntule.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.btnCiroGoruntule.Location = new System.Drawing.Point(377, 95);
            this.btnCiroGoruntule.Name = "btnCiroGoruntule";
            this.btnCiroGoruntule.Size = new System.Drawing.Size(161, 34);
            this.btnCiroGoruntule.TabIndex = 14;
            this.btnCiroGoruntule.Text = "Ciroyu Görüntüle";
            this.btnCiroGoruntule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCiroGoruntule.UseVisualStyleBackColor = false;
            this.btnCiroGoruntule.Click += new System.EventHandler(this.btnCiroGoruntule_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(353, 21);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(206, 26);
            this.dtpTarih.TabIndex = 15;
            this.dtpTarih.Value = new System.DateTime(2022, 5, 2, 2, 20, 9, 0);
            // 
            // SiparisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1163, 653);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btnCiroGoruntule);
            this.Controls.Add(this.btnHesabıTamamla);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lbxMenu);
            this.Controls.Add(this.lblHesap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenuDuzenle);
            this.Controls.Add(this.lblSiparisSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMenuEkle);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtYemek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw1);
            this.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SiparisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Sipariş Ver";
            this.Load += new System.EventHandler(this.SiparisFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYemek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSiparisSayisi;
        private System.Windows.Forms.Button btnMenuDuzenle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHesap;
        private System.Windows.Forms.ListBox lbxMenu;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnHesabıTamamla;
        private System.Windows.Forms.Button btnCiroGoruntule;
        private System.Windows.Forms.DateTimePicker dtpTarih;
    }
}

