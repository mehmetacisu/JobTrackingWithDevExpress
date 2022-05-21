using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IsTakipProjeKursu.Entity;

namespace IsTakipProjeKursu.Formlar
{
    public partial class FormGorev : Form
    {
        IsTakipEntities db = new IsTakipEntities();
        public FormGorev()
        {
            InitializeComponent();
        }

        private void buttonVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            TblGorevler gorev = new TblGorevler();
            gorev.Aciklama = textEditAciklama.Text;
            gorev.Durum = true;
            gorev.GorevAlan = int.Parse(lookUpEditGorevAlan.EditValue.ToString());
            gorev.Tarih = DateTime.Parse(textEditTarih.Text);
            gorev.GorevVeren = 1;
            db.TblGorevler.Add(gorev);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başarıyla Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FormGorev_Load(object sender, EventArgs e)
        {
            GorevAlacaklariGetir();
        }

        private void GorevAlacaklariGetir()
        {
            var personeller = (from x in db.TblPersonel
                               select new
                               {
                                   x.Id,
                                   AdSoyad = x.Ad +" "+ x.Soyad
                               }).ToList();
            lookUpEditGorevAlan.Properties.ValueMember = "Id";
            lookUpEditGorevAlan.Properties.DisplayMember = "AdSoyad";
            lookUpEditGorevAlan.Properties.DataSource = personeller;

        }
    }
}
