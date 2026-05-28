namespace Copy2Esemptia
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.bEnganxar = new System.Windows.Forms.Button();
            this.bCarrega = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkNeteja = new System.Windows.Forms.CheckBox();
            this.chkIngnora = new System.Windows.Forms.CheckBox();
            this.chkEsborra = new System.Windows.Forms.CheckBox();
            this.lContador = new System.Windows.Forms.Label();
            this.barraProgres = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pColumnes = new System.Windows.Forms.Panel();
            this.lblColumnes = new System.Windows.Forms.Label();
            this.nudColumnes = new System.Windows.Forms.NumericUpDown();
            this.taula = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.pColumnes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnes)).BeginInit();
            this.taula.SuspendLayout();
            this.SuspendLayout();
            // 
            // bEnganxar
            // 
            this.bEnganxar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bEnganxar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bEnganxar.Enabled = false;
            this.bEnganxar.FlatAppearance.BorderSize = 0;
            this.bEnganxar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnganxar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.bEnganxar.ForeColor = System.Drawing.Color.White;
            this.bEnganxar.Location = new System.Drawing.Point(0, 290);
            this.bEnganxar.Margin = new System.Windows.Forms.Padding(0);
            this.bEnganxar.Name = "bEnganxar";
            this.bEnganxar.Size = new System.Drawing.Size(341, 49);
            this.bEnganxar.TabIndex = 2;
            this.bEnganxar.TabStop = false;
            this.bEnganxar.Text = "Enganxar";
            this.bEnganxar.UseVisualStyleBackColor = false;
            this.bEnganxar.Click += new System.EventHandler(this.BEnganxar_Click);
            // 
            // bCarrega
            // 
            this.bCarrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.bCarrega.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCarrega.FlatAppearance.BorderSize = 0;
            this.bCarrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCarrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.bCarrega.Location = new System.Drawing.Point(0, 151);
            this.bCarrega.Margin = new System.Windows.Forms.Padding(0);
            this.bCarrega.Name = "bCarrega";
            this.bCarrega.Size = new System.Drawing.Size(341, 30);
            this.bCarrega.TabIndex = 3;
            this.bCarrega.TabStop = false;
            this.bCarrega.Text = "Carrega des d\'Excel...";
            this.bCarrega.UseVisualStyleBackColor = false;
            this.bCarrega.Click += new System.EventHandler(this.BCarrega_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bCarrega);
            this.panel1.Controls.Add(this.chkNeteja);
            this.panel1.Controls.Add(this.chkIngnora);
            this.panel1.Controls.Add(this.chkEsborra);
            this.panel1.Controls.Add(this.lContador);
            this.panel1.Controls.Add(this.barraProgres);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bEnganxar);
            this.panel1.Controls.Add(this.pColumnes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.taula.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(351, 339);
            this.panel1.TabIndex = 0;
            // 
            // chkNeteja
            // 
            this.chkNeteja.AutoSize = true;
            this.chkNeteja.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkNeteja.Checked = true;
            this.chkNeteja.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNeteja.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkNeteja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkNeteja.Location = new System.Drawing.Point(0, 181);
            this.chkNeteja.Margin = new System.Windows.Forms.Padding(0);
            this.chkNeteja.Name = "chkNeteja";
            this.chkNeteja.Padding = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.chkNeteja.Size = new System.Drawing.Size(341, 29);
            this.chkNeteja.TabIndex = 0;
            this.chkNeteja.TabStop = false;
            this.chkNeteja.Text = "Neteja en finalitzar";
            this.chkNeteja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkNeteja.UseVisualStyleBackColor = true;
            // 
            // chkIngnora
            // 
            this.chkIngnora.AutoSize = true;
            this.chkIngnora.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIngnora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkIngnora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkIngnora.Location = new System.Drawing.Point(0, 210);
            this.chkIngnora.Margin = new System.Windows.Forms.Padding(0);
            this.chkIngnora.Name = "chkIngnora";
            this.chkIngnora.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.chkIngnora.Size = new System.Drawing.Size(341, 23);
            this.chkIngnora.TabIndex = 1;
            this.chkIngnora.TabStop = false;
            this.chkIngnora.Text = "Ignora darrer intro";
            this.chkIngnora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIngnora.UseVisualStyleBackColor = true;
            // 
            // chkEsborra
            // 
            this.chkEsborra.AutoSize = true;
            this.chkEsborra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEsborra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkEsborra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.chkEsborra.Location = new System.Drawing.Point(0, 233);
            this.chkEsborra.Margin = new System.Windows.Forms.Padding(0);
            this.chkEsborra.Name = "chkEsborra";
            this.chkEsborra.Padding = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.chkEsborra.Size = new System.Drawing.Size(341, 29);
            this.chkEsborra.TabIndex = 6;
            this.chkEsborra.TabStop = false;
            this.chkEsborra.Text = "Esborra el text existent";
            this.chkEsborra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEsborra.UseVisualStyleBackColor = true;
            // 
            // lContador
            // 
            this.lContador.BackColor = System.Drawing.Color.Transparent;
            this.lContador.Dock = System.Windows.Forms.DockStyle.Top;
            this.lContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lContador.Location = new System.Drawing.Point(0, 20);
            this.lContador.Margin = new System.Windows.Forms.Padding(0);
            this.lContador.Name = "lContador";
            this.lContador.Size = new System.Drawing.Size(341, 73);
            this.lContador.TabIndex = 4;
            this.lContador.Text = "0";
            this.lContador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lContador.Visible = false;
            // 
            // barraProgres
            // 
            this.barraProgres.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraProgres.Location = new System.Drawing.Point(0, 262);
            this.barraProgres.Margin = new System.Windows.Forms.Padding(0);
            this.barraProgres.Name = "barraProgres";
            this.barraProgres.Size = new System.Drawing.Size(341, 18);
            this.barraProgres.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barraProgres.TabIndex = 2;
            this.barraProgres.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 280);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 10);
            this.panel2.TabIndex = 3;
            // 
            // pColumnes
            // 
            this.pColumnes.Controls.Add(this.lblColumnes);
            this.pColumnes.Controls.Add(this.nudColumnes);
            this.pColumnes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pColumnes.Location = new System.Drawing.Point(0, 0);
            this.pColumnes.Margin = new System.Windows.Forms.Padding(2);
            this.pColumnes.Name = "pColumnes";
            this.pColumnes.Size = new System.Drawing.Size(341, 20);
            this.pColumnes.TabIndex = 5;
            // 
            // lblColumnes
            // 
            this.lblColumnes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColumnes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblColumnes.Location = new System.Drawing.Point(0, 0);
            this.lblColumnes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColumnes.Name = "lblColumnes";
            this.lblColumnes.Size = new System.Drawing.Size(306, 20);
            this.lblColumnes.TabIndex = 1;
            this.lblColumnes.Text = "Columnes:";
            this.lblColumnes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudColumnes
            // 
            this.nudColumnes.AutoSize = true;
            this.nudColumnes.BackColor = System.Drawing.Color.White;
            this.nudColumnes.Dock = System.Windows.Forms.DockStyle.Right;
            this.nudColumnes.Location = new System.Drawing.Point(306, 0);
            this.nudColumnes.Margin = new System.Windows.Forms.Padding(2);
            this.nudColumnes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudColumnes.Name = "nudColumnes";
            this.nudColumnes.Size = new System.Drawing.Size(35, 23);
            this.nudColumnes.TabIndex = 0;
            this.nudColumnes.ValueChanged += new System.EventHandler(this.NudColumnes_ValueChanged);
            // 
            // taula
            // 
            this.taula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.taula.ColumnCount = 1;
            this.taula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.taula.Controls.Add(this.panel1, 0, 0);
            this.taula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taula.Location = new System.Drawing.Point(10, 10);
            this.taula.Name = "taula";
            this.taula.RowCount = 2;
            this.taula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.taula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.taula.Size = new System.Drawing.Size(351, 339);
            this.taula.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(371, 359);
            this.Controls.Add(this.taula);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Enganxa a Esemptia";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pColumnes.ResumeLayout(false);
            this.pColumnes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnes)).EndInit();
            this.taula.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button bEnganxar;
        public System.Windows.Forms.Button bCarrega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ProgressBar barraProgres;
        public System.Windows.Forms.Label lContador;
        public System.Windows.Forms.CheckBox chkIngnora;
        public System.Windows.Forms.CheckBox chkNeteja;
        private System.Windows.Forms.TableLayoutPanel taula;
        public System.Windows.Forms.NumericUpDown nudColumnes;
        private System.Windows.Forms.Label lblColumnes;
        private System.Windows.Forms.Panel pColumnes;
        public System.Windows.Forms.CheckBox chkEsborra;
    }
}
