using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogOrnek
{
    public partial class frmMain : Form
    {
        string _dizin;
        public frmMain()
        {
            InitializeComponent();
        }
        private void YeniBlog_Click(object sender, EventArgs e)
        {
            if (_dizin == "" || _dizin == null)
            {
                kayıtYeriToolStripMenuItem_Click(kayıtYeriToolStripMenuItem, new EventArgs());
                if (_dizin == "")
                {
                    MessageBox.Show("Lütfen bir dizin seçiniz");
                    return;
                }
            }

            (frmBlog.Yeni(this, _dizin)).Show();

            BlogSayi(frmBlog.AktifBlogSayısı);
        }
        private void BlogKapat_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                MessageBox.Show("Aktif bir blog sayfası bulunmamaktaadır.");
                return;
            }
            frmBlog frm = (frmBlog)this.ActiveMdiChild;
            frm.Kapat();

        }
        private void BlogKaydet_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                MessageBox.Show("Aktif bir blog sayfası bulunmamaktaadır.");
                return;
            }
            if (_dizin == "" || _dizin == null)
            {
                kayıtYeriToolStripMenuItem_Click(kayıtYeriToolStripMenuItem, new EventArgs());
                if (_dizin == "")
                {
                    MessageBox.Show("Lütfen bir dizin seçiniz");
                    return;
                }
            }
            frmBlog frm = (frmBlog)this.ActiveMdiChild;
            frm.Kaydet();
        }

        public void AktifFormAta(string FormAdı)
        {
            this.lblGuncelDosyaTarih.Text = FormAdı;
        }

        public void BlogSayi(int BlogSayi)
        {
            lblAktifBlogSayisi.Text = "Aktif Blog Sayısı : " + BlogSayi;
        }

        private void tmrSaniye_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tmrSaniye.Enabled = true;
        }

        private void kayıtYeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldr = new FolderBrowserDialog();
            fldr.ShowDialog();
            _dizin = fldr.SelectedPath;

        }
    }
}
