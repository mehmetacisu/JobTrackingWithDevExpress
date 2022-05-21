
namespace IsTakipProjeKursu.Formlar
{
    partial class FormPersoneller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersoneller));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditDepartman = new DevExpress.XtraEditors.LookUpEdit();
            this.buttonGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSil = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEkle = new DevExpress.XtraEditors.SimpleButton();
            this.buttonListele = new DevExpress.XtraEditors.SimpleButton();
            this.textEditResim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEditSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(594, 341);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEditDepartman);
            this.groupControl1.Controls.Add(this.buttonGuncelle);
            this.groupControl1.Controls.Add(this.buttonSil);
            this.groupControl1.Controls.Add(this.buttonEkle);
            this.groupControl1.Controls.Add(this.buttonListele);
            this.groupControl1.Controls.Add(this.textEditResim);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textEditMail);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textEditSoyad);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textEditAd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textEditId);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(602, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(365, 341);
            this.groupControl1.TabIndex = 3;
            // 
            // lookUpEditDepartman
            // 
            this.lookUpEditDepartman.EditValue = "";
            this.lookUpEditDepartman.Location = new System.Drawing.Point(125, 174);
            this.lookUpEditDepartman.Name = "lookUpEditDepartman";
            this.lookUpEditDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDepartman.Size = new System.Drawing.Size(209, 20);
            this.lookUpEditDepartman.TabIndex = 3;
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuncelle.ImageOptions.Image")));
            this.buttonGuncelle.Location = new System.Drawing.Point(125, 295);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(209, 27);
            this.buttonGuncelle.TabIndex = 2;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonSil.ImageOptions.Image")));
            this.buttonSil.Location = new System.Drawing.Point(125, 262);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(209, 27);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Sil";
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEkle.ImageOptions.Image")));
            this.buttonEkle.Location = new System.Drawing.Point(125, 229);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(209, 27);
            this.buttonEkle.TabIndex = 2;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonListele.ImageOptions.Image")));
            this.buttonListele.Location = new System.Drawing.Point(125, 196);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(209, 27);
            this.buttonListele.TabIndex = 2;
            this.buttonListele.Text = "Listele";
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // textEditResim
            // 
            this.textEditResim.Location = new System.Drawing.Point(125, 147);
            this.textEditResim.Name = "textEditResim";
            this.textEditResim.Size = new System.Drawing.Size(209, 20);
            this.textEditResim.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(54, 176);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Departman:";
            // 
            // textEditMail
            // 
            this.textEditMail.Location = new System.Drawing.Point(125, 121);
            this.textEditMail.Name = "textEditMail";
            this.textEditMail.Size = new System.Drawing.Size(209, 20);
            this.textEditMail.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(77, 150);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Görsel:";
            // 
            // textEditSoyad
            // 
            this.textEditSoyad.Location = new System.Drawing.Point(125, 95);
            this.textEditSoyad.Name = "textEditSoyad";
            this.textEditSoyad.Size = new System.Drawing.Size(209, 20);
            this.textEditSoyad.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(89, 124);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(22, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Mail:";
            // 
            // textEditAd
            // 
            this.textEditAd.Location = new System.Drawing.Point(125, 69);
            this.textEditAd.Name = "textEditAd";
            this.textEditAd.Size = new System.Drawing.Size(209, 20);
            this.textEditAd.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(75, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Soyadı:";
            // 
            // textEditId
            // 
            this.textEditId.Location = new System.Drawing.Point(125, 43);
            this.textEditId.Name = "textEditId";
            this.textEditId.Size = new System.Drawing.Size(209, 20);
            this.textEditId.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(92, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Adı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel ID:";
            // 
            // FormPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 346);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormPersoneller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.FormPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton buttonGuncelle;
        private DevExpress.XtraEditors.SimpleButton buttonSil;
        private DevExpress.XtraEditors.SimpleButton buttonEkle;
        private DevExpress.XtraEditors.SimpleButton buttonListele;
        private DevExpress.XtraEditors.TextEdit textEditAd;
        private DevExpress.XtraEditors.TextEdit textEditId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDepartman;
        private DevExpress.XtraEditors.TextEdit textEditResim;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEditMail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEditSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}