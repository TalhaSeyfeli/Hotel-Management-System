namespace OtelOdaTakipSistemi
{
    partial class FormLogin
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

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxPersonelNo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPersonelSifre;
        private System.Windows.Forms.LinkLabel linkForgotPassword;
        private System.Windows.Forms.Button btnGiris;

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxPersonelNo = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPersonelSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.labelTitle.Location = new System.Drawing.Point(122, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(147, 62);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "GİRİŞ";
            // 
            // textBoxPersonelNo
            // 
            this.textBoxPersonelNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPersonelNo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxPersonelNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPersonelNo.Location = new System.Drawing.Point(148, 138);
            this.textBoxPersonelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPersonelNo.Name = "textBoxPersonelNo";
            this.textBoxPersonelNo.Size = new System.Drawing.Size(240, 32);
            this.textBoxPersonelNo.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.labelEmail.Location = new System.Drawing.Point(12, 146);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(114, 25);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Personel No";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.labelPassword.Location = new System.Drawing.Point(51, 189);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(50, 25);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Şifre";
            // 
            // textBoxPersonelSifre
            // 
            this.textBoxPersonelSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPersonelSifre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxPersonelSifre.Location = new System.Drawing.Point(148, 181);
            this.textBoxPersonelSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPersonelSifre.Name = "textBoxPersonelSifre";
            this.textBoxPersonelSifre.Size = new System.Drawing.Size(240, 32);
            this.textBoxPersonelSifre.TabIndex = 2;
            this.textBoxPersonelSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(65, 260);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(240, 50);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnClose.Location = new System.Drawing.Point(344, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(395, 370);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxPersonelNo);
            this.Controls.Add(this.textBoxPersonelSifre);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPassword);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
    }
}

