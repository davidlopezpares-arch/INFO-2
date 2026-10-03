using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FlightLib;

namespace FormsSimulator
{
    public partial class NuevoForm : Form
    {
        FlightPlanList milista;
        public NuevoForm(FlightPlanList milista)
        {
            InitializeComponent();
            this.milista = milista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] linia1 = textBox2.Text.Split(',');
                double X1 = Convert.ToDouble(linia1[0]);
                double Y1 = Convert.ToDouble(linia1[1]);
                string[] linia2 = textBox3.Text.Split(',');
                double X2 = Convert.ToDouble(linia2[0]);
                double Y2 = Convert.ToDouble(linia2[1]);
                double velodidad1 = Convert.ToDouble(textBox4.Text);

                FlightPlan A = new FlightPlan(textBox1.Text, X1, Y1, X2, Y2, velodidad1);
                milista.AddFlightPlan(A);
                string[] linia3 = textBox7.Text.Split(',');
                double X3 = Convert.ToDouble(linia3[0]);
                double Y3 = Convert.ToDouble(linia3[1]);
                string[] linia4 = textBox6.Text.Split(',');
                double X4 = Convert.ToDouble(linia4[0]);
                double Y4 = Convert.ToDouble(linia4[1]);
                double velodidad2 = Convert.ToDouble(textBox5.Text);

                FlightPlan B = new FlightPlan(textBox8.Text, X3, Y3, X4, Y4, velodidad2);
                milista.AddFlightPlan(B);
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Introduce bien los datos");
            }
            
        }
    }
}
