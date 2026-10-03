using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dist_Seguridad_Formulario
{
    public partial class Dist_Ciclo_form : Form
    {
        public Dist_Ciclo_form()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
                double distancia = Convert.ToDouble(textBox1.Text);
                double tiempo = Convert.ToDouble(textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error al introducir los valores");
            }
        }
    }
}
