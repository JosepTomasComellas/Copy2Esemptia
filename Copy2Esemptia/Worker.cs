using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Copy2Esemptia
{
    public class Worker
    {
        private readonly Form1 _formulari;
        private BackgroundWorker _backgroundWorker;

        public Worker(Form1 formulari)
        {
            _formulari = formulari;

            InitializeBackgoundWorker();
        }

        public void Start()
        {
            _backgroundWorker.RunWorkerAsync();
        }

        #region Worker
        private void InitializeBackgoundWorker()
        {
            try
            {
                _backgroundWorker = new BackgroundWorker();
                _backgroundWorker.WorkerReportsProgress = true;
                _backgroundWorker.WorkerSupportsCancellation = true;

                _backgroundWorker.DoWork += BackgroundWorker_DoWork;
                _backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
                _backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _backgroundWorker.ReportProgress(0, 0);

                var n = 5;
                _backgroundWorker.ReportProgress(n, 1);
                while (n > 0)
                {
                    Thread.Sleep(1000);
                    n--;
                    _backgroundWorker.ReportProgress(n, 1);
                }

                var columnes = _formulari.Columnes;
                var checks = _formulari.Checks;
                for (var i = 0; i < columnes.Count; i++)
                    Escriu(columnes[i], checks[i].Checked, i == columnes.Count - 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Escriu(TextBox txt, bool actiu, bool ultim)
        {
            if (!actiu)
                return;

            var lines = txt.Lines;
            if (_formulari.chkIngnora.Checked &&
                string.IsNullOrEmpty(lines.Last()))
            {
                lines = lines.Take(lines.Length - 1).ToArray();
            }

            _backgroundWorker.ReportProgress(txt.Lines.Length, 2);

            if (_formulari.chkEsborra.Checked)
            {
                for (var i = 0; i < lines.Length; i++)
                {
                    SendKeys.SendWait("{DEL}");
                    SendKeys.SendWait("{TAB}");
                }

                for (var i = 0; i < lines.Length; i++)
                {
                    SendKeys.SendWait("+{TAB}");
                }
            }

            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];

                SendKeys.SendWait(line.ToLower());
                Thread.Sleep(Properties.Settings.Default.Retard);

                if (!ultim || 
                    i < lines.Length - 1)
                    SendKeys.SendWait("{TAB}");

                _backgroundWorker.ReportProgress(0, 3);
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                _formulari.bEnganxar.Enabled = true;
                _formulari.bCarrega.Enabled = true;
                _formulari.chkIngnora.Show();
                _formulari.chkNeteja.Show();
                _formulari.chkEsborra.Show();

                _formulari.lContador.Hide();
                _formulari.barraProgres.Hide();

                if (_formulari.chkNeteja.Checked)
                    foreach (var col in _formulari.Columnes)
                        col.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (e.UserState.Equals(0))
                {
                    _formulari.bEnganxar.Enabled = false;
                    _formulari.bCarrega.Enabled = false;
                    _formulari.chkIngnora.Hide();
                    _formulari.chkNeteja.Hide();
                    _formulari.chkEsborra.Hide();
                }
                else if (e.UserState.Equals(1))
                {
                    if (e.ProgressPercentage <= 0)
                        _formulari.lContador.Hide();
                    else
                    {
                        _formulari.lContador.Show();
                        _formulari.lContador.Text = e.ProgressPercentage.ToString();
                    }
                }
                else if (e.UserState.Equals(2))
                {
                    _formulari.barraProgres.Maximum = e.ProgressPercentage;
                    _formulari.barraProgres.Value = 0;
                    _formulari.barraProgres.Step = 1;
                    _formulari.barraProgres.Show();
                }
                else if (e.UserState.Equals(3))
                {
                    _formulari.barraProgres.PerformStep();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
