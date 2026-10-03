using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace NuevoFormulario
{
    public partial class NuevoFormulario : Form
    {
        public NuevoFormulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] linia1 = textBox1.Text.Split(',');
                double X1 = Convert.ToDouble(linia1[0]);
                double Y1 = Convert.ToDouble(linia1[1]);
                string[] linia2 = textBox4.Text.Split(',');
                double X2 = Convert.ToDouble(linia2[0]);
                double Y2 = Convert.ToDouble(linia2[1]);
                double velodidad1 = Convert.ToDouble(textBox8.Text);

                FlightPlan A = new FlightPlan(textBox6.Text, X1, Y1, X2, Y2, velodidad1);

                string[] linia3 = textBox2.Text.Split(',');
                double X3 = Convert.ToDouble(linia3[0]);
                double Y3 = Convert.ToDouble(linia3[1]);
                string[] linia4 = textBox3.Text.Split(',');
                double X4 = Convert.ToDouble(linia4[0]);
                double Y4 = Convert.ToDouble(linia4[1]);
                double velodidad2 = Convert.ToDouble(textBox7.Text);

                FlightPlan B = new FlightPlan(textBox5.Text, X3, Y3, X4, Y4, velodidad2);

            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Introduce bien los datos");
            }
        }
    }
}
