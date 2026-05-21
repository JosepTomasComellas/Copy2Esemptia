namespace Copy2Esemptia
{
    partial class FormCarrega
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarrega));
            this.txtDades = new System.Windows.Forms.TextBox();
            this.pBotones = new System.Windows.Forms.Panel();
            this.bAccepta = new System.Windows.Forms.Button();
            this.bCancella = new System.Windows.Forms.Button();
            this.lblInstruccions = new System.Windows.Forms.Label();
            this.pBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDades
            // 
            this.txtDades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDades.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtDades.Location = new System.Drawing.Point(5, 35);
            this.txtDades.Multiline = true;
            this.txtDades.Name = "txtDades";
            this.txtDades.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDades.Size = new System.Drawing.Size(490, 260);
            this.txtDades.TabIndex = 0;
            this.txtDades.WordWrap = false;
            // 
            // pBotones
            // 
            this.pBotones.Controls.Add(this.bAccepta);
            this.pBotones.Controls.Add(this.bCancella);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBotones.Location = new System.Drawing.Point(5, 295);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(490, 50);
            this.pBotones.TabIndex = 1;
            // 
            // bAccepta
            // 
            this.bAccepta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAccepta.Location = new System.Drawing.Point(275, 10);
            this.bAccepta.Name = "bAccepta";
            this.bAccepta.Size = new System.Drawing.Size(100, 30);
            this.bAccepta.TabIndex = 0;
            this.bAccepta.Text = "Accepta";
            this.bAccepta.UseVisualStyleBackColor = true;
            this.bAccepta.Click += new System.EventHandler(this.bAccepta_Click);
            // 
            // bCancella
            // 
            this.bCancella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancella.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancella.Location = new System.Drawing.Point(385, 10);
            this.bCancella.Name = "bCancella";
            this.bCancella.Size = new System.Drawing.Size(100, 30);
            this.bCancella.TabIndex = 1;
            this.bCancella.Text = "Cancel·la";
            this.bCancella.UseVisualStyleBackColor = true;
            this.bCancella.Click += new System.EventHandler(this.bCancella_Click);
            // 
            // lblInstruccions
            // 
            this.lblInstruccions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInstruccions.Location = new System.Drawing.Point(5, 5);
            this.lblInstruccions.Name = "lblInstruccions";
            this.lblInstruccions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblInstruccions.Size = new System.Drawing.Size(490, 30);
            this.lblInstruccions.TabIndex = 2;
            this.lblInstruccions.Text = "Enganxa aquí les dades copiades de l\'Excel:";
            this.lblInstruccions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCarrega
            // 
            this.AcceptButton = this.bAccepta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancella;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.txtDades);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.lblInstruccions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCarrega";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Carrega des d\'Excel";
            this.pBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtDades;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Button bAccepta;
        private System.Windows.Forms.Button bCancella;
        private System.Windows.Forms.Label lblInstruccions;
    }
}
