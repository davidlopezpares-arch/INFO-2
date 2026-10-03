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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                distancia = Convert.ToDouble(textBox1.Text);
                tiempo = Convert.ToInt32(textBox2.Text);
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
    }
}
