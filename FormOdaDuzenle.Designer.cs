using System.Windows.Forms;

namespace OtelOdaTakipSistemi
{
    partial class FormOdaDuzenle
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
            this.lblOdaİhtiyaçlari = new System.Windows.Forms.Label();
            this.listBoxRezervasyonTakvimi = new System.Windows.Forms.ListBox();
            this.lblOdaRezervasyonTakvimi = new System.Windows.Forms.Label();
            this.lblKullanimDurumu = new System.Windows.Forms.Label();
            this.listBoxOdaÖzellikleri = new System.Windows.Forms.ListBox();
            this.lblOdaOzellikleri = new System.Windows.Forms.Label();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.pictureBoxOdaResmi = new System.Windows.Forms.PictureBox();
            this.richTextBoxOdaİhtiyaçlari = new System.Windows.Forms.RichTextBox();
            this.btnOdaFotografiEkle = new System.Windows.Forms.Button();
            this.radioButtonDolu = new System.Windows.Forms.RadioButton();
            this.radioButtonBos = new System.Windows.Forms.RadioButton();
            this.textBoxOdaOzellikleri = new System.Windows.Forms.TextBox();
            this.btnOdaOzellikEkle = new System.Windows.Forms.Button();
            this.btnOdaRezervasyonAraligiEkle = new System.Windows.Forms.Button();
            this.maskedTextBoxOdaRezervasyonTakvimi = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxOdaNo = new System.Windows.Forms.MaskedTextBox();
            this.btnOdaKaydet = new System.Windows.Forms.Button();
            this.btnOdaSil = new System.Windows.Forms.Button();
            this.btnOzellikSil = new System.Windows.Forms.Button();
            this.btnRezervasyonSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdaResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOdaİhtiyaçlari
            // 
            this.lblOdaİhtiyaçlari.AutoSize = true;
            this.lblOdaİhtiyaçlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaİhtiyaçlari.Location = new System.Drawing.Point(561, 20);
            this.lblOdaİhtiyaçlari.Name = "lblOdaİhtiyaçlari";
            this.lblOdaİhtiyaçlari.Size = new System.Drawing.Size(204, 32);
            this.lblOdaİhtiyaçlari.TabIndex = 21;
            this.lblOdaİhtiyaçlari.Text = "Oda İhtiyaçları:";
            // 
            // listBoxRezervasyonTakvimi
            // 
            this.listBoxRezervasyonTakvimi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listBoxRezervasyonTakvimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxRezervasyonTakvimi.FormattingEnabled = true;
            this.listBoxRezervasyonTakvimi.ItemHeight = 25;
            this.listBoxRezervasyonTakvimi.Location = new System.Drawing.Point(48, 365);
            this.listBoxRezervasyonTakvimi.Name = "listBoxRezervasyonTakvimi";
            this.listBoxRezervasyonTakvimi.Size = new System.Drawing.Size(375, 154);
            this.listBoxRezervasyonTakvimi.TabIndex = 20;
            // 
            // lblOdaRezervasyonTakvimi
            // 
            this.lblOdaRezervasyonTakvimi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOdaRezervasyonTakvimi.AutoSize = true;
            this.lblOdaRezervasyonTakvimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaRezervasyonTakvimi.Location = new System.Drawing.Point(89, 317);
            this.lblOdaRezervasyonTakvimi.Name = "lblOdaRezervasyonTakvimi";
            this.lblOdaRezervasyonTakvimi.Size = new System.Drawing.Size(292, 32);
            this.lblOdaRezervasyonTakvimi.TabIndex = 19;
            this.lblOdaRezervasyonTakvimi.Text = "Rezervasyon Takvimi:";
            // 
            // lblKullanimDurumu
            // 
            this.lblKullanimDurumu.AutoSize = true;
            this.lblKullanimDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanimDurumu.Location = new System.Drawing.Point(34, 64);
            this.lblKullanimDurumu.Name = "lblKullanimDurumu";
            this.lblKullanimDurumu.Size = new System.Drawing.Size(183, 32);
            this.lblKullanimDurumu.TabIndex = 17;
            this.lblKullanimDurumu.Text = "Oda Durumu:";
            // 
            // listBoxOdaÖzellikleri
            // 
            this.listBoxOdaÖzellikleri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listBoxOdaÖzellikleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxOdaÖzellikleri.FormattingEnabled = true;
            this.listBoxOdaÖzellikleri.ItemHeight = 25;
            this.listBoxOdaÖzellikleri.Location = new System.Drawing.Point(432, 365);
            this.listBoxOdaÖzellikleri.Name = "listBoxOdaÖzellikleri";
            this.listBoxOdaÖzellikleri.Size = new System.Drawing.Size(328, 154);
            this.listBoxOdaÖzellikleri.TabIndex = 16;
            // 
            // lblOdaOzellikleri
            // 
            this.lblOdaOzellikleri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOdaOzellikleri.AutoSize = true;
            this.lblOdaOzellikleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaOzellikleri.Location = new System.Drawing.Point(470, 317);
            this.lblOdaOzellikleri.Name = "lblOdaOzellikleri";
            this.lblOdaOzellikleri.Size = new System.Drawing.Size(209, 32);
            this.lblOdaOzellikleri.TabIndex = 14;
            this.lblOdaOzellikleri.Text = "Oda Özellikleri:";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaNo.Location = new System.Drawing.Point(98, 20);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(119, 32);
            this.lblOdaNo.TabIndex = 13;
            this.lblOdaNo.Text = "Oda No:";
            // 
            // pictureBoxOdaResmi
            // 
            this.pictureBoxOdaResmi.ErrorImage = null;
            this.pictureBoxOdaResmi.Location = new System.Drawing.Point(345, 20);
            this.pictureBoxOdaResmi.Name = "pictureBoxOdaResmi";
            this.pictureBoxOdaResmi.Size = new System.Drawing.Size(150, 189);
            this.pictureBoxOdaResmi.TabIndex = 12;
            this.pictureBoxOdaResmi.TabStop = false;
            // 
            // richTextBoxOdaİhtiyaçlari
            // 
            this.richTextBoxOdaİhtiyaçlari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOdaİhtiyaçlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxOdaİhtiyaçlari.Location = new System.Drawing.Point(771, 0);
            this.richTextBoxOdaİhtiyaçlari.Name = "richTextBoxOdaİhtiyaçlari";
            this.richTextBoxOdaİhtiyaçlari.Size = new System.Drawing.Size(211, 603);
            this.richTextBoxOdaİhtiyaçlari.TabIndex = 23;
            this.richTextBoxOdaİhtiyaçlari.Text = "";
            // 
            // btnOdaFotografiEkle
            // 
            this.btnOdaFotografiEkle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOdaFotografiEkle.Location = new System.Drawing.Point(319, 256);
            this.btnOdaFotografiEkle.Name = "btnOdaFotografiEkle";
            this.btnOdaFotografiEkle.Size = new System.Drawing.Size(202, 40);
            this.btnOdaFotografiEkle.TabIndex = 24;
            this.btnOdaFotografiEkle.Text = "Oda Fotoğrafı Ekle";
            this.btnOdaFotografiEkle.UseVisualStyleBackColor = true;
            this.btnOdaFotografiEkle.Visible = false;
            this.btnOdaFotografiEkle.Click += new System.EventHandler(this.btnOdaFotografiEkle_Click);
            // 
            // radioButtonDolu
            // 
            this.radioButtonDolu.AutoSize = true;
            this.radioButtonDolu.Location = new System.Drawing.Point(236, 75);
            this.radioButtonDolu.Name = "radioButtonDolu";
            this.radioButtonDolu.Size = new System.Drawing.Size(56, 20);
            this.radioButtonDolu.TabIndex = 28;
            this.radioButtonDolu.TabStop = true;
            this.radioButtonDolu.Text = "Dolu";
            this.radioButtonDolu.UseVisualStyleBackColor = true;
            // 
            // radioButtonBos
            // 
            this.radioButtonBos.AutoSize = true;
            this.radioButtonBos.Location = new System.Drawing.Point(236, 101);
            this.radioButtonBos.Name = "radioButtonBos";
            this.radioButtonBos.Size = new System.Drawing.Size(52, 20);
            this.radioButtonBos.TabIndex = 29;
            this.radioButtonBos.TabStop = true;
            this.radioButtonBos.Text = "Boş";
            this.radioButtonBos.UseVisualStyleBackColor = true;
            // 
            // textBoxOdaOzellikleri
            // 
            this.textBoxOdaOzellikleri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxOdaOzellikleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOdaOzellikleri.Location = new System.Drawing.Point(428, 525);
            this.textBoxOdaOzellikleri.Name = "textBoxOdaOzellikleri";
            this.textBoxOdaOzellikleri.Size = new System.Drawing.Size(169, 38);
            this.textBoxOdaOzellikleri.TabIndex = 31;
            this.textBoxOdaOzellikleri.Visible = false;
            // 
            // btnOdaOzellikEkle
            // 
            this.btnOdaOzellikEkle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOdaOzellikEkle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOdaOzellikEkle.Location = new System.Drawing.Point(603, 525);
            this.btnOdaOzellikEkle.Name = "btnOdaOzellikEkle";
            this.btnOdaOzellikEkle.Size = new System.Drawing.Size(157, 40);
            this.btnOdaOzellikEkle.TabIndex = 32;
            this.btnOdaOzellikEkle.Text = "Özellik Ekle";
            this.btnOdaOzellikEkle.UseVisualStyleBackColor = true;
            this.btnOdaOzellikEkle.Visible = false;
            this.btnOdaOzellikEkle.Click += new System.EventHandler(this.btnOdaOzellikEkle_Click);
            // 
            // btnOdaRezervasyonAraligiEkle
            // 
            this.btnOdaRezervasyonAraligiEkle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOdaRezervasyonAraligiEkle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOdaRezervasyonAraligiEkle.Location = new System.Drawing.Point(236, 525);
            this.btnOdaRezervasyonAraligiEkle.Name = "btnOdaRezervasyonAraligiEkle";
            this.btnOdaRezervasyonAraligiEkle.Size = new System.Drawing.Size(186, 40);
            this.btnOdaRezervasyonAraligiEkle.TabIndex = 33;
            this.btnOdaRezervasyonAraligiEkle.Text = "Rezervasyon Ekle";
            this.btnOdaRezervasyonAraligiEkle.UseVisualStyleBackColor = true;
            this.btnOdaRezervasyonAraligiEkle.Click += new System.EventHandler(this.btnOdaRezervasyonAraligiEkle_Click);
            // 
            // maskedTextBoxOdaRezervasyonTakvimi
            // 
            this.maskedTextBoxOdaRezervasyonTakvimi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskedTextBoxOdaRezervasyonTakvimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxOdaRezervasyonTakvimi.Location = new System.Drawing.Point(47, 531);
            this.maskedTextBoxOdaRezervasyonTakvimi.Mask = "00/00/0000 90:00 - 00/00/0000 90:00 ";
            this.maskedTextBoxOdaRezervasyonTakvimi.Name = "maskedTextBoxOdaRezervasyonTakvimi";
            this.maskedTextBoxOdaRezervasyonTakvimi.Size = new System.Drawing.Size(183, 30);
            this.maskedTextBoxOdaRezervasyonTakvimi.TabIndex = 34;
            this.maskedTextBoxOdaRezervasyonTakvimi.Click += new System.EventHandler(this.maskedTextBoxOdaRezervasyonTakvimi_Click);
            // 
            // maskedTextBoxOdaNo
            // 
            this.maskedTextBoxOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxOdaNo.Location = new System.Drawing.Point(236, 20);
            this.maskedTextBoxOdaNo.Mask = "0000";
            this.maskedTextBoxOdaNo.Name = "maskedTextBoxOdaNo";
            this.maskedTextBoxOdaNo.Size = new System.Drawing.Size(77, 38);
            this.maskedTextBoxOdaNo.TabIndex = 35;
            this.maskedTextBoxOdaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxOdaNo.Click += new System.EventHandler(this.maskedTextBoxOdaNo_Click);
            // 
            // btnOdaKaydet
            // 
            this.btnOdaKaydet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOdaKaydet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOdaKaydet.Location = new System.Drawing.Point(28, 197);
            this.btnOdaKaydet.Name = "btnOdaKaydet";
            this.btnOdaKaydet.Size = new System.Drawing.Size(194, 40);
            this.btnOdaKaydet.TabIndex = 36;
            this.btnOdaKaydet.Text = "Kaydet/Güncelle";
            this.btnOdaKaydet.UseVisualStyleBackColor = true;
            this.btnOdaKaydet.Click += new System.EventHandler(this.btnOdaKaydet_Click);
            // 
            // btnOdaSil
            // 
            this.btnOdaSil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOdaSil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOdaSil.Location = new System.Drawing.Point(28, 243);
            this.btnOdaSil.Name = "btnOdaSil";
            this.btnOdaSil.Size = new System.Drawing.Size(194, 40);
            this.btnOdaSil.TabIndex = 37;
            this.btnOdaSil.Text = "Sil";
            this.btnOdaSil.UseVisualStyleBackColor = true;
            this.btnOdaSil.Visible = false;
            this.btnOdaSil.Click += new System.EventHandler(this.btnOdaSil_Click);
            // 
            // btnOzellikSil
            // 
            this.btnOzellikSil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOzellikSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOzellikSil.Location = new System.Drawing.Point(613, 567);
            this.btnOzellikSil.Name = "btnOzellikSil";
            this.btnOzellikSil.Size = new System.Drawing.Size(147, 34);
            this.btnOzellikSil.TabIndex = 38;
            this.btnOzellikSil.Text = "Özellik Sil";
            this.btnOzellikSil.UseVisualStyleBackColor = true;
            this.btnOzellikSil.Visible = false;
            this.btnOzellikSil.Click += new System.EventHandler(this.btnOzellikSil_Click);
            // 
            // btnRezervasyonSil
            // 
            this.btnRezervasyonSil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRezervasyonSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonSil.Location = new System.Drawing.Point(275, 567);
            this.btnRezervasyonSil.Name = "btnRezervasyonSil";
            this.btnRezervasyonSil.Size = new System.Drawing.Size(147, 34);
            this.btnRezervasyonSil.TabIndex = 39;
            this.btnRezervasyonSil.Text = "Rezervasyon Sil";
            this.btnRezervasyonSil.UseVisualStyleBackColor = true;
            this.btnRezervasyonSil.Click += new System.EventHandler(this.btnRezervasyonSil_Click);
            // 
            // FormOdaDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.btnRezervasyonSil);
            this.Controls.Add(this.btnOzellikSil);
            this.Controls.Add(this.btnOdaSil);
            this.Controls.Add(this.btnOdaKaydet);
            this.Controls.Add(this.maskedTextBoxOdaNo);
            this.Controls.Add(this.maskedTextBoxOdaRezervasyonTakvimi);
            this.Controls.Add(this.btnOdaRezervasyonAraligiEkle);
            this.Controls.Add(this.btnOdaOzellikEkle);
            this.Controls.Add(this.textBoxOdaOzellikleri);
            this.Controls.Add(this.radioButtonBos);
            this.Controls.Add(this.radioButtonDolu);
            this.Controls.Add(this.btnOdaFotografiEkle);
            this.Controls.Add(this.richTextBoxOdaİhtiyaçlari);
            this.Controls.Add(this.lblOdaİhtiyaçlari);
            this.Controls.Add(this.listBoxRezervasyonTakvimi);
            this.Controls.Add(this.lblOdaRezervasyonTakvimi);
            this.Controls.Add(this.lblKullanimDurumu);
            this.Controls.Add(this.listBoxOdaÖzellikleri);
            this.Controls.Add(this.lblOdaOzellikleri);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.pictureBoxOdaResmi);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FormOdaDuzenle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODA BİLGİLERİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOdaDuzenle_FormClosing);
            this.Load += new System.EventHandler(this.FormOdaDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdaResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOdaİhtiyaçlari;
        private System.Windows.Forms.Label lblOdaRezervasyonTakvimi;
        private System.Windows.Forms.Label lblKullanimDurumu;
        private System.Windows.Forms.Label lblOdaOzellikleri;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Button btnOdaOzellikEkle;
        private System.Windows.Forms.Button btnOdaRezervasyonAraligiEkle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOdaRezervasyonTakvimi;
        private System.Windows.Forms.TextBox textBoxOdaOzellikleri;
        private Button btnOdaFotografiEkle;
        private Button btnOdaKaydet;
        internal MaskedTextBox maskedTextBoxOdaNo;
        internal PictureBox pictureBoxOdaResmi;
        internal ListBox listBoxOdaÖzellikleri;
        internal RichTextBox richTextBoxOdaİhtiyaçlari;
        internal ListBox listBoxRezervasyonTakvimi;
        internal RadioButton radioButtonDolu;
        internal RadioButton radioButtonBos;
        internal Button btnOdaSil;
        private Button btnOzellikSil;
        private Button btnRezervasyonSil;
    }
}