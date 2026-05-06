
namespace OtelOdaTakipSistemi
{
    partial class FormUserInterface
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDoluOdaSayisiİnt = new System.Windows.Forms.Label();
            this.lblToplamOdaSayisiİnt = new System.Windows.Forms.Label();
            this.maskedTextBoxOdaNoAraİnt = new System.Windows.Forms.MaskedTextBox();
            this.lblDoluOdaSayisi = new System.Windows.Forms.Label();
            this.lblOdaListelemesi = new System.Windows.Forms.Label();
            this.lblToplamOdaSayisi = new System.Windows.Forms.Label();
            this.lblOdaNoAra = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.flowLayoutPanelOdalar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOturumuKapat = new System.Windows.Forms.Button();
            this.timerFLowLayoutPanetOdaEkle = new System.Windows.Forms.Timer(this.components);
            this.btnOdaAra = new System.Windows.Forms.Button();
            this.timerFormUserInterfaceGuncelle = new System.Windows.Forms.Timer(this.components);
            this.btnKullanicilariDuzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDoluOdaSayisiİnt
            // 
            this.lblDoluOdaSayisiİnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoluOdaSayisiİnt.AutoSize = true;
            this.lblDoluOdaSayisiİnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoluOdaSayisiİnt.Location = new System.Drawing.Point(1227, 87);
            this.lblDoluOdaSayisiİnt.Name = "lblDoluOdaSayisiİnt";
            this.lblDoluOdaSayisiİnt.Size = new System.Drawing.Size(0, 29);
            this.lblDoluOdaSayisiİnt.TabIndex = 18;
            // 
            // lblToplamOdaSayisiİnt
            // 
            this.lblToplamOdaSayisiİnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplamOdaSayisiİnt.AutoSize = true;
            this.lblToplamOdaSayisiİnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamOdaSayisiİnt.Location = new System.Drawing.Point(1227, 48);
            this.lblToplamOdaSayisiİnt.Name = "lblToplamOdaSayisiİnt";
            this.lblToplamOdaSayisiİnt.Size = new System.Drawing.Size(0, 29);
            this.lblToplamOdaSayisiİnt.TabIndex = 17;
            // 
            // maskedTextBoxOdaNoAraİnt
            // 
            this.maskedTextBoxOdaNoAraİnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxOdaNoAraİnt.Location = new System.Drawing.Point(208, 117);
            this.maskedTextBoxOdaNoAraİnt.Mask = "0000";
            this.maskedTextBoxOdaNoAraİnt.Name = "maskedTextBoxOdaNoAraİnt";
            this.maskedTextBoxOdaNoAraİnt.Size = new System.Drawing.Size(69, 34);
            this.maskedTextBoxOdaNoAraİnt.TabIndex = 16;
            this.maskedTextBoxOdaNoAraİnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxOdaNoAraİnt.UseWaitCursor = true;
            this.maskedTextBoxOdaNoAraİnt.Click += new System.EventHandler(this.maskedTextBoxOdaNoAraİnt_Click);
            // 
            // lblDoluOdaSayisi
            // 
            this.lblDoluOdaSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoluOdaSayisi.AutoSize = true;
            this.lblDoluOdaSayisi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoluOdaSayisi.Location = new System.Drawing.Point(1006, 80);
            this.lblDoluOdaSayisi.Name = "lblDoluOdaSayisi";
            this.lblDoluOdaSayisi.Size = new System.Drawing.Size(210, 37);
            this.lblDoluOdaSayisi.TabIndex = 15;
            this.lblDoluOdaSayisi.Text = "Dolu Oda Sayısı:";
            this.lblDoluOdaSayisi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOdaListelemesi
            // 
            this.lblOdaListelemesi.AutoSize = true;
            this.lblOdaListelemesi.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaListelemesi.Location = new System.Drawing.Point(54, 41);
            this.lblOdaListelemesi.Name = "lblOdaListelemesi";
            this.lblOdaListelemesi.Size = new System.Drawing.Size(371, 62);
            this.lblOdaListelemesi.TabIndex = 10;
            this.lblOdaListelemesi.Text = "Oda Listelemesi";
            // 
            // lblToplamOdaSayisi
            // 
            this.lblToplamOdaSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplamOdaSayisi.AutoSize = true;
            this.lblToplamOdaSayisi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamOdaSayisi.Location = new System.Drawing.Point(976, 41);
            this.lblToplamOdaSayisi.Name = "lblToplamOdaSayisi";
            this.lblToplamOdaSayisi.Size = new System.Drawing.Size(240, 37);
            this.lblToplamOdaSayisi.TabIndex = 11;
            this.lblToplamOdaSayisi.Text = "Toplam Oda Sayısı:";
            this.lblToplamOdaSayisi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOdaNoAra
            // 
            this.lblOdaNoAra.AutoSize = true;
            this.lblOdaNoAra.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblOdaNoAra.Location = new System.Drawing.Point(58, 116);
            this.lblOdaNoAra.Name = "lblOdaNoAra";
            this.lblOdaNoAra.Size = new System.Drawing.Size(144, 32);
            this.lblOdaNoAra.TabIndex = 12;
            this.lblOdaNoAra.Text = "Oda No Ara:";
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEkle.Location = new System.Drawing.Point(1412, 125);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 40);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // flowLayoutPanelOdalar
            // 
            this.flowLayoutPanelOdalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelOdalar.AutoScroll = true;
            this.flowLayoutPanelOdalar.Location = new System.Drawing.Point(50, 171);
            this.flowLayoutPanelOdalar.Name = "flowLayoutPanelOdalar";
            this.flowLayoutPanelOdalar.Size = new System.Drawing.Size(1482, 500);
            this.flowLayoutPanelOdalar.TabIndex = 14;
            // 
            // btnOturumuKapat
            // 
            this.btnOturumuKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOturumuKapat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOturumuKapat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOturumuKapat.Location = new System.Drawing.Point(1345, 41);
            this.btnOturumuKapat.Name = "btnOturumuKapat";
            this.btnOturumuKapat.Size = new System.Drawing.Size(187, 40);
            this.btnOturumuKapat.TabIndex = 19;
            this.btnOturumuKapat.Text = "Oturumu Kapat";
            this.btnOturumuKapat.UseVisualStyleBackColor = true;
            this.btnOturumuKapat.Click += new System.EventHandler(this.btnOturumuKapat_Click);
            // 
            // timerFLowLayoutPanetOdaEkle
            // 
            this.timerFLowLayoutPanetOdaEkle.Interval = 1000;
            this.timerFLowLayoutPanetOdaEkle.Tick += new System.EventHandler(this.timerFLowLayoutPanetOdaEkle_Tick);
            // 
            // btnOdaAra
            // 
            this.btnOdaAra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOdaAra.Location = new System.Drawing.Point(296, 114);
            this.btnOdaAra.Name = "btnOdaAra";
            this.btnOdaAra.Size = new System.Drawing.Size(72, 40);
            this.btnOdaAra.TabIndex = 20;
            this.btnOdaAra.Text = "Ara";
            this.btnOdaAra.UseVisualStyleBackColor = true;
            this.btnOdaAra.Click += new System.EventHandler(this.OdaBilgileri_Click);
            // 
            // timerFormUserInterfaceGuncelle
            // 
            this.timerFormUserInterfaceGuncelle.Tick += new System.EventHandler(this.timerFormUserInterfaceGuncelle_Tick);
            // 
            // btnKullanicilariDuzenle
            // 
            this.btnKullanicilariDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKullanicilariDuzenle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnKullanicilariDuzenle.Location = new System.Drawing.Point(983, 120);
            this.btnKullanicilariDuzenle.Name = "btnKullanicilariDuzenle";
            this.btnKullanicilariDuzenle.Size = new System.Drawing.Size(264, 40);
            this.btnKullanicilariDuzenle.TabIndex = 21;
            this.btnKullanicilariDuzenle.Text = "Kullanıcıları Düzenle";
            this.btnKullanicilariDuzenle.UseVisualStyleBackColor = true;
            this.btnKullanicilariDuzenle.Click += new System.EventHandler(this.btnKullanicilariDuzenle_Click);
            // 
            // FormUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 700);
            this.Controls.Add(this.btnKullanicilariDuzenle);
            this.Controls.Add(this.btnOdaAra);
            this.Controls.Add(this.btnOturumuKapat);
            this.Controls.Add(this.lblDoluOdaSayisiİnt);
            this.Controls.Add(this.lblToplamOdaSayisiİnt);
            this.Controls.Add(this.maskedTextBoxOdaNoAraİnt);
            this.Controls.Add(this.lblDoluOdaSayisi);
            this.Controls.Add(this.lblOdaListelemesi);
            this.Controls.Add(this.lblToplamOdaSayisi);
            this.Controls.Add(this.lblOdaNoAra);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.flowLayoutPanelOdalar);
            this.MinimumSize = new System.Drawing.Size(1600, 747);
            this.Name = "FormUserInterface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Listelemesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUserInterface_FormClosed);
            this.Load += new System.EventHandler(this.FormUserInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoluOdaSayisiİnt;
        private System.Windows.Forms.Label lblToplamOdaSayisiİnt;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOdaNoAraİnt;
        private System.Windows.Forms.Label lblDoluOdaSayisi;
        private System.Windows.Forms.Label lblOdaListelemesi;
        private System.Windows.Forms.Label lblToplamOdaSayisi;
        private System.Windows.Forms.Label lblOdaNoAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnOturumuKapat;
        internal System.Windows.Forms.Timer timerFLowLayoutPanetOdaEkle;
        private System.Windows.Forms.Button btnOdaAra;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOdalar;
        internal System.Windows.Forms.Timer timerFormUserInterfaceGuncelle;
        private System.Windows.Forms.Button btnKullanicilariDuzenle;
    }
}