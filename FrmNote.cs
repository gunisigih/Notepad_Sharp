using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadSharp
{
    public partial class FrmNote : Form
    {
        public FrmNote()
        {
            InitializeComponent();
        }


        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bu metot mainForm' da yazıldı.
        }
    }
}
