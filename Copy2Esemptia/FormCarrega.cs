using System;
using System.Windows.Forms;

namespace Copy2Esemptia
{
    public partial class FormCarrega : Form
    {
        public string TextEnganxat => txtDades.Text;

        public FormCarrega()
        {
            InitializeComponent();
            ActiveControl = txtDades;
        }

        private void bAccepta_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancella_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
