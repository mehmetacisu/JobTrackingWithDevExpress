using IsTakipProjeKursu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipProjeKursu.Formlar
{
    public partial class FormAktifCagrilar : Form
    {
        IsTakipEntities db = new IsTakipEntities();

        public FormAktifCagrilar()
        {
            InitializeComponent();
        }

        private void FormAktifCagrilar_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblCagrilar
                select new
                {
                    x.Id,
                    x.TblFirmalar.Ad,
                    x.TblFirmalar.Telefon,
                    x.Konu,
                    x.Aciklama,
                    Personel = x.TblPersonel.Ad,
                    x.Durum
                }).Where(y => y.Durum == true).ToList();
            gridControl1.DataSource = degerler;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormCagriAtama fr = new FormCagriAtama();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            fr.Show();
        }
    }
}
