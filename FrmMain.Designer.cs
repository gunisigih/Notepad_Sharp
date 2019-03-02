namespace NotepadSharp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicimlendirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harfIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hepsiBuyukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hepsiKucukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnYeniForm = new System.Windows.Forms.ToolStripButton();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnAc = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.bicimlendirmeToolStripMenuItem,
            this.harfIslemleriToolStripMenuItem,
            this.araToolStripMenuItem,
            this.hakkindaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.acToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.acToolStripMenuItem.Text = "Ac";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // bicimlendirmeToolStripMenuItem
            // 
            this.bicimlendirmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaziRengiToolStripMenuItem,
            this.yaziTipiToolStripMenuItem});
            this.bicimlendirmeToolStripMenuItem.Enabled = false;
            this.bicimlendirmeToolStripMenuItem.Name = "bicimlendirmeToolStripMenuItem";
            this.bicimlendirmeToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.bicimlendirmeToolStripMenuItem.Text = "Bicimlendirme";
            // 
            // yaziRengiToolStripMenuItem
            // 
            this.yaziRengiToolStripMenuItem.Name = "yaziRengiToolStripMenuItem";
            this.yaziRengiToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.yaziRengiToolStripMenuItem.Text = "Yazi Rengi";
            this.yaziRengiToolStripMenuItem.Click += new System.EventHandler(this.yaziRengiToolStripMenuItem_Click);
            // 
            // yaziTipiToolStripMenuItem
            // 
            this.yaziTipiToolStripMenuItem.Name = "yaziTipiToolStripMenuItem";
            this.yaziTipiToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.yaziTipiToolStripMenuItem.Text = "Yazi Tipi";
            this.yaziTipiToolStripMenuItem.Click += new System.EventHandler(this.yaziTipiToolStripMenuItem_Click);
            // 
            // harfIslemleriToolStripMenuItem
            // 
            this.harfIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hepsiBuyukToolStripMenuItem,
            this.hepsiKucukToolStripMenuItem});
            this.harfIslemleriToolStripMenuItem.Enabled = false;
            this.harfIslemleriToolStripMenuItem.Name = "harfIslemleriToolStripMenuItem";
            this.harfIslemleriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.harfIslemleriToolStripMenuItem.Text = "Harf Islemleri";
            // 
            // hepsiBuyukToolStripMenuItem
            // 
            this.hepsiBuyukToolStripMenuItem.Name = "hepsiBuyukToolStripMenuItem";
            this.hepsiBuyukToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.hepsiBuyukToolStripMenuItem.Text = "Hepsi Buyuk";
            this.hepsiBuyukToolStripMenuItem.Click += new System.EventHandler(this.hepsiBuyukToolStripMenuItem_Click);
            // 
            // hepsiKucukToolStripMenuItem
            // 
            this.hepsiKucukToolStripMenuItem.Name = "hepsiKucukToolStripMenuItem";
            this.hepsiKucukToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.hepsiKucukToolStripMenuItem.Text = "Hepsi Kucuk";
            this.hepsiKucukToolStripMenuItem.Click += new System.EventHandler(this.hepsiKucukToolStripMenuItem_Click);
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.araToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.araToolStripMenuItem.Text = "Ara";
            this.araToolStripMenuItem.Click += new System.EventHandler(this.araToolStripMenuItem_Click);
            // 
            // hakkindaToolStripMenuItem
            // 
            this.hakkindaToolStripMenuItem.Name = "hakkindaToolStripMenuItem";
            this.hakkindaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkindaToolStripMenuItem.Text = "Hakkinda";
            this.hakkindaToolStripMenuItem.Click += new System.EventHandler(this.hakkindaToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Zengin Dosyalar (*.rtf)|*.rtf";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeniForm,
            this.btnKaydet,
            this.btnAc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(546, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnYeniForm
            // 
            this.btnYeniForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeniForm.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniForm.Image")));
            this.btnYeniForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniForm.Name = "btnYeniForm";
            this.btnYeniForm.Size = new System.Drawing.Size(23, 22);
            this.btnYeniForm.Text = "Yeni Form";
            this.btnYeniForm.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(23, 22);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // btnAc
            // 
            this.btnAc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAc.Image = ((System.Drawing.Image)(resources.GetObject("btnAc.Image")));
            this.btnAc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(23, 22);
            this.btnAc.Text = "toolStripButton1";
            this.btnAc.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 303);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Super Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem bicimlendirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziTipiToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem harfIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hepsiBuyukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hepsiKucukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeniForm;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripButton btnAc;
    }
}

