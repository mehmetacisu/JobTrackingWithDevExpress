using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipProjeKursu.PersonelGorevFormlari
{
    public partial class FormPersonelFormu : Form
    {
        public FormPersonelFormu()
        {
            InitializeComponent();
        }
        PersonelGorevFormlari.FormAktifGorevler aktifGorevler;
        public string mail;
        private void FormPersonelFormu_Load(object sender, EventArgs e)
        {
            if (aktifGorevler == null || aktifGorevler.IsDisposed)
            {
                aktifGorevler = new FormAktifGorevler();
                aktifGorevler.MdiParent = this;
                aktifGorevler.mail2 = mail;
                aktifGorevler.Show();
            }

        }
        PersonelGorevFormlari.FormPasifGörevler pasifGorevler;
        private void barButtonItemPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pasifGorevler == null || pasifGorevler.IsDisposed)
            {
                pasifGorevler = new FormPasifGörevler();
                pasifGorevler.mail2 = mail;
                pasifGorevler.MdiParent = this;
                pasifGorevler.Show();
            }

        }
        PersonelGorevFormlari.FormCagriListesi cagriListesi;

        private void barButtonItemCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cagriListesi == null || cagriListesi.IsDisposed)
            {
                cagriListesi = new FormCagriListesi();
                cagriListesi.mail2 = mail;
                cagriListesi.MdiParent = this;
                cagriListesi.Show();
            }
        }
    }
}
