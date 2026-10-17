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

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] linia1 = PosicionInicial1.Text.Split(',');
                double X1 = Convert.ToDouble(linia1[0]);
                double Y1 = Convert.ToDouble(linia1[1]);
                string[] linia2 = PosicionFinal1.Text.Split(',');
                double X2 = Convert.ToDouble(linia2[0]);
                double Y2 = Convert.ToDouble(linia2[1]);
                double velodidad1 = Convert.ToDouble(Velocidad1.Text);

                FlightPlan A = new FlightPlan(Id1.Text, X1, Y1, X2, Y2, velodidad1);
                milista.AddFlightPlan(A);
                string[] linia3 = PosicionInicial2.Text.Split(',');
                double X3 = Convert.ToDouble(linia3[0]);
                double Y3 = Convert.ToDouble(linia3[1]);
                string[] linia4 = PosicionFinal2.Text.Split(',');
                double X4 = Convert.ToDouble(linia4[0]);
                double Y4 = Convert.ToDouble(linia4[1]);
                double velodidad2 = Convert.ToDouble(Velocidad2.Text);

                FlightPlan B = new FlightPlan(Id2.Text, X3, Y3, X4, Y4, velodidad2);
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
