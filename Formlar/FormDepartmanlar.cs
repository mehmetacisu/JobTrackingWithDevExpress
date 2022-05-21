using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsTakipProjeKursu.Entity;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace IsTakipProjeKursu.Formlar
{
    public partial class FormDepartmanlar : Form
    {
        IsTakipEntities db = new IsTakipEntities();
        public FormDepartmanlar()
        {
            InitializeComponent();
        }

        void Listele()
        {
            var degerler = (from x in db.TblDepartmanlar
                            select new
                            {
                                x.Id,
                                x.Ad
                            }).ToList();
            gridControl1.DataSource = degerler;
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            TblDepartmanlar departmanlar = new TblDepartmanlar();
            departmanlar.Ad = textEditAd.Text;
            db.TblDepartmanlar.Add(departmanlar);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarıyla eklendi",
                "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textEditId.Text);
            var deger = db.TblDepartmanlar.Find(id);
            db.TblDepartmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarıyla silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            Listele();
        }

        private void FormDepartmanlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textEditId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            textEditAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textEditId.Text);
            var deger = db.TblDepartmanlar.Find(id);
            deger.Ad = textEditAd.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }
    }
}
