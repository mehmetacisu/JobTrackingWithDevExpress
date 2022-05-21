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
    public partial class FormGorevListesi : Form
    {
        IsTakipEntities db = new IsTakipEntities();

        public FormGorevListesi()
        {
            InitializeComponent();
        }

        private void FormGorevListesi_Load(object sender, EventArgs e)
        {
            IstatistikleriGetir();
        }

        private void IstatistikleriGetir()
        {
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           x.Aciklama
                                       }).ToList();
            labelAktifGorev.Text = db.TblGorevler.Where(x => x.Durum == true).Count().ToString();
            labelPasifGorev.Text = db.TblGorevler.Where(x => x.Durum == false).Count().ToString();
            labelToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(labelAktifGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(labelPasifGorev.Text));


            
        }
    }
}
