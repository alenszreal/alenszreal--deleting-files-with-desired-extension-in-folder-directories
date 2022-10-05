namespace KlasorTarmaSilmeDeneme
{
    partial class Form1
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
            this.txtSeciliKlasorPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDosyaUzanti = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtKalacakDosyaSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSeciliKlasorPath
            // 
            this.txtSeciliKlasorPath.Location = new System.Drawing.Point(215, 52);
            this.txtSeciliKlasorPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeciliKlasorPath.Name = "txtSeciliKlasorPath";
            this.txtSeciliKlasorPath.Size = new System.Drawing.Size(756, 22);
            this.txtSeciliKlasorPath.TabIndex = 0;
            this.txtSeciliKlasorPath.TextChanged += new System.EventHandler(this.txtSeciliKlasorPath_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Klasör Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kaç Dosya Kalsın :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDosyaUzanti
            // 
            this.txtDosyaUzanti.Location = new System.Drawing.Point(309, 167);
            this.txtDosyaUzanti.Margin = new System.Windows.Forms.Padding(4);
            this.txtDosyaUzanti.Name = "txtDosyaUzanti";
            this.txtDosyaUzanti.Size = new System.Drawing.Size(80, 22);
            this.txtDosyaUzanti.TabIndex = 4;
            this.txtDosyaUzanti.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(872, 446);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtKalacakDosyaSayisi
            // 
            this.txtKalacakDosyaSayisi.Location = new System.Drawing.Point(309, 273);
            this.txtKalacakDosyaSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKalacakDosyaSayisi.Name = "txtKalacakDosyaSayisi";
            this.txtKalacakDosyaSayisi.Size = new System.Drawing.Size(80, 22);
            this.txtKalacakDosyaSayisi.TabIndex = 6;
            this.txtKalacakDosyaSayisi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Silmek İstediğiniz Dosyanın Uzantısı :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKalacakDosyaSayisi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDosyaUzanti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSeciliKlasorPath);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Hızlı Dosya Silme Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeciliKlasorPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDosyaUzanti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtKalacakDosyaSayisi;
        private System.Windows.Forms.Label label1;
    }
}

