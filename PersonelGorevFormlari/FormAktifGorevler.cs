﻿using System;
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
    public partial class FormAktifGorevler : Form
    {
        IsTakipEntities db = new IsTakipEntities();
        public string mail2;
        public FormAktifGorevler()
        {
            InitializeComponent();
        }

        private void FormAktifGorevler_Load(object sender, EventArgs e)
        {
            var pid = db.TblPersonel.Where(x => x.Mail == mail2).Select(y=>y.Id).FirstOrDefault();

            var degerler = (from x in db.TblGorevler
                            select new
                            {
                                x.Id,
                                x.Aciklama,
                                x.Tarih,
                                x.GorevAlan,
                                x.Durum
                            }).Where(x => x.GorevAlan == pid && x.Durum == true).ToList();
            gridControl1.DataSource = degerler;
            gridView1.Columns["GorevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;


        }
    }
}
