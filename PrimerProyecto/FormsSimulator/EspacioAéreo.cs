using FlightLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;

namespace FormsSimulator
{
    public partial class EspacioAéreo : Form
    {
        FlightPlanList milista;
        Simulator simulator;

        PictureBox[] mispics = new PictureBox[10];
        int numpics = 0;

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
                pic1.Click += pic_Click;
                AddPic(pic1);
                PictureBox pic2 = new PictureBox();
                pic2.Size = new Size(10, 10);
                pic2.BackColor = Color.LightGoldenrodYellow;
                pic2.Location = new Point(X2, Y2);
                pic2.Click += pic_Click;
                AddPic(pic2);
                panel1.Controls.Add(pic1);
                panel1.Controls.Add(pic2);
            }
            catch (FormatException)
            {
                Console.WriteLine("NO");
            }
        }
        public void SetSimulator(Simulator simulator)
        {
            this.simulator = simulator;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            milista.Mover(simulator.GetTiempo());
            for (int i = 0; i < numpics; i++)
            {
                FlightPlan plan = milista.GetFlightPlan(i);
                if (plan != null)
                {
                    int X = Convert.ToInt32(plan.GetCurrentPosition().GetX());
                    int Y = Convert.ToInt32(plan.GetCurrentPosition().GetY());
                    mispics[i].Location = new Point(X, Y);
                }
            }
            //Debemos detectar el conflicto
            VerificarConflicto();

            //forzamos a redibujar las elipses
            panel1.Invalidate();
        }

        private void VerificarConflicto()
        {
            if (milista.GetNumber() >= 2)
            {
                FlightPlan A = milista.GetFlightPlan(0);
                FlightPlan B = milista.GetFlightPlan(1);

                if (A != null && B != null && A.Conflicto(B, simulator.GetDistancia()))
                {
                    MessageBox.Show("¡Traffic, traffic, TCAS on", "Pérdida de Separación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void AddPic(PictureBox pic)
        {
            if (numpics < 10)
            {
                mispics[numpics] = pic;
                numpics++;
            }
        }
        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            for (int i = 0; i < numpics; i++)
            {
                if (mispics[i] == pic)
                {
                    InfoVuelo Form = new InfoVuelo(milista.GetFlightPlan(i));
                    Form.ShowDialog();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Comprobar si hay conflicto activo para cambiar el color de la elipse
            bool hayConflicto = false;
            if (milista.GetNumber() >= 2)
            {
                FlightPlan A = milista.GetFlightPlan(0);
                FlightPlan B = milista.GetFlightPlan(1);
                if (A != null && B != null && A.Conflicto(B, simulator.GetDistancia()))
                {
                    hayConflicto = true;
                }
            }

            for(int i = 0; i< numpics; i++)
            {
                FlightPlan aircraft = milista.GetFlightPlan(i);
                if (aircraft == null) continue;

                System.Drawing.Graphics graphics = e.Graphics;
                Pen myPen = new Pen(Color.Goldenrod);
                Point punto1 = new Point(Convert.ToInt32(aircraft.GetInitialPosition().GetX()), Convert.ToInt32(aircraft.GetInitialPosition().GetY()));
                Point punto2 = new Point(Convert.ToInt32(aircraft.GetFinalPosition().GetX()), Convert.ToInt32(aircraft.GetFinalPosition().GetY()));
                graphics.DrawLine(myPen, punto1, punto2);

                Color colorElipse;
                float grosor;

                if (hayConflicto)
                {
                    colorElipse = Color.Red;
                    grosor = 2.5f;
                }
                else
                {
                    colorElipse = Color.Chocolate;
                    grosor = 1.0f;
                }

                myPen = new Pen(colorElipse, grosor);

                Point punto3 = new Point(Convert.ToInt32(aircraft.GetCurrentPosition().GetX()- simulator.GetDistancia()), Convert.ToInt32(aircraft.GetCurrentPosition().GetY() - simulator.GetDistancia()));
                int diametro = 2 * Convert.ToInt32(simulator.GetDistancia());
                graphics.DrawEllipse(myPen, punto3.X, punto3.Y, diametro, diametro);
            }

        }
    }
}
