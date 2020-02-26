using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionII_estadistica
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmEstadistica = new Form1();
            frmEstadistica.MdiParent = this;
            frmEstadistica.Show();
        }
        private void conversoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversores frmConversores = new conversores();
            frmConversores.MdiParent = this;
            frmConversores.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 frmEstadistica = new Form1();
            frmEstadistica.MdiParent = this;
            frmEstadistica.Show();

            lblFormularioActivo.Text = frmEstadistica.Text;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            conversores frmConversores = new conversores();
            frmConversores.MdiParent = this;
            frmConversores.Show();

            lblFormularioActivo.Text = frmConversores.Text;
        }

        private void principal_Load(object sender, EventArgs e)
        {
            lblstatusfecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
