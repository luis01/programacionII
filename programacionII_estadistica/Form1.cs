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
    public partial class Form1 : Form
    {
        estadsitica objEstadistica = new estadsitica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMediaAritmetica_Click(object sender, EventArgs e)
        {
            //split => divide una cadena en base a un delimitador (patron) y devuelve una matriz
            lblrespuesta.Text = "X="+ objEstadistica.media(txtserie.Text.Split(','));
        }

        private void btnCalcularEstandar_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = "Estandar=" + objEstadistica.estandar(txtserie.Text.Split(','));
        }

        private void btnCalcularTpica_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = "Tipica=" + objEstadistica.tipica(txtserie.Text.Split(','));
        }
    }
}
