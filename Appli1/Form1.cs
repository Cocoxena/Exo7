using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appli1
{
    public partial class frmAppli1 : Form
    {
        public frmAppli1()
        {
            InitializeComponent();
        }

        private void frmAppli1_Load(object sender, EventArgs e)
        {
            gbxParametres.Visible = false;
            rbtTemp50.Checked = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((rbtVitesse100.Checked || rbtVitesse200.Checked || rbtVitesse300.Checked || rbtVitesse500.Checked) && (rbtTemp50.Checked || rbtTemp80.Checked || rbtTemp100.Checked))
            {
                gbxParametres.Visible = true;
                gbxVitesse.Enabled = false;
                gbxTemperature.Enabled = false;
            }

            if (this.rbtVitesse100.Checked)
            {
                this.txtVitesse.Text = "100";
            }

            if (rbtVitesse200.Checked)
            {
                txtVitesse.Text = "200";
            }

            if (rbtVitesse300.Checked)
            {
                txtVitesse.Text = "300";
            }

            if (rbtVitesse500.Checked)
            {
                txtVitesse.Text = "500";
            }

            if (rbtTemp50.Checked)
            {
                txtTemperature.Text = "50";
            }

            if (rbtTemp80.Checked)
            {
                txtTemperature.Text = "80";
            }

            if (rbtTemp100.Checked)
            {
                txtTemperature.Text = "100";
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRetablir_Click(object sender, EventArgs e)
        {
            gbxParametres.Visible = false;
            gbxVitesse.Enabled = true;
            gbxTemperature.Enabled = true;
            rbtTemp50.Checked = true;
            rbtVitesse100.Checked = true;

        }

        private void txtVitesse_TextChanged(object sender, EventArgs e)
        {
            
        }
               
        private void txtTemperature_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
