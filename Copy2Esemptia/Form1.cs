using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Copy2Esemptia
{
    public partial class Form1 : Form
    {
        private const int AmpladeColumna = 40;
        private const int AmpladePanel = 260;

        public List<TextBox> Columnes { get; } = new List<TextBox>();
        public List<CheckBox> Checks { get; } = new List<CheckBox>();

        public Form1()
        {
            InitializeComponent();
            nudColumnes.Maximum = Properties.Settings.Default.MaxColumnes;
            AjustarColumnes(0);
        }

        private void AjustarColumnes(int nouNombre)
        {
            taula.SuspendLayout();
            SuspendLayout();

            // Desa el contingut existent
            var textos = Columnes.Select(t => t.Text).ToList();
            var estats = Checks.Select(c => c.Checked).ToList();

            // Elimina controls existents
            var colsCopia = new List<TextBox>(Columnes);
            var checksCopia = new List<CheckBox>(Checks);
            Columnes.Clear();
            Checks.Clear();

            foreach (var txt in colsCopia) { taula.Controls.Remove(txt); txt.Dispose(); }
            foreach (var chk in checksCopia) { taula.Controls.Remove(chk); chk.Dispose(); }

            // Reconstrueix els estils de columna
            taula.ColumnCount = nouNombre + 1;
            while (taula.ColumnStyles.Count > 0)
                taula.ColumnStyles.RemoveAt(0);
            taula.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            for (var i = 0; i < nouNombre; i++)
                taula.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, AmpladeColumna));

            // panel1 sempre a la primera columna (esquerra)
            taula.SetColumn(panel1, 0);

            // Crea els nous controls
            for (var i = 0; i < nouNombre; i++)
            {
                var estaActiu = i < estats.Count ? estats[i] : (i == 0);

                var txt = new TextBox
                {
                    Dock = DockStyle.Fill,
                    Multiline = true,
                    TextAlign = HorizontalAlignment.Center,
                    Margin = new Padding(2),
                    Enabled = estaActiu,
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(33, 33, 33),
                    BorderStyle = BorderStyle.FixedSingle,
                };
                if (i == 0)
                    txt.TextChanged += TxtText_TextChanged;

                var chk = new CheckBox
                {
                    CheckAlign = ContentAlignment.MiddleCenter,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Checked = estaActiu,
                    UseVisualStyleBackColor = true,
                    BackColor = Color.White,
                    Margin = new Padding(2),
                    Tag = i,
                };
                chk.CheckedChanged += Chk_CheckedChanged;

                taula.Controls.Add(txt, i + 1, 0);
                taula.Controls.Add(chk, i + 1, 1);

                Columnes.Add(txt);
                Checks.Add(chk);
            }

            // Restaura el contingut desat
            for (var i = 0; i < Math.Min(nouNombre, textos.Count); i++)
                Columnes[i].Text = textos[i];

            // Ajusta l'amplada de la finestra
            ClientSize = new Size(Padding.Left + Padding.Right + nouNombre * AmpladeColumna + AmpladePanel, ClientSize.Height);

            taula.ResumeLayout();
            ResumeLayout();
            ActualitzarBoto();
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            var idx = (int)chk.Tag;
            Columnes[idx].Enabled = chk.Checked;
            if (!chk.Checked)
                Columnes[idx].Clear();
            ActualitzarBoto();
        }

        private void TxtText_TextChanged(object sender, EventArgs e)
        {
            ActualitzarBoto();
        }

        private void ActualitzarBoto()
        {
            bEnganxar.Enabled = Columnes.Count > 0 &&
                                 Checks[0].Checked &&
                                 !string.IsNullOrEmpty(Columnes[0].Text);
        }

        private void NudColumnes_ValueChanged(object sender, EventArgs e)
        {
            AjustarColumnes((int)nudColumnes.Value);
        }

        private void BCarrega_Click(object sender, EventArgs e)
        {
            using (var dlg = new FormCarrega())
            {
                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;
                CarregaDesDeExcel(dlg.TextEnganxat);
            }
        }

        private void CarregaDesDeExcel(string text)
        {
            text = text.Replace("\r\n", "\n").Replace("\r", "\n").TrimEnd('\n');
            if (string.IsNullOrEmpty(text))
                return;

            var files = text.Split('\n');
            var maxColumnes = files.Max(f => f.Split('\t').Length);
            var nombreColumnes = Math.Min(maxColumnes, (int)nudColumnes.Maximum);

            if ((int)nudColumnes.Value != nombreColumnes)
                nudColumnes.Value = nombreColumnes;
            else if (Columnes.Count == 0)
                AjustarColumnes(nombreColumnes);

            for (var col = 0; col < nombreColumnes; col++)
            {
                if (!Checks[col].Checked)
                    Checks[col].Checked = true;

                var sb = new StringBuilder();
                for (var fila = 0; fila < files.Length; fila++)
                {
                    if (fila > 0) sb.Append("\r\n");
                    var parts = files[fila].Split('\t');
                    sb.Append(col < parts.Length ? parts[col] : string.Empty);
                }
                Columnes[col].Text = sb.ToString();
            }
        }

        private void BEnganxar_Click(object sender, EventArgs e)
        {
            var nl = Environment.NewLine;
            if (MessageBox.Show(
                $@"Per iniciar el procés, prem 'Si' i canvia de finestra, situa't en la primera cel·la de Esemptia.{nl}{nl}Vols continuar?{nl}{nl}{nl}Tens 5 segons per situar-te.{nl}",
                @"Enganxar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Hand) != DialogResult.Yes)
                return;

            var worker = new Worker(this);
            worker.Start();
        }
    }
}
