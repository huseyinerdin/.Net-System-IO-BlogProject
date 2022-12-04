using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogOrnek
{
    public partial class frmBlog : Form
    {

        public static int AktifBlogSayısı = 0;
        string _dizin;

        public frmBlog(string dizin)
        {
            InitializeComponent();
            _dizin = dizin;
        }

        static public frmBlog Yeni(frmMain Main,string dizin)
        {
            frmBlog.AktifBlogSayısı++;

            return new frmBlog(dizin)
            {
                MdiParent = Main
            }; 
        }

        public void Kapat()
        {
           
            Close();
        }

        public void Kaydet()
        {
            string dosyaAdi = this.Text + ".txt";           

            FileStream fs = File.Create(_dizin +"\\"+ dosyaAdi);

            StreamWriter sr = new StreamWriter(fs);

            sr.WriteLine(textBox1.Text);

            sr.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dateTimePicker1.Text;

            frmMain main = (frmMain)this.MdiParent;

            main.AktifFormAta(this.Text);

            Oku();
        }

        private void frmBlog_Load(object sender, EventArgs e)
        {
            this.Text = dateTimePicker1.Text;

            frmMain main = (frmMain)this.MdiParent;

            main.AktifFormAta(this.Text);

            Oku();
        }

        private void frmBlog_Activated(object sender, EventArgs e)
        {
            frmMain main = (frmMain)this.MdiParent;

            main.AktifFormAta(this.Text);

            tmrKapat.Enabled = true;        
        }

        private void frmBlog_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBlog.AktifBlogSayısı--;

            frmMain main = (frmMain)this.MdiParent;

            main.BlogSayi(frmBlog.AktifBlogSayısı);
        }

        private void tmrKapat_Tick(object sender, EventArgs e)
        {
            tmrKapat.Enabled = false;

            Kapat();
        }

        private void frmBlog_Deactivate(object sender, EventArgs e)
        {
            tmrKapat.Stop();
        }

        private void Oku()
        {
            textBox1.Clear();

            string dosyaAdi = this.Text + ".txt";

            if (File.Exists(_dizin+ "\\" + dosyaAdi))
            {
                var sr = new StreamReader(_dizin + "\\" + dosyaAdi);

                textBox1.Text = sr.ReadToEnd();

                sr.Close();
            }           
        }
    }
}
