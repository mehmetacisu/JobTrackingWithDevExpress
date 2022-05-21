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
    public partial class FormPersoneller : Form
    {
        IsTakipEntities db = new IsTakipEntities();

        public FormPersoneller()
        {
            InitializeComponent();
        }
        private void FormPersoneller_Load(object sender, EventArgs e)
        {
            PersonelleriGetir();
            DepartmanlariGetir();
        }
         
        private void DepartmanlariGetir()
        {
            var departmanlar = (from x in db.TblDepartmanlar
                                select new
                                {
                                    x.Id,
                                    x.Ad
                                }).ToList();
            lookUpEditDepartman.Properties.ValueMember = "Id";
            lookUpEditDepartman.Properties.DisplayMember = "Ad";
            lookUpEditDepartman.Properties.DataSource = departmanlar;
        }

        private void PersonelleriGetir()
        {
            var personeller = from x in db.TblPersonel
                              select new
                              {
                                  x.Id,
                                  x.Ad,
                                  x.Soyad,
                                  x.Mail,
                                  Departman = x.TblDepartmanlar.Ad,
                                  x.Resim,
                                  x.Durum
                              };
            gridControl1.DataSource = personeller.Where(x=>x.Durum==true).ToList();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            TblPersonel personel = new TblPersonel();
            personel.Ad = textEditAd.Text;
            personel.Soyad = textEditSoyad.Text;
            personel.Mail = textEditMail.Text;
            personel.Resim = textEditResim.Text;
            personel.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            db.TblPersonel.Add(personel);
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarıyla eklendi","Bilgi",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            PersonelleriGetir();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textEditId.Text);
            var personel = db.TblPersonel.Find(id);
            personel.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarıyla silindi","Bilgi"
                ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            PersonelleriGetir();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textEditId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            textEditAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            textEditSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            textEditMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            textEditResim.Text = gridView1.GetFocusedRowCellValue("Resim").ToString();
            lookUpEditDepartman.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textEditId.Text);
            var personel = db.TblPersonel.Find(id);
            personel.Ad = textEditAd.Text;
            personel.Soyad = textEditSoyad.Text;
            personel.Mail = textEditMail.Text;
            personel.Resim = textEditResim.Text;
            personel.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarıyla güncellendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            PersonelleriGetir();
        }
    }
}

