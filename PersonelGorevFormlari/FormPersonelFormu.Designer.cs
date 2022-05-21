
namespace IsTakipProjeKursu.PersonelGorevFormlari
{
    partial class FormPersonelFormu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelFormu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAktifGorevler = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPasifGorevler = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCagriListesi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItemAktifGorevler,
            this.barButtonItemPasifGorevler,
            this.barButtonItemCagriListesi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(984, 150);
            // 
            // barButtonItemAktifGorevler
            // 
            this.barButtonItemAktifGorevler.Caption = "Aktif Görevler";
            this.barButtonItemAktifGorevler.Id = 1;
            this.barButtonItemAktifGorevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemAktifGorevler.ImageOptions.Image")));
            this.barButtonItemAktifGorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemAktifGorevler.ImageOptions.LargeImage")));
            this.barButtonItemAktifGorevler.Name = "barButtonItemAktifGorevler";
            // 
            // barButtonItemPasifGorevler
            // 
            this.barButtonItemPasifGorevler.Caption = "Pasif Görevler";
            this.barButtonItemPasifGorevler.Id = 2;
            this.barButtonItemPasifGorevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemPasifGorevler.ImageOptions.Image")));
            this.barButtonItemPasifGorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemPasifGorevler.ImageOptions.LargeImage")));
            this.barButtonItemPasifGorevler.Name = "barButtonItemPasifGorevler";
            this.barButtonItemPasifGorevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPasifGorevler_ItemClick);
            // 
            // barButtonItemCagriListesi
            // 
            this.barButtonItemCagriListesi.Caption = "Çağrı Listesi";
            this.barButtonItemCagriListesi.Id = 3;
            this.barButtonItemCagriListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemCagriListesi.ImageOptions.Image")));
            this.barButtonItemCagriListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCagriListesi.ImageOptions.LargeImage")));
            this.barButtonItemCagriListesi.Name = "barButtonItemCagriListesi";
            this.barButtonItemCagriListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCagriListesi_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAktifGorevler);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemPasifGorevler);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCagriListesi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormPersonelFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormPersonelFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPersonelFormu";
            this.Load += new System.EventHandler(this.FormPersonelFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAktifGorevler;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPasifGorevler;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCagriListesi;
    }
}