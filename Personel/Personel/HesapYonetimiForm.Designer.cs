namespace Personel
{
    partial class HesapYonetimiForm
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
            this.lstTalepler = new System.Windows.Forms.ListBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTalepler
            // 
            this.lstTalepler.FormattingEnabled = true;
            this.lstTalepler.ItemHeight = 20;
            this.lstTalepler.Location = new System.Drawing.Point(35, 48);
            this.lstTalepler.Name = "lstTalepler";
            this.lstTalepler.Size = new System.Drawing.Size(529, 304);
            this.lstTalepler.TabIndex = 0;
            this.lstTalepler.SelectedIndexChanged += new System.EventHandler(this.lstTalepler_SelectedIndexChanged);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOnayla.Location = new System.Drawing.Point(623, 109);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(97, 38);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.BackColor = System.Drawing.Color.Maroon;
            this.btnReddet.Location = new System.Drawing.Point(623, 261);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(101, 38);
            this.btnReddet.TabIndex = 2;
            this.btnReddet.UseVisualStyleBackColor = false;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Talep Onayla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Talep Reddet";
            // 
            // HesapYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.lstTalepler);
            this.Name = "HesapYonetimiForm";
            this.Text = "HesapYonetimiForm";
            this.Load += new System.EventHandler(this.HesapYonetimiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTalepler;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}