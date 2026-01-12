using Personel.Service;
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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            personelListele();
            int sayi = (new Service.PersonelService()).personelleriGetir().Count;
            label5.Text = "(" + sayi + " tane personel bulundu).";
            ArrayList depListe = (new Service.DepartmanService()).departmanlarGetir();
            departmanCombo.DataSource = depListe;
            departmanCombo.DisplayMember = "Adi";
            departmanCombo.ValueMember = "DepartmanId";
        }
        public void personelListele()
        {
            personelListBox.Items.Clear();
            ArrayList liste = (new Service.PersonelService()).personelleriGetir();

            foreach (Personel.Domain.Personel p in liste)
            {
                personelListBox.Items.Add(p);
            }
        }
        private void btnPersonelKaydet_Click_1(object sender, EventArgs e)
        {
            if (adSoyadTxt.Text == "")
            {
                MessageBox.Show("Personel bilgileri eksik verildi.");
                return;
            }
            else if (maasTxt.Text == "")
            {
                MessageBox.Show("Maaş bilgileri eksik verildi.");
                return;
            }
            else if (Convert.ToDouble(maasTxt.Text) < 28075.50)
            {
                MessageBox.Show("Belirtilen maaş asgari ücretin altında olduğundan kabul edilmemektedir.");
                return;
            }
            else if (departmanCombo.Items.Count == 0)
            {
                MessageBox.Show("Departman bilgileri eksik verildi.");
                return;
            }
            else
            {
                string ad = adSoyadTxt.Text;
                int maas = Convert.ToInt32(maasTxt.Text);
                int depId = Convert.ToInt32(departmanCombo.SelectedValue);

                (new PersonelService()).personelKaydet(ad, maas, depId);
                MessageBox.Show("Personel sisteme başarıyla eklendi");
                personelListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (personelListBox.SelectedItem != null)
            {
                Personel.Domain.Personel seciliPersonel = (Personel.Domain.Personel)personelListBox.SelectedItem;
                (new Service.PersonelService()).personelSil(seciliPersonel.PersonelId);
                MessageBox.Show("Personel sistemden başarıyla kaldırıldı.");
            }
            else
            {
                MessageBox.Show("Personel seçilemedi.");
            }
        }

        private void personelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personelListBox.SelectedItem != null)
            {
                Personel.Domain.Personel secili = (Personel.Domain.Personel)personelListBox.SelectedItem;
                adSoyadTxt.Text = secili.AdSoyad;
                maasTxt.Text = secili.Maas.ToString();
                departmanCombo.SelectedValue = secili.DepartmanId;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (personelListBox.SelectedItem != null)
            {

                Personel.Domain.Personel secili = (Personel.Domain.Personel)personelListBox.SelectedItem;

                string ad = adSoyadTxt.Text;
                int maas = Convert.ToInt32(maasTxt.Text);
                int depId = Convert.ToInt32(departmanCombo.SelectedValue);

                if (Convert.ToDouble(maas) < 28075.50)
                {
                    MessageBox.Show("Belirtilen maaş asgari ücretin altında olduğundan kabul edilmemektedir.");
                    return;
                }
                else
                {
                    (new Service.PersonelService()).personelGuncelle(secili.PersonelId, ad, maas, depId);

                    MessageBox.Show("Personel bilgileri başarıyla güncellendi.");
                    personelListele();
                }
            }
            else
            {
                MessageBox.Show("Personel seçilemedi.");
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            personelListBox.Items.Clear();
            ArrayList liste = (new Service.PersonelService()).personelleriGetir();

            foreach (Personel.Domain.Personel p in liste)
            {
                if (p.AdSoyad.ToLower().Contains(txtArama.Text.ToLower()))
                {
                    personelListBox.Items.Add(p);
                    string kisiSayisi = (personelListBox.Items.Count).ToString();
                    label5.Text = "(" + kisiSayisi + " tane personel bulundu).";
                }
                else if (personelListBox.Items.Count == 0)
                {
                    string kisiSayisi = (personelListBox.Items.Count).ToString();
                    label5.Text = "(Belirtilen kriterlerde personel bulunamadı.)";
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
