using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;
using FlightLib;

namespace FormsSimulator
{
    public partial class EspacioAéreo : Form
    {
        FlightPlanList milista;
        int 

        public EspacioAéreo(FlightPlanList milista)
        {
            InitializeComponent();
            this.milista = milista;
        }

        private void EspacioAéreo_Load(object sender, EventArgs e)
        {
            try
            {

                FlightPlan A = milista.GetFlightPlan(0);
                FlightPlan B = milista.GetFlightPlan(1);
                int X1 = Convert.ToInt32(A.GetInitialPosition().GetX());
                int Y1 = Convert.ToInt32(A.GetInitialPosition().GetY());
                int X2 = Convert.ToInt32(B.GetInitialPosition().GetX());
                int Y2 = Convert.ToInt32(B.GetInitialPosition().GetY());
                PictureBox pic1 = new PictureBox();
                pic1.Size = new Size(10, 10);
                pic1.BackColor = Color.Red;
                pic1.Location = new Point(X1, Y1);
                PictureBox pic2 = new PictureBox();
                pic2.Size = new Size(10, 10);
                pic2.BackColor = Color.LightGoldenrodYellow;
                pic2.Location = new Point(X2, Y2);
                panel1.Controls.Add(pic1);
                panel1.Controls.Add(pic2);
            }
            catch (FormatException)
            {
                Console.WriteLine("NO");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            milista.Mover(Simulator.GetDistancia());
        }
    }
}
