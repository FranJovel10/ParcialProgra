using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int de, a;
            double cantidad, respuesta;
            de = cboDe.SelectedIndex;
            a = cboA.SelectedIndex;
            cantidad = double.Parse(txtCantidad.Text);
            double[] medida = { 0.09290304, 0.698896, 0.836127, 1, 438, 7000, 10000 };
            respuesta = medida[de] / medida[a] * cantidad;
            lblResp.Text = "=" + Math.Round(respuesta, 3);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
