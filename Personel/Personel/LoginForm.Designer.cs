namespace Personel
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.LblUnut = new System.Windows.Forms.Label();
            this.LblKayit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtKadi
            // 
            this.txtKadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKadi.Location = new System.Drawing.Point(541, 247);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(409, 53);
            this.txtKadi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(541, 348);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(409, 53);
            this.txtSifre.TabIndex = 3;
            // 
            // LblUnut
            // 
            this.LblUnut.AutoSize = true;
            this.LblUnut.BackColor = System.Drawing.Color.Transparent;
            this.LblUnut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblUnut.Location = new System.Drawing.Point(541, 555);
            this.LblUnut.Name = "LblUnut";
            this.LblUnut.Size = new System.Drawing.Size(373, 36);
            this.LblUnut.TabIndex = 5;
            this.LblUnut.Text = "Kullanıcı Adı/Şifre unuttum.";
            this.LblUnut.Click += new System.EventHandler(this.LblUnut_Click);
            // 
            // LblKayit
            // 
            this.LblKayit.AutoSize = true;
            this.LblKayit.BackColor = System.Drawing.Color.Transparent;
            this.LblKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKayit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblKayit.Location = new System.Drawing.Point(541, 609);
            this.LblKayit.Name = "LblKayit";
            this.LblKayit.Size = new System.Drawing.Size(121, 36);
            this.LblKayit.TabIndex = 6;
            this.LblKayit.Text = "Kayıt ol.";
            this.LblKayit.Click += new System.EventHandler(this.LblKayit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1245, 107);
            this.label5.TabIndex = 7;
            this.label5.Text = "Personel Takip Giriş";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.Location = new System.Drawing.Point(541, 443);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(409, 86);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Personel.Properties.Resources.Gemini_Generated_Image_fqmf9yfqmf9yfqmf;
            this.ClientSize = new System.Drawing.Size(1385, 760);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblKayit);
            this.Controls.Add(this.LblUnut);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label LblUnut;
        private System.Windows.Forms.Label LblKayit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGiris;
    }
}

