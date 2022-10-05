using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KlasorTarmaSilmeDeneme
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Klasör Seçimi.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                txtSeciliKlasorPath.Text = folderPath;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var kalacakDosyaSayisi = int.Parse(txtKalacakDosyaSayisi.Text);
            var seciliKlasor = new DirectoryInfo(txtSeciliKlasorPath.Text);
            if (seciliKlasor.Exists)
            {
                //klasorde dosya var mı?
                var silinecekDosyaListesi = seciliKlasor.EnumerateFiles($"*{txtDosyaUzanti.Text}").OrderByDescending(t => t.LastWriteTime).Skip(kalacakDosyaSayisi).ToArray();
                foreach (var silinecekDosya in silinecekDosyaListesi)
                {
                    silinecekDosya.Delete();
                    Directory.Delete(true)
                }               
                var altKlasorList = seciliKlasor.EnumerateDirectories();              
                if (altKlasorList.Length>0)
                {
                    foreach (var altKlasor in altKlasorList)
                    {
                        var silinecekDosyaListesiAlt = altKlasor.EnumerateFiles($"*{txtDosyaUzanti.Text}").OrderByDescending(t => t.LastWriteTime).Skip(kalacakDosyaSayisi).ToArray();
                        foreach (var silinecekDosyaAlt in silinecekDosyaListesiAlt)
                        {
                            silinecekDosyaAlt.Delete();
                            Directory.Delete(true);
                        }
                        MessageBox.Show("İşlem Başarılı");
                        }
                    }        
            }
            else
            {
                MessageBox.Show("Klasör Bulunamadı!");
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSeciliKlasorPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
