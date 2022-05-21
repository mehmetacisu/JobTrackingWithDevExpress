using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipProjeKursu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FormDepartmanlar departmanlar;
        private void ButtonDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (departmanlar == null || departmanlar.IsDisposed)
            {
                departmanlar = new Formlar.FormDepartmanlar();
                departmanlar.MdiParent = this;
                departmanlar.Show();
            }

        }
        Formlar.FormPersoneller personeller;
        private void buttonPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personeller == null || personeller.IsDisposed)
            {
                personeller = new Formlar.FormPersoneller();
                personeller.MdiParent = this;
                personeller.Show();
            }

        }
        Formlar.FormPersonelİstatistik personelİstatistik;
        private void buttonPersonelİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personelİstatistik == null || personelİstatistik.IsDisposed)
            {
                personelİstatistik = new Formlar.FormPersonelİstatistik();
                personelİstatistik.MdiParent = this;
                personelİstatistik.Show();
            }
        }
        Formlar.FormGorevListesi gorevListesi;
        private void buttonGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gorevListesi == null || gorevListesi.IsDisposed)
            {
                gorevListesi = new Formlar.FormGorevListesi();
                gorevListesi.MdiParent = this;
                gorevListesi.Show();
            }
        }

        private void buttonGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormGorev gorev = new Formlar.FormGorev();
            gorev.Show();
        }

        private void buttonGorevDetaylari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormGorevDetay gorevDetay = new Formlar.FormGorevDetay();
            gorevDetay.Show();
        }
        Formlar.FormAnasayfa anasayfa;
        private void buttonAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anasayfa == null || anasayfa.IsDisposed)
            {
                anasayfa = new Formlar.FormAnasayfa();
                anasayfa.MdiParent = this;
                anasayfa.Show();
            }

        }

        Formlar.FormAktifCagrilar aktifCagrilar;
        private void barButtonItemAktifCagri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (aktifCagrilar == null || aktifCagrilar.IsDisposed)
            {
                aktifCagrilar = new Formlar.FormAktifCagrilar();
                aktifCagrilar.MdiParent = this;
                aktifCagrilar.Show();
            }
        }
    }
}
