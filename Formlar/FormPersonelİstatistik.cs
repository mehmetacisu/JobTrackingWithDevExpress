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
    public partial class FormPersonelİstatistik : Form
    {
        IsTakipEntities db = new IsTakipEntities();
        public FormPersonelİstatistik()
        {
            InitializeComponent();
        }

        private void FormPersonelİstatistik_Load(object sender, EventArgs e)
        {
            IstatistikleriGetir();
        }

        private void IstatistikleriGetir()
        {
            labelToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();
            labelToplamFirma.Text = db.TblFirmalar.Count().ToString();
            labelToplamPersonel.Text = db.TblPersonel.Count().ToString();
            labelAktifIs.Text = db.TblGorevler.Count(x => x.Durum == true).ToString();
            labelPasifIs.Text = db.TblGorevler.Count(x => x.Durum ==false).ToString();
            labelSonGorev.Text = db.TblGorevler.OrderByDescending(x => x.Id).Select(x =>
             x.Aciklama).FirstOrDefault(); //verileri ters çevirip en başta ki veriyi çekmek için kullandık. 
            labelSonGorevTarih.Text = db.TblGorevler.OrderByDescending(x => x.Id).Select(x =>
             x.Tarih).FirstOrDefault().ToString();
            labelIsYapilanSehir.Text = db.TblFirmalar.Select(x =>
            x.il).Distinct().Count().ToString(); // illeri seçtikten sonra distinct ile tekrar eden kayıtları saydırmadan kaç farklı şehire iş yapıldığını bulduk.
            labelSektorSayisi.Text = db.TblFirmalar.Select(x =>
            x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            labelBugunAcilanGorevler.Text = db.TblGorevler.Count(x => x.Tarih == bugun).ToString();
            var ayinPersoneli = db.TblGorevler.GroupBy(x =>
            x.GorevAlan).OrderByDescending(z => z.Count()).Select(y =>
              y.Key).FirstOrDefault(); // group by ile gorev alanları grupladıktan sonra desc ile z'den a'ya sıralayıp
                                       // en çok görev alanın sayısını aldık (Key ile ID yi çektik), ondan sonra firstordefault ile de tek'e düşürerek değeri aldık.
                                       //sql sorgusu  select GorevAlan,Count(*) From TblGorevler Group By GorevAlan order by COUNT(*) Desc
            labelAyinPersoneli.Text = db.TblPersonel.Where(y => y.Id == ayinPersoneli).Select(y =>
            y.Ad + " " + y.Soyad).FirstOrDefault().ToString(); // üstte aldığımız değeri where ile nerede olduğunu bulduk,
                                                               // select ile ad ve soyadını yazdırdık.
            labelAyinDepartmani.Text = db.TblDepartmanlar.Where(x => x.Id == db.TblPersonel.Where(
                t => t.Id == ayinPersoneli).Select(z => z.Departman).FirstOrDefault()). //ayın personelini Id ile bulduktan sonra departmanını bulduk
                Select(y => y.Ad).FirstOrDefault().ToString(); // daha sonra ise departmanın adını bulup yazdırdık.
        }
    }
}
