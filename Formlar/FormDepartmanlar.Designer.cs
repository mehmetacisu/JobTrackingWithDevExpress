
namespace IsTakipProjeKursu.Formlar
{
    partial class FormDepartmanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartmanlar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.buttonGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSil = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEkle = new DevExpress.XtraEditors.SimpleButton();
            this.buttonListele = new DevExpress.XtraEditors.SimpleButton();
            this.textEditAd = new DevExpress.XtraEditors.TextEdit();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(594, 340);
            this.gridControl1.TabIndex = 0;
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
            this.groupControl1.Controls.Add(this.buttonGuncelle);
            this.groupControl1.Controls.Add(this.buttonSil);
            this.groupControl1.Controls.Add(this.buttonEkle);
            this.groupControl1.Controls.Add(this.buttonListele);
            this.groupControl1.Controls.Add(this.textEditAd);
            this.groupControl1.Controls.Add(this.textEditId);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(602, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(365, 340);
            this.groupControl1.TabIndex = 1;
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuncelle.ImageOptions.Image")));
            this.buttonGuncelle.Location = new System.Drawing.Point(95, 234);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(162, 27);
            this.buttonGuncelle.TabIndex = 2;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonSil.ImageOptions.Image")));
            this.buttonSil.Location = new System.Drawing.Point(95, 190);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(162, 27);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Sil";
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEkle.ImageOptions.Image")));
            this.buttonEkle.Location = new System.Drawing.Point(95, 147);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(162, 27);
            this.buttonEkle.TabIndex = 2;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonListele.ImageOptions.Image")));
            this.buttonListele.Location = new System.Drawing.Point(95, 105);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(162, 27);
            this.buttonListele.TabIndex = 2;
            this.buttonListele.Text = "Listele";
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // textEditAd
            // 
            this.textEditAd.Location = new System.Drawing.Point(95, 69);
            this.textEditAd.Name = "textEditAd";
            this.textEditAd.Size = new System.Drawing.Size(162, 20);
            this.textEditAd.TabIndex = 1;
            // 
            // textEditId
            // 
            this.textEditId.Enabled = false;
            this.textEditId.Location = new System.Drawing.Point(95, 26);
            this.textEditId.Name = "textEditId";
            this.textEditId.Size = new System.Drawing.Size(162, 20);
            this.textEditId.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Departman Adı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Departman ID:";
            // 
            // FormDepartmanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 346);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormDepartmanlar";
            this.Text = "Departmanlar";
            this.Load += new System.EventHandler(this.FormDepartmanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
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
    }
}