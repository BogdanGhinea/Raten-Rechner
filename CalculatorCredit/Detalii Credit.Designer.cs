namespace CalculatorCredit
{
    partial class frmDetaliiCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaliiCredit));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuOptiuniCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniCreditRataLunara = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniCreditDurata = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniCreditExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNouaCalculatie = new System.Windows.Forms.Button();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.txtRataLunara = new System.Windows.Forms.TextBox();
            this.txtRataDobanda = new System.Windows.Forms.TextBox();
            this.txtNumarPlati = new System.Windows.Forms.TextBox();
            this.txtSumaImprumutata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlsEtichetaOptiuni = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptiuniCredit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuOptiuniCredit
            // 
            this.mnuOptiuniCredit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptiuniCreditRataLunara,
            this.mnuOptiuniCreditDurata,
            this.mnuOptiuniCreditExit});
            this.mnuOptiuniCredit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuOptiuniCredit.Name = "mnuOptiuniCredit";
            this.mnuOptiuniCredit.Size = new System.Drawing.Size(70, 24);
            this.mnuOptiuniCredit.Text = "&Optiuni";
            // 
            // mnuOptiuniCreditRataLunara
            // 
            this.mnuOptiuniCreditRataLunara.Name = "mnuOptiuniCreditRataLunara";
            this.mnuOptiuniCreditRataLunara.Size = new System.Drawing.Size(180, 24);
            this.mnuOptiuniCreditRataLunara.Text = "&Rata Lunara";
            this.mnuOptiuniCreditRataLunara.Click += new System.EventHandler(this.mnuOptiuniCreditRataLunara_Click);
            // 
            // mnuOptiuniCreditDurata
            // 
            this.mnuOptiuniCreditDurata.Name = "mnuOptiuniCreditDurata";
            this.mnuOptiuniCreditDurata.Size = new System.Drawing.Size(180, 24);
            this.mnuOptiuniCreditDurata.Text = "&Durata";
            this.mnuOptiuniCreditDurata.Click += new System.EventHandler(this.mnuOptiuniCreditDurata_Click);
            // 
            // mnuOptiuniCreditExit
            // 
            this.mnuOptiuniCreditExit.Name = "mnuOptiuniCreditExit";
            this.mnuOptiuniCreditExit.Size = new System.Drawing.Size(180, 24);
            this.mnuOptiuniCreditExit.Text = "&Exit";
            this.mnuOptiuniCreditExit.Click += new System.EventHandler(this.mnuOptiuniCreditExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 287);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit1);
            this.groupBox2.Controls.Add(this.lstAfisare);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(337, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 265);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amortizare";
            // 
            // btnExit1
            // 
            this.btnExit1.Location = new System.Drawing.Point(6, 207);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(235, 38);
            this.btnExit1.TabIndex = 11;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 18;
            this.lstAfisare.Location = new System.Drawing.Point(6, 35);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(235, 166);
            this.lstAfisare.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnNouaCalculatie);
            this.groupBox1.Controls.Add(this.btnCalculeaza);
            this.groupBox1.Controls.Add(this.txtRataLunara);
            this.groupBox1.Controls.Add(this.txtRataDobanda);
            this.groupBox1.Controls.Add(this.txtNumarPlati);
            this.groupBox1.Controls.Add(this.txtSumaImprumutata);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "lunara";
            // 
            // btnNouaCalculatie
            // 
            this.btnNouaCalculatie.Location = new System.Drawing.Point(89, 218);
            this.btnNouaCalculatie.Name = "btnNouaCalculatie";
            this.btnNouaCalculatie.Size = new System.Drawing.Size(192, 31);
            this.btnNouaCalculatie.TabIndex = 5;
            this.btnNouaCalculatie.Text = "Noua Calculatie";
            this.btnNouaCalculatie.UseVisualStyleBackColor = true;
            this.btnNouaCalculatie.Click += new System.EventHandler(this.btnNouaCalculatie_Click);
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Location = new System.Drawing.Point(89, 180);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(192, 32);
            this.btnCalculeaza.TabIndex = 4;
            this.btnCalculeaza.Text = "Calculeaza";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // txtRataLunara
            // 
            this.txtRataLunara.Location = new System.Drawing.Point(151, 131);
            this.txtRataLunara.Name = "txtRataLunara";
            this.txtRataLunara.Size = new System.Drawing.Size(130, 24);
            this.txtRataLunara.TabIndex = 3;
            this.txtRataLunara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRataDobanda
            // 
            this.txtRataDobanda.Location = new System.Drawing.Point(151, 101);
            this.txtRataDobanda.Name = "txtRataDobanda";
            this.txtRataDobanda.Size = new System.Drawing.Size(130, 24);
            this.txtRataDobanda.TabIndex = 2;
            this.txtRataDobanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumarPlati
            // 
            this.txtNumarPlati.Location = new System.Drawing.Point(151, 68);
            this.txtNumarPlati.Name = "txtNumarPlati";
            this.txtNumarPlati.Size = new System.Drawing.Size(93, 24);
            this.txtNumarPlati.TabIndex = 1;
            this.txtNumarPlati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumaImprumutata
            // 
            this.txtSumaImprumutata.Location = new System.Drawing.Point(151, 35);
            this.txtSumaImprumutata.Name = "txtSumaImprumutata";
            this.txtSumaImprumutata.Size = new System.Drawing.Size(130, 24);
            this.txtSumaImprumutata.TabIndex = 0;
            this.txtSumaImprumutata.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rata Lunara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rata de Dobanda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Durata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suma Imprumutata";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsEtichetaOptiuni});
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(601, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlsEtichetaOptiuni
            // 
            this.tlsEtichetaOptiuni.BackColor = System.Drawing.Color.White;
            this.tlsEtichetaOptiuni.Name = "tlsEtichetaOptiuni";
            this.tlsEtichetaOptiuni.Size = new System.Drawing.Size(47, 17);
            this.tlsEtichetaOptiuni.Text = "Optiuni";
            // 
            // frmDetaliiCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 315);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(617, 354);
            this.MinimumSize = new System.Drawing.Size(617, 354);
            this.Name = "frmDetaliiCredit";
            this.Text = "Detalii Credit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetaliiCredit_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniCredit;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniCreditRataLunara;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniCreditDurata;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniCreditExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ListBox lstAfisare;
        internal System.Windows.Forms.TextBox txtRataLunara;
        internal System.Windows.Forms.TextBox txtRataDobanda;
        internal System.Windows.Forms.TextBox txtNumarPlati;
        internal System.Windows.Forms.TextBox txtSumaImprumutata;
        internal System.Windows.Forms.ToolStripStatusLabel tlsEtichetaOptiuni;
        internal System.Windows.Forms.Button btnNouaCalculatie;
        internal System.Windows.Forms.Button btnCalculeaza;
    }
}