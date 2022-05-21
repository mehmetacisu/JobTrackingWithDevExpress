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
    public partial class FormCagriAtama : Form
    {
        IsTakipEntities db = new IsTakipEntities();
        public int id;
        public FormCagriAtama()
        {
            InitializeComponent();
        }
        private void FormCagriAtama_Load(object sender, EventArgs e)
        {
            //LookUpEdit verilerin listelenmesi
            var degerler = (from x in db.TblPersonel
                            select new
                            {
                                x.Id,
                                AdSoyad= x.Ad+ " "+x.Soyad
                            }).ToList();
            textEditCagriID.Text = id.ToString();
            var veri = db.TblCagrilar.Find(id);
            textEditAciklama.Text = veri.Aciklama;
            textEditTarih.Text = veri.Tarih.ToString();
            textEditKonu.Text = veri.Konu;

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            var veri = db.TblCagrilar.Find(id);
            veri.Konu = textEditKonu.Text;
            veri.Tarih = Convert.ToDateTime(textEditTarih.Text);
            veri.Aciklama = textEditAciklama.Text;
            veri.CagriPersoneli = int.Parse(lookUpEditGorevAlan.EditValue.ToString());
            db.SaveChanges();
        }
    }
}
