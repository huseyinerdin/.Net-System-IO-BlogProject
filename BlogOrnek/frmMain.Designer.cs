
namespace BlogOrnek
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolBarMenu = new System.Windows.Forms.ToolStrip();
            this.btnBlogKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnBlogKapat = new System.Windows.Forms.ToolStripButton();
            this.btnYeniBlog = new System.Windows.Forms.ToolStripButton();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blokKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blokKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniBlogGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblGuncelDosyaTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAktifBlogSayisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrSaniye = new System.Windows.Forms.Timer(this.components);
            this.kayıtYeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarMenu.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBarMenu
            // 
            this.toolBarMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBlogKaydet,
            this.btnBlogKapat,
            this.btnYeniBlog});
            this.toolBarMenu.Location = new System.Drawing.Point(0, 28);
            this.toolBarMenu.Name = "toolBarMenu";
            this.toolBarMenu.Size = new System.Drawing.Size(800, 27);
            this.toolBarMenu.TabIndex = 4;
            this.toolBarMenu.Text = "toolStrip1";
            // 
            // btnBlogKaydet
            // 
            this.btnBlogKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnBlogKaydet.Image")));
            this.btnBlogKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBlogKaydet.Name = "btnBlogKaydet";
            this.btnBlogKaydet.Size = new System.Drawing.Size(114, 24);
            this.btnBlogKaydet.Text = "Blog Kaydet";
            this.btnBlogKaydet.Click += new System.EventHandler(this.BlogKaydet_Click);
            // 
            // btnBlogKapat
            // 
            this.btnBlogKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnBlogKapat.Image")));
            this.btnBlogKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBlogKapat.Name = "btnBlogKapat";
            this.btnBlogKapat.Size = new System.Drawing.Size(107, 24);
            this.btnBlogKapat.Text = "Blog Kapat";
            this.btnBlogKapat.Click += new System.EventHandler(this.BlogKapat_Click);
            // 
            // btnYeniBlog
            // 
            this.btnYeniBlog.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniBlog.Image")));
            this.btnYeniBlog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniBlog.Name = "btnYeniBlog";
            this.btnYeniBlog.Size = new System.Drawing.Size(166, 24);
            this.btnYeniBlog.Text = "Yeni Blog Sayfası Aç";
            this.btnYeniBlog.Click += new System.EventHandler(this.YeniBlog_Click);
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yeniBlogGirişiToolStripMenuItem,
            this.kayıtYeriToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 28);
            this.menuMain.TabIndex = 3;
            this.menuMain.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blokKaydetToolStripMenuItem,
            this.blokKapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // blokKaydetToolStripMenuItem
            // 
            this.blokKaydetToolStripMenuItem.Name = "blokKaydetToolStripMenuItem";
            this.blokKaydetToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.blokKaydetToolStripMenuItem.Text = "Blok Kaydet";
            this.blokKaydetToolStripMenuItem.Click += new System.EventHandler(this.BlogKaydet_Click);
            // 
            // blokKapatToolStripMenuItem
            // 
            this.blokKapatToolStripMenuItem.Name = "blokKapatToolStripMenuItem";
            this.blokKapatToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.blokKapatToolStripMenuItem.Text = "Blok Kapat";
            this.blokKapatToolStripMenuItem.Click += new System.EventHandler(this.BlogKapat_Click);
            // 
            // yeniBlogGirişiToolStripMenuItem
            // 
            this.yeniBlogGirişiToolStripMenuItem.Name = "yeniBlogGirişiToolStripMenuItem";
            this.yeniBlogGirişiToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.yeniBlogGirişiToolStripMenuItem.Text = "Yeni Blog Girişi";
            this.yeniBlogGirişiToolStripMenuItem.Click += new System.EventHandler(this.YeniBlog_Click);
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGuncelDosyaTarih,
            this.lblAktifBlogSayisi,
            this.lblSaat});
            this.statusMain.Location = new System.Drawing.Point(0, 424);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(800, 26);
            this.statusMain.TabIndex = 5;
            this.statusMain.Text = "statusStrip1";
            // 
            // lblGuncelDosyaTarih
            // 
            this.lblGuncelDosyaTarih.Name = "lblGuncelDosyaTarih";
            this.lblGuncelDosyaTarih.Size = new System.Drawing.Size(0, 20);
            // 
            // lblAktifBlogSayisi
            // 
            this.lblAktifBlogSayisi.Name = "lblAktifBlogSayisi";
            this.lblAktifBlogSayisi.Size = new System.Drawing.Size(0, 20);
            // 
            // lblSaat
            // 
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(63, 20);
            this.lblSaat.Text = "14:53:05";
            // 
            // tmrSaniye
            // 
            this.tmrSaniye.Interval = 1000;
            this.tmrSaniye.Tick += new System.EventHandler(this.tmrSaniye_Tick);
            // 
            // kayıtYeriToolStripMenuItem
            // 
            this.kayıtYeriToolStripMenuItem.Name = "kayıtYeriToolStripMenuItem";
            this.kayıtYeriToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.kayıtYeriToolStripMenuItem.Text = "Kayıt Yeri";
            this.kayıtYeriToolStripMenuItem.Click += new System.EventHandler(this.kayıtYeriToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.toolBarMenu);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolBarMenu.ResumeLayout(false);
            this.toolBarMenu.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBarMenu;
        private System.Windows.Forms.ToolStripButton btnBlogKaydet;
        private System.Windows.Forms.ToolStripButton btnBlogKapat;
        private System.Windows.Forms.ToolStripButton btnYeniBlog;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blokKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blokKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniBlogGirişiToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel lblGuncelDosyaTarih;
        private System.Windows.Forms.ToolStripStatusLabel lblAktifBlogSayisi;
        private System.Windows.Forms.ToolStripStatusLabel lblSaat;
        private System.Windows.Forms.Timer tmrSaniye;
        private System.Windows.Forms.ToolStripMenuItem kayıtYeriToolStripMenuItem;
    }
}

