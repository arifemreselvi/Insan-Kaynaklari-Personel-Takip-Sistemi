namespace Personel
{
    partial class DepartmanForm
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
            this.depAdTxt = new System.Windows.Forms.TextBox();
            this.depIletisimTxt = new System.Windows.Forms.TextBox();
            this.depKatTxt = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.departmanListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // depAdTxt
            // 
            this.depAdTxt.Location = new System.Drawing.Point(620, 71);
            this.depAdTxt.Name = "depAdTxt";
            this.depAdTxt.Size = new System.Drawing.Size(146, 26);
            this.depAdTxt.TabIndex = 0;
            // 
            // depIletisimTxt
            // 
            this.depIletisimTxt.Location = new System.Drawing.Point(620, 139);
            this.depIletisimTxt.Name = "depIletisimTxt";
            this.depIletisimTxt.Size = new System.Drawing.Size(146, 26);
            this.depIletisimTxt.TabIndex = 1;
            // 
            // depKatTxt
            // 
            this.depKatTxt.Location = new System.Drawing.Point(620, 208);
            this.depKatTxt.Name = "depKatTxt";
            this.depKatTxt.Size = new System.Drawing.Size(146, 26);
            this.depKatTxt.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(482, 261);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(304, 40);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Departman Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // departmanListBox
            // 
            this.departmanListBox.FormattingEnabled = true;
            this.departmanListBox.ItemHeight = 20;
            this.departmanListBox.Location = new System.Drawing.Point(27, 10);
            this.departmanListBox.Name = "departmanListBox";
            this.departmanListBox.Size = new System.Drawing.Size(410, 424);
            this.departmanListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(482, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Departman Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(478, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departman İletişim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(482, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Departman Katı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(482, 322);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(304, 40);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Departman Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(482, 377);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(304, 40);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Departman Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // DepartmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(822, 442);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmanListBox);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.depKatTxt);
            this.Controls.Add(this.depIletisimTxt);
            this.Controls.Add(this.depAdTxt);
            this.Name = "DepartmanForm";
            this.Text = "DepartmanForm";
            this.Load += new System.EventHandler(this.DepartmanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox depAdTxt;
        private System.Windows.Forms.TextBox depIletisimTxt;
        private System.Windows.Forms.TextBox depKatTxt;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox departmanListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}