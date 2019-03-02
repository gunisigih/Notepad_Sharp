using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NotepadSharp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int _formSayisi = 1;
        bool _degistimi;
        string _aranacakKelime;
        FrmAra _frmAra;


        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bicimlendirmeToolStripMenuItem.Enabled = true;
            harfIslemleriToolStripMenuItem.Enabled = true;
            //Notepad formunun instance' ını aldık.
            FrmNote frmNote = new FrmNote();

            //MDI Parent' ını bulunduğumuz class olarak atadık, yani FrmMainForm
            frmNote.MdiParent = this;

            //açılan note form' unun Text' inde, kaçıncı form olduğunu yazdırdık.
            frmNote.Text = string.Format("{0}.Not",_formSayisi);

            //açılan note form' undaki TextColor menusü tıklandığında yapılacak işlemleri bu Form içinde yazdık (event' ini burada yazdık).
            frmNote.textColorToolStripMenuItem.Click += new EventHandler(yaziRengiToolStripMenuItem_Click);

            //açılan note form' undaki TextFont menusü tıklandığında yapılacak işlemleri bu Form içinde yazdık (event' ini burada yazdık).
            frmNote.textFontToolStripMenuItem.Click += new EventHandler(yaziTipiToolStripMenuItem_Click);
            frmNote.FormClosing += new FormClosingEventHandler(frmNote_FormClosing);
            frmNote.richTextBox1.TextChanged += new EventHandler(richTextBox1_TextChanged);
            frmNote.KeyDown += new KeyEventHandler(frmNote_KeyDown);
            frmNote.Show();

            _formSayisi++;
        }

        void frmNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
                kaydetToolStripMenuItem.PerformClick();
        }

        void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            _degistimi = true;
        }

        void frmNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_degistimi)
            {
                DialogResult sonuc = MessageBox.Show(@"Kaydetmek istiyor musunuz?", @"Kaydet", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {
                    kaydetToolStripMenuItem.PerformClick();
                    MenuDisable();
                }
                else if (sonuc == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    _degistimi = false;
                    MenuDisable();
                }
            }
            else
            {
                MenuDisable();
            }
        }


        private void yaziRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color secilenRenk = colorDialog1.Color;
                FrmNote frmAktifNot = (FrmNote)this.ActiveMdiChild;

                if (frmAktifNot.richTextBox1.SelectedText.Length > 0)
                {
                    frmAktifNot.richTextBox1.SelectionColor = secilenRenk;
                }
                else
                {
                    frmAktifNot.richTextBox1.ForeColor = secilenRenk;
                }
            }
        }

        private void yaziTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font seciliFont = fontDialog1.Font;
                FrmNote frmAktifNot = (FrmNote)this.ActiveMdiChild;
                if (frmAktifNot.richTextBox1.SelectionLength > 0)
                {
                    frmAktifNot.richTextBox1.SelectionFont = seciliFont;
                }
                else
                {
                    frmAktifNot.richTextBox1.Font = seciliFont;
                }
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                MessageBox.Show(@"Kaydedilecek dosya yok!");
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _degistimi = false;
                    var dosyaAdi = saveFileDialog1.FileName;
                    FrmNote frmAktif = (FrmNote)this.ActiveMdiChild;
                    frmAktif.richTextBox1.SaveFile(dosyaAdi);
                }
            }
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = @"Zengin Dosyalar (*.rtf)|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _degistimi = false;
                var dosya = openFileDialog1.FileName;
                //StreamReader okuyucu = new StreamReader(dosya);
                //okuyucu.Close();

                FrmNote frmAcilacakNote = new FrmNote();
                frmAcilacakNote.MdiParent = this;
                frmAcilacakNote.richTextBox1.LoadFile(dosya);
                frmAcilacakNote.Show();
            }
        }

        private void hepsiBuyukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aktif formu bulduk ve içindeki richTextBox1' ın yazısını (RTF), yani renkli ve fontlu halini büyüttük.
            FrmNote frmAktif = (FrmNote)this.ActiveMdiChild;
            frmAktif.richTextBox1.Rtf = frmAktif.richTextBox1.Rtf.ToUpper();

        }

        private void hepsiKucukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aktif formu bulduk ve içindeki richTextBox1' ın yazısını (RTF), yani renkli ve fontlu halini küçülttük.
            FrmNote frmAktif = (FrmNote)this.ActiveMdiChild;
            frmAktif.richTextBox1.Rtf = frmAktif.richTextBox1.Rtf.ToLower();
        }

        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHakkinda frmHakkinda= new FrmHakkinda();
            frmHakkinda.ShowDialog();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                MessageBox.Show(@"Açık bir notepad yok");
                return;
            }

            FrmNote frmAktif = (FrmNote)this.ActiveMdiChild;
            if (frmAktif.richTextBox1.TextLength < 1)
            {
                MessageBox.Show(@"Notepad' da yazı yok");
                return;
            }

            _frmAra = new FrmAra();
            _frmAra.btnAra.Click += new EventHandler(btnAra_Click);
            _frmAra.FormClosing += new FormClosingEventHandler(frmAra_FormClosing);
            _frmAra.ShowDialog();
        }

        void btnAra_Click(object sender, EventArgs e)
        {
            Button aramaButonu = (sender as Button);
            Form aramaFormu = aramaButonu.Parent as Form;
            TextBox aramaTextBoxi = aramaFormu.Controls["txtArancakKelime"] as TextBox;
            if (aramaTextBoxi.Text.Length < 1)
                return;

            if ((((sender as Button).Parent as Form).Controls["txtArancakKelime"] as TextBox).Text.Length < 1)
                return;

            _aranacakKelime = _frmAra.txtArancakKelime.Text;
            _frmAra.Close();
        }

        void frmAra_FormClosing(object sender, FormClosingEventArgs e)
        {
            //arama formu kapanırken aktif formu aldık.
            FrmNote frmAktif = (FrmNote)this.ActiveMdiChild;

            //aktif formdaki richtextBox' ın içinde aranacakKelime' nin indeksini bulduk.
            int baslangicIndeksi = frmAktif.richTextBox1.Text.IndexOf(_aranacakKelime);

            //bulduğumuz indeksten, aranacakKelime' nin karakter sayısı kadar, richTextBox' ın textini seçtirdik.
            frmAktif.richTextBox1.Select(baslangicIndeksi, _aranacakKelime.Length);
        }

        void MenuDisable()
        {
            if (this.MdiChildren.Count() < 2)
            {
                bicimlendirmeToolStripMenuItem.Enabled = false;
                harfIslemleriToolStripMenuItem.Enabled = false;
            }
        }
    }
}
