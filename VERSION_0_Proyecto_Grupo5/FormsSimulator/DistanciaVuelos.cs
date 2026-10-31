using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsSimulator
{
    public partial class DistanciaVuelos : Form
    {
        public DistanciaVuelos()
        {
            InitializeComponent();
        }
        double distancia;
        public void SetDistancia(double distancia)
        {
            this.distancia = distancia;
        }

        private void DistanciaVuelos_Load(object sender, EventArgs e)
        {
            Distancia.Text = "Distancia: " + distancia.ToString();
        }

        private void VolverAtrasBoton_DistanciaVuelos_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
