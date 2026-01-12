namespace Personel
{
    partial class RaporForm
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
            this.cmbRaporlar = new System.Windows.Forms.ComboBox();
            this.lstSonuclar = new System.Windows.Forms.ListBox();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.dtpBas = new System.Windows.Forms.DateTimePicker();
            this.dtpBit = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbRaporlar
            // 
            this.cmbRaporlar.FormattingEnabled = true;
            this.cmbRaporlar.Items.AddRange(new object[] {
            "Departman Bazlı Dağılım",
            "İzin Raporu",
            "Maaş Raporu",
            "Performans Raporu"});
            this.cmbRaporlar.Location = new System.Drawing.Point(579, 55);
            this.cmbRaporlar.Name = "cmbRaporlar";
            this.cmbRaporlar.Size = new System.Drawing.Size(200, 28);
            this.cmbRaporlar.TabIndex = 0;
            // 
            // lstSonuclar
            // 
            this.lstSonuclar.FormattingEnabled = true;
            this.lstSonuclar.ItemHeight = 20;
            this.lstSonuclar.Location = new System.Drawing.Point(12, 12);
            this.lstSonuclar.Name = "lstSonuclar";
            this.lstSonuclar.Size = new System.Drawing.Size(506, 344);
            this.lstSonuclar.TabIndex = 1;
            // 
            // btnRaporla
            // 
            this.btnRaporla.Location = new System.Drawing.Point(574, 294);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(205, 41);
            this.btnRaporla.TabIndex = 2;
            this.btnRaporla.Text = "Rapor Arat";
            this.btnRaporla.UseVisualStyleBackColor = true;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // dtpBas
            // 
            this.dtpBas.Location = new System.Drawing.Point(579, 141);
            this.dtpBas.Name = "dtpBas";
            this.dtpBas.Size = new System.Drawing.Size(200, 26);
            this.dtpBas.TabIndex = 3;
            // 
            // dtpBit
            // 
            this.dtpBit.Location = new System.Drawing.Point(579, 233);
            this.dtpBit.Name = "dtpBit";
            this.dtpBit.Size = new System.Drawing.Size(200, 26);
            this.dtpBit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rapor Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBit);
            this.Controls.Add(this.dtpBas);
            this.Controls.Add(this.btnRaporla);
            this.Controls.Add(this.lstSonuclar);
            this.Controls.Add(this.cmbRaporlar);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRaporlar;
        private System.Windows.Forms.ListBox lstSonuclar;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.DateTimePicker dtpBas;
        private System.Windows.Forms.DateTimePicker dtpBit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}