using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IsTakipProjeKursu.Entity;

namespace IsTakipProjeKursu.Formlar
{
    public partial class FormAnasayfa : Form
    {
        IsTakipEntities db = new IsTakipEntities();
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void FormAnasayfa_Load(object sender, EventArgs e)
        {
            GorevleriGetir();
        }

        private void GorevleriGetir()
        {
            //Devam Eden Görevler
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           x.Aciklama,
                                           Personel = x.TblPersonel.Ad + " " + x.TblPersonel.Soyad,
                                           x.Durum
                                       }).Where(y => y.Durum == true).ToList();
            gridView1.Columns["Durum"].Visible = false;

            //Bugün Yapılan Görevler
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = (from x in db.TblGorevDetaylar
                                       select new
                                       {
                                           Gorev = x.TblGorevler.Aciklama,
                                           x.Aciklama,
                                           x.Tarih
                                       }).Where(x => x.Tarih == bugun).ToList();

            //Aktif Çağrı Listesi
            gridControl3.DataSource = (from x in db.TblCagrilar
                                       select new
                                       {
                                           x.TblFirmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(x => x.Durum == true).ToList();
            gridView3.Columns["Durum"].Visible = false;


            //Fihrist Komutları
            gridControl4.DataSource = (from x in db.TblFirmalar
                                       select new
                                       {
                                           x.Ad,
                                           x.Telefon,
                                           x.Mail
                                       }).ToList();

            //Çağrı Grafikleri

            int aktifCagrilar =db.TblCagrilar.Where(x=> x.Durum ==true).Count();
            int pasifCagrilar = db.TblCagrilar.Where(x=>x.Durum==false).Count();

            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar", aktifCagrilar);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar", pasifCagrilar);
        }
    }
}
