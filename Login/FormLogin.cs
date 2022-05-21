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

namespace IsTakipProjeKursu.Login
{
    public partial class FormLogin : Form
    {
        IsTakipEntities db = new IsTakipEntities();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void hyperlinkLabelControl4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            var admin = db.TblAdmin.Where(x => x.Kullanici == textEditKullanici.Text && x.Sifre == textEditSifre.Text).FirstOrDefault();
            if (admin!=null)
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş !");
            }
        }

        private void buttonPersonel_Click(object sender, EventArgs e)
        {
            var personel = db.TblPersonel.Where(x => x.Mail == textEditKullanici.Text && x.Sifre == textEditSifre.Text).FirstOrDefault();
            if (personel!=null)
            {
                PersonelGorevFormlari.FormPersonelFormu formPersonel = new PersonelGorevFormlari.FormPersonelFormu();
                formPersonel.mail = textEditKullanici.Text;
                formPersonel.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş !");
            }
        }
    }
}
