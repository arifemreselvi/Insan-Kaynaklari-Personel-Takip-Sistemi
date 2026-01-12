using Personel.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel
{
    public partial class DepartmanForm : Form
    {
        public DepartmanForm()
        {
            InitializeComponent();
        }
        private int SeciliIdGetir()
        {
            if (departmanListBox.SelectedItem == null)
            {
                return 0;
            }
            string seciliMetin = departmanListBox.SelectedItem.ToString();
            int noktaIndex = seciliMetin.IndexOf('.');
            return Convert.ToInt32(seciliMetin.Substring(0, noktaIndex));
        }
        private void DepartmanForm_Load(object sender, EventArgs e)
        {
            departmanOku();
        }
        public void departmanOku()
        {
            departmanListBox.Items.Clear();
            ArrayList liste = (new Service.DepartmanService()).departmanlarGetir();

            foreach (Departman d in liste)
            {
                departmanListBox.Items.Add(d.DepartmanId+". | Ad: "+d.Adi+" | İletişim: "+ d.Iletisim+" | Kat: "+d.Kat);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (depAdTxt.Text == "")
            {
                MessageBox.Show("Departman bilgileri eksik girildi.");
                return;
            }

            if (depIletisimTxt.Text == "")
            {
                MessageBox.Show("Departman bilgileri eksik girildi.");
                return;
            }

            if (depKatTxt.Text == "")
            {
                MessageBox.Show("Departman bilgileri eksik girildi.");
                return;
            }

            string ad = depAdTxt.Text;
            string iletisim = depIletisimTxt.Text;
            int kat = Convert.ToInt32(depKatTxt.Text);

            (new Service.DepartmanService()).departmanKaydet(ad, iletisim, kat);
            MessageBox.Show("Departman sisteme başarıyla eklendi.");
            departmanOku();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = SeciliIdGetir();

            if (id == 0)
            {
                MessageBox.Show("Departman Seçilemedi.");
                return;
            }
            (new Service.DepartmanService()).departmanSil(id);
            MessageBox.Show("Departman başarıyla kaldırıldı.");
            departmanOku();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = SeciliIdGetir();
            if (id == 0)
            {
                MessageBox.Show("Departman Seçilemedi.");
                return;
            }

            if (depAdTxt.Text == "")
            {
                MessageBox.Show("Departman bilgileri eksik girildi.");
                return;
            }

            if (depIletisimTxt.Text == "")
            {
                MessageBox.Show("Departman bilgileri eksik girildi.");
                return;
            }

            if (depKatTxt.Text == "")
            {
                MessageBox.Show("Departman bilgileri eksik girildi.");
                return;
            }
            string yeniAd = depAdTxt.Text;
            string yeniIletisim = depIletisimTxt.Text;
            int yeniKat = Convert.ToInt32(depKatTxt.Text);
            (new Service.DepartmanService()).departmanGuncelle(id, yeniAd, yeniIletisim, yeniKat);
            MessageBox.Show("Departman başarıyla güncellendi.");
            departmanOku();
        }
    }
}
