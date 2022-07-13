namespace CalculatorCredit
{
    partial class frmCalculatorCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculatorCredit));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuOptiuni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniRataLunara = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniDurata = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRataLunara = new System.Windows.Forms.Button();
            this.btnDurata = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptiuni});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(421, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuOptiuni
            // 
            this.mnuOptiuni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptiuniRataLunara,
            this.mnuOptiuniDurata,
            this.mnuOptiuniExit});
            this.mnuOptiuni.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuOptiuni.Name = "mnuOptiuni";
            this.mnuOptiuni.Size = new System.Drawing.Size(70, 24);
            this.mnuOptiuni.Text = "&Optiuni";
            // 
            // mnuOptiuniRataLunara
            // 
            this.mnuOptiuniRataLunara.Name = "mnuOptiuniRataLunara";
            this.mnuOptiuniRataLunara.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuOptiuniRataLunara.Size = new System.Drawing.Size(204, 24);
            this.mnuOptiuniRataLunara.Text = "&Rata lunara";
            this.mnuOptiuniRataLunara.Click += new System.EventHandler(this.mnuOptiuniRataLunara_Click);
            // 
            // mnuOptiuniDurata
            // 
            this.mnuOptiuniDurata.Name = "mnuOptiuniDurata";
            this.mnuOptiuniDurata.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuOptiuniDurata.Size = new System.Drawing.Size(204, 24);
            this.mnuOptiuniDurata.Text = "&Durata";
            this.mnuOptiuniDurata.Click += new System.EventHandler(this.mnuOptiuniDurata_Click);
            // 
            // mnuOptiuniExit
            // 
            this.mnuOptiuniExit.Name = "mnuOptiuniExit";
            this.mnuOptiuniExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuOptiuniExit.Size = new System.Drawing.Size(204, 24);
            this.mnuOptiuniExit.Text = "&Exit";
            this.mnuOptiuniExit.Click += new System.EventHandler(this.mnuOptiuniExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRataLunara);
            this.panel1.Controls.Add(this.btnDurata);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 268);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selectati O Optiune";
            // 
            // btnRataLunara
            // 
            this.btnRataLunara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRataLunara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRataLunara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRataLunara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRataLunara.Location = new System.Drawing.Point(113, 68);
            this.btnRataLunara.Name = "btnRataLunara";
            this.btnRataLunara.Size = new System.Drawing.Size(243, 48);
            this.btnRataLunara.TabIndex = 2;
            this.btnRataLunara.Text = "Rata Lunara";
            this.btnRataLunara.UseVisualStyleBackColor = false;
            this.btnRataLunara.Click += new System.EventHandler(this.btnRataLunara_Click);
            // 
            // btnDurata
            // 
            this.btnDurata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDurata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDurata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDurata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDurata.Location = new System.Drawing.Point(113, 115);
            this.btnDurata.Name = "btnDurata";
            this.btnDurata.Size = new System.Drawing.Size(243, 49);
            this.btnDurata.TabIndex = 3;
            this.btnDurata.Text = "Durata";
            this.btnDurata.UseVisualStyleBackColor = false;
            this.btnDurata.Click += new System.EventHandler(this.btnDurata_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(116, 165);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 44);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCalculatorCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 298);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(437, 337);
            this.MinimumSize = new System.Drawing.Size(437, 337);
            this.Name = "frmCalculatorCredit";
            this.Text = "Calculator Credit";
            this.Load += new System.EventHandler(this.frmCalculatorCredit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuni;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniRataLunara;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniDurata;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRataLunara;
        private System.Windows.Forms.Button btnDurata;
        private System.Windows.Forms.Button btnExit;
    }
}

