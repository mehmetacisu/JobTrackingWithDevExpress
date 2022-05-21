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

namespace IsTakipProjeKursu.PersonelGorevFormlari
{
    public partial class FormCagriDetay : Form
    {
        IsTakipEntities db = new IsTakipEntities();
        public FormCagriDetay()
        {
            InitializeComponent();
        }

        private void buttonVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int id;

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            TblCagriDetay detay = new TblCagriDetay();
            detay.Cagri = int.Parse(textEditCagriId.Text);
            detay.Saat = textEditSaat.Text;
            detay.Tarih = DateTime.Parse(textEditTarih.Text);
            detay.Aciklama = textEditAciklama.Text;
            db.TblCagriDetay.Add(detay);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı detayı başarıyla kaydedildi.");
        }

        private void FormCagriDetay_Load(object sender, EventArgs e)
        {
            textEditCagriId.Enabled = false;
            textEditCagriId.Text = id.ToString();
            string saat, tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            textEditTarih.Text = tarih;
            textEditSaat.Text = saat;
        }
    }
}
