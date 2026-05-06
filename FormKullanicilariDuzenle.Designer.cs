namespace OtelOdaTakipSistemi
{
    partial class FormKullanicilariDuzenle
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
            this.textBoxPersonelNo = new System.Windows.Forms.TextBox();
            this.textBoxPersonelSifre = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnKullaniciKaydet = new System.Windows.Forms.Button();
            this.dataGridViewPersonelInformation = new System.Windows.Forms.DataGridView();
            this.checkBoxKullaniciAdminBilgisi = new System.Windows.Forms.CheckBox();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonelInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPersonelNo
            // 
            this.textBoxPersonelNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPersonelNo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxPersonelNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPersonelNo.Location = new System.Drawing.Point(178, 83);
            this.textBoxPersonelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPersonelNo.Name = "textBoxPersonelNo";
            this.textBoxPersonelNo.Size = new System.Drawing.Size(240, 32);
            this.textBoxPersonelNo.TabIndex = 7;
            // 
            // textBoxPersonelSifre
            // 
            this.textBoxPersonelSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPersonelSifre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxPersonelSifre.Location = new System.Drawing.Point(178, 126);
            this.textBoxPersonelSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPersonelSifre.Name = "textBoxPersonelSifre";
            this.textBoxPersonelSifre.Size = new System.Drawing.Size(240, 32);
            this.textBoxPersonelSifre.TabIndex = 8;
            this.textBoxPersonelSifre.UseSystemPasswordChar = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.labelEmail.Location = new System.Drawing.Point(42, 91);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(114, 25);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Personel No";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.labelPassword.Location = new System.Drawing.Point(81, 134);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(50, 25);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Şifre";
            // 
            // btnKullaniciKaydet
            // 
            this.btnKullaniciKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnKullaniciKaydet.FlatAppearance.BorderSize = 0;
            this.btnKullaniciKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciKaydet.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnKullaniciKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciKaydet.Location = new System.Drawing.Point(102, 235);
            this.btnKullaniciKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKullaniciKaydet.Name = "btnKullaniciKaydet";
            this.btnKullaniciKaydet.Size = new System.Drawing.Size(240, 50);
            this.btnKullaniciKaydet.TabIndex = 11;
            this.btnKullaniciKaydet.Text = "Kaydet";
            this.btnKullaniciKaydet.UseVisualStyleBackColor = false;
            this.btnKullaniciKaydet.Click += new System.EventHandler(this.btnKullaniciKaydet_Click);
            // 
            // dataGridViewPersonelInformation
            // 
            this.dataGridViewPersonelInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonelInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonelInformation.Location = new System.Drawing.Point(517, 12);
            this.dataGridViewPersonelInformation.Name = "dataGridViewPersonelInformation";
            this.dataGridViewPersonelInformation.RowHeadersWidth = 51;
            this.dataGridViewPersonelInformation.RowTemplate.Height = 24;
            this.dataGridViewPersonelInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonelInformation.Size = new System.Drawing.Size(453, 429);
            this.dataGridViewPersonelInformation.TabIndex = 13;
            // 
            // checkBoxKullaniciAdminBilgisi
            // 
            this.checkBoxKullaniciAdminBilgisi.AutoSize = true;
            this.checkBoxKullaniciAdminBilgisi.Location = new System.Drawing.Point(178, 182);
            this.checkBoxKullaniciAdminBilgisi.Name = "checkBoxKullaniciAdminBilgisi";
            this.checkBoxKullaniciAdminBilgisi.Size = new System.Drawing.Size(67, 20);
            this.checkBoxKullaniciAdminBilgisi.TabIndex = 14;
            this.checkBoxKullaniciAdminBilgisi.Text = "Admin";
            this.checkBoxKullaniciAdminBilgisi.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnKullaniciSil.FlatAppearance.BorderSize = 0;
            this.btnKullaniciSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciSil.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnKullaniciSil.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciSil.Location = new System.Drawing.Point(102, 308);
            this.btnKullaniciSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(240, 50);
            this.btnKullaniciSil.TabIndex = 15;
            this.btnKullaniciSil.Text = "Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = false;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // FormKullanicilariDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.checkBoxKullaniciAdminBilgisi);
            this.Controls.Add(this.dataGridViewPersonelInformation);
            this.Controls.Add(this.btnKullaniciKaydet);
            this.Controls.Add(this.textBoxPersonelNo);
            this.Controls.Add(this.textBoxPersonelSifre);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPassword);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "FormKullanicilariDuzenle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcıları Düzenle";
            this.Load += new System.EventHandler(this.FormKullanicilariDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonelInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPersonelNo;
        private System.Windows.Forms.TextBox textBoxPersonelSifre;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnKullaniciKaydet;
        private System.Windows.Forms.DataGridView dataGridViewPersonelInformation;
        private System.Windows.Forms.CheckBox checkBoxKullaniciAdminBilgisi;
        private System.Windows.Forms.Button btnKullaniciSil;
    }
}