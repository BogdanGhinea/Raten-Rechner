using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCredit
{
    public partial class frmCalculatorCredit : Form
    {
        public frmCalculatorCredit()
        {
            InitializeComponent();
        }

        //Accesare formular de la distanta
        frmDetaliiCredit frmDetaliiCredit;

        private void frmCalculatorCredit_Load(object sender, EventArgs e)
        {
            frmDetaliiCredit = new frmDetaliiCredit();
        }

        private void btnRataLunara_Click(object sender, EventArgs e)
        {
            frmDetaliiCredit.Show();
            frmDetaliiCredit.txtRataLunara.ReadOnly = true;
            frmDetaliiCredit.txtRataLunara.TabStop = false;
            frmDetaliiCredit.txtNumarPlati.ReadOnly = false;
            frmDetaliiCredit.txtNumarPlati.TabStop = true;
            frmDetaliiCredit.tlsEtichetaOptiuni.Text = "Rata Lunara";
            frmDetaliiCredit.txtRataLunara.Text = "";
            frmDetaliiCredit.txtSumaImprumutata.Text = "";
            frmDetaliiCredit.txtRataDobanda.Text = "";
            frmDetaliiCredit.txtNumarPlati.Text = "";
            frmDetaliiCredit.btnCalculeaza.Enabled = true;
            frmDetaliiCredit.lstAfisare.Items.Clear();
            frmDetaliiCredit.txtSumaImprumutata.Focus();
        }

        private void mnuOptiuniRataLunara_Click(object sender, EventArgs e)
        {
            frmDetaliiCredit.Show();
            frmDetaliiCredit.txtRataLunara.ReadOnly = true;
            frmDetaliiCredit.txtRataLunara.TabStop = false;
            frmDetaliiCredit.txtNumarPlati.ReadOnly = false;
            frmDetaliiCredit.txtNumarPlati.TabStop = true;
            frmDetaliiCredit.tlsEtichetaOptiuni.Text = "Rata Lunara";
            frmDetaliiCredit.txtRataLunara.Text = "";
            frmDetaliiCredit.txtSumaImprumutata.Text = "";
            frmDetaliiCredit.txtRataDobanda.Text = "";
            frmDetaliiCredit.txtNumarPlati.Text = "";
            frmDetaliiCredit.btnCalculeaza.Enabled = true;
            frmDetaliiCredit.lstAfisare.Items.Clear();
            frmDetaliiCredit.txtSumaImprumutata.Focus();
        }

        private void mnuOptiuniDurata_Click(object sender, EventArgs e)
        {
            frmDetaliiCredit.Show();
            frmDetaliiCredit.txtNumarPlati.ReadOnly = true;
            frmDetaliiCredit.txtNumarPlati.TabStop = false;
            frmDetaliiCredit.txtRataLunara.ReadOnly = false;
            frmDetaliiCredit.txtRataLunara.TabStop = true;            
            frmDetaliiCredit.tlsEtichetaOptiuni.Text = "Numar de Plati";
            frmDetaliiCredit.txtRataLunara.Text = "";
            frmDetaliiCredit.txtSumaImprumutata.Text = "";
            frmDetaliiCredit.txtRataDobanda.Text = "";
            frmDetaliiCredit.txtNumarPlati.Text = "";
            frmDetaliiCredit.btnCalculeaza.Enabled = true;
            frmDetaliiCredit.lstAfisare.Items.Clear();
            frmDetaliiCredit.txtSumaImprumutata.Focus();
        }

        private void btnDurata_Click(object sender, EventArgs e)
        {
            frmDetaliiCredit.Show();
            frmDetaliiCredit.txtNumarPlati.ReadOnly = true;
            frmDetaliiCredit.txtNumarPlati.TabStop = false;
            frmDetaliiCredit.txtRataLunara.ReadOnly = false;
            frmDetaliiCredit.txtRataLunara.TabStop = true;
            frmDetaliiCredit.tlsEtichetaOptiuni.Text = "Numar de Plati";
            frmDetaliiCredit.txtRataLunara.Text = "";
            frmDetaliiCredit.txtSumaImprumutata.Text = "";
            frmDetaliiCredit.txtRataDobanda.Text = "";
            frmDetaliiCredit.txtNumarPlati.Text = "";
            frmDetaliiCredit.btnCalculeaza.Enabled = true;
            frmDetaliiCredit.lstAfisare.Items.Clear();
            frmDetaliiCredit.txtSumaImprumutata.Focus();
        }

        private void mnuOptiuniExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
