namespace Personel
{
    partial class PersonelForm
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
            this.personelListBox = new System.Windows.Forms.ListBox();
            this.adSoyadTxt = new System.Windows.Forms.TextBox();
            this.maasTxt = new System.Windows.Forms.TextBox();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.departmanCombo = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personelListBox
            // 
            this.personelListBox.FormattingEnabled = true;
            this.personelListBox.ItemHeight = 20;
            this.personelListBox.Location = new System.Drawing.Point(40, 100);
            this.personelListBox.Name = "personelListBox";
            this.personelListBox.Size = new System.Drawing.Size(168, 264);
            this.personelListBox.TabIndex = 0;
            this.personelListBox.SelectedIndexChanged += new System.EventHandler(this.personelListBox_SelectedIndexChanged);
            // 
            // adSoyadTxt
            // 
            this.adSoyadTxt.Location = new System.Drawing.Point(276, 129);
            this.adSoyadTxt.Name = "adSoyadTxt";
            this.adSoyadTxt.Size = new System.Drawing.Size(135, 26);
            this.adSoyadTxt.TabIndex = 1;
            // 
            // maasTxt
            // 
            this.maasTxt.Location = new System.Drawing.Point(276, 212);
            this.maasTxt.Name = "maasTxt";
            this.maasTxt.Size = new System.Drawing.Size(135, 26);
            this.maasTxt.TabIndex = 2;
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.Location = new System.Drawing.Point(487, 100);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(157, 55);
            this.btnPersonelKaydet.TabIndex = 4;
            this.btnPersonelKaydet.Text = "Personel Ekle";
            this.btnPersonelKaydet.UseVisualStyleBackColor = true;
            this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click_1);
            // 
            // departmanCombo
            // 
            this.departmanCombo.FormattingEnabled = true;
            this.departmanCombo.Location = new System.Drawing.Point(276, 299);
            this.departmanCombo.Name = "departmanCombo";
            this.departmanCombo.Size = new System.Drawing.Size(135, 28);
            this.departmanCombo.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(487, 184);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(157, 54);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Personel Kaldır";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(487, 273);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGuncelle.Size = new System.Drawing.Size(157, 54);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Personel Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(58, 57);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(120, 26);
            this.txtArama.TabIndex = 8;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Personel Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Personel Ad/Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Personel Maaş Tutarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Personel Departman";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(692, 382);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.departmanCombo);
            this.Controls.Add(this.btnPersonelKaydet);
            this.Controls.Add(this.maasTxt);
            this.Controls.Add(this.adSoyadTxt);
            this.Controls.Add(this.personelListBox);
            this.Name = "PersonelForm";
            this.Text = "PersonelForm";
            this.Load += new System.EventHandler(this.PersonelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox personelListBox;
        private System.Windows.Forms.TextBox adSoyadTxt;
        private System.Windows.Forms.TextBox maasTxt;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.ComboBox departmanCombo;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}