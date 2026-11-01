using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsSimulator
{
    public partial class DistanciaSeguridad : Form
    {
        public DistanciaSeguridad()
        {
            InitializeComponent();
        }
        double distancia;
        int tiempo;

        bool enviado = false;

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                distancia = Convert.ToDouble(DistanciaS.Text);
                tiempo = Convert.ToInt32(TiempoC.Text);
                enviado = true;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error al introducir los valores");
            }
        }
        public double GetDistancia()
        {
            return distancia;
        }
        public int GetCiclo()
        {
            return tiempo;
        }
        public bool GetEnviado()
        {
            return enviado;
        }

        private void AutorellenarDistBoton_Click(object sender, EventArgs e)
        {
            DistanciaS.Text = "10";
            TiempoC.Text = "10";
        }
    }
}
