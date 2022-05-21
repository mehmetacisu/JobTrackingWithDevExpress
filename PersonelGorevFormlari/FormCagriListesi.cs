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


namespace IsTakipProjeKursu.PersonelGorevFormlari
{
    public partial class FormCagriListesi : Form
    {
        IsTakipEntities db = new IsTakipEntities();
        public string mail2;
        public FormCagriListesi()
        {
            InitializeComponent();
        }

        private void FormCagriListesi_Load(object sender, EventArgs e)
        {
            var personelid = db.TblPersonel.Where(x => x.Mail == mail2).Select(y => y.Id).FirstOrDefault();
            gridControl1.DataSource = (from x in db.TblCagrilar
                                       select new
                                       {
                                           x.Id,
                                           x.TblFirmalar.Ad,
                                           x.TblFirmalar.Telefon,
                                           x.TblFirmalar.Mail,
                                           x.Aciklama,
                                           x.CagriPersoneli,
                                           x.Durum
                                       }).Where(y => y.Durum == true && y.CagriPersoneli == personelid).ToList();
            gridView1.Columns["Durum"].Visible = false;
            gridView1.Columns["CagriPersoneli"].Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormCagriDetay fr = new FormCagriDetay();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            fr.Show();
        }
    }
}
