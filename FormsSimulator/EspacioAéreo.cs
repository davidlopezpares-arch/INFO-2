using FlightLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
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
        bool conflicto1 = false;
        public EspacioAéreo(FlightPlanList milista)
        {
            InitializeComponent();
            this.milista = milista;
        }
        public FlightPlanList GetLista()
        {
            return this.milista;
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
                pic1.Location = new Point(X1 - 5, Y1 - 5);
                pic1.Click += pic_Click;
                AddPic(pic1);
                PictureBox pic2 = new PictureBox();
                pic2.Size = new Size(10, 10);
                pic2.BackColor = Color.LightGoldenrodYellow;
                pic2.Location = new Point(X2 - 5, Y2 - 5);
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
        private void Moverbutton_Click(object sender, EventArgs e)
        {
            milista.Mover(simulator.GetTiempo());
            for (int i = 0; i < numpics; i++)
            {
                FlightPlan plan = milista.GetFlightPlan(i);
                int X = Convert.ToInt32(plan.GetCurrentPosition().GetX());
                int Y = Convert.ToInt32(plan.GetCurrentPosition().GetY());
                mispics[i].Location = new Point(X - 5, Y - 5);
            }
            panel1.Invalidate();
            MostrarMensajeConflicto();

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
            for (int i = 0; i < numpics; i++)
            {
                FlightPlan aircraft = milista.GetFlightPlan(i);
                System.Drawing.Graphics graphics = e.Graphics;
                Pen myPen = new Pen(Color.Goldenrod);
                Point punto1 = new Point(Convert.ToInt32(aircraft.GetInitialPosition().GetX()), Convert.ToInt32(aircraft.GetInitialPosition().GetY()));
                Point punto2 = new Point(Convert.ToInt32(aircraft.GetFinalPosition().GetX()), Convert.ToInt32(aircraft.GetFinalPosition().GetY()));
                graphics.DrawLine(myPen, punto1, punto2);

                myPen = new Pen(Color.Blue);
                Point punto3 = new Point(Convert.ToInt32(aircraft.GetCurrentPosition().GetX() - simulator.GetDistancia()), Convert.ToInt32(aircraft.GetCurrentPosition().GetY() - simulator.GetDistancia()));
                int diametro = 2 * Convert.ToInt32(simulator.GetDistancia());
                graphics.DrawEllipse(myPen, punto3.X, punto3.Y, diametro, diametro);
                if (milista.GetFlightPlan(0).Conflicto(milista.GetFlightPlan(1), 2 * (simulator.GetDistancia())) == true)
                {
                    myPen = new Pen(Color.Red);
                    Point punto4 = new Point(Convert.ToInt32(aircraft.GetCurrentPosition().GetX() - simulator.GetDistancia()), Convert.ToInt32(aircraft.GetCurrentPosition().GetY() - simulator.GetDistancia()));
                    int diametro2 = 2 * Convert.ToInt32(simulator.GetDistancia());
                    graphics.DrawEllipse(myPen, punto4.X, punto4.Y, diametro2, diametro2);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milista.Mover(simulator.GetTiempo());
            for (int i = 0; i < numpics; i++)
            {
                FlightPlan plan = milista.GetFlightPlan(i);
                int X = Convert.ToInt32(plan.GetCurrentPosition().GetX());
                int Y = Convert.ToInt32(plan.GetCurrentPosition().GetY());
                mispics[i].Location = new Point(X - 5, Y - 5);
            }
            panel1.Invalidate();
            if (milista.GetFlightPlan(0).Conflicto(milista.GetFlightPlan(1), 2 * (simulator.GetDistancia())) == true)
            {
                timer1.Stop();
                Automáticobutton.Text = "Automático";
            }
            MostrarMensajeConflicto();
        }

        private void Automáticobutton_Click(object sender, EventArgs e)
        {
            if (Automáticobutton.Text == "Automático")
            {
                timer1.Interval = 500;
                timer1.Start();
                Automáticobutton.Text = "Parar";
            }
            else
            {
                timer1.Stop();
                Automáticobutton.Text = "Automático";
            }
        }

        private void MostarDatosButton_Click(object sender, EventArgs e)
        {
            MostrarDatos Form = new MostrarDatos(milista);
            Form.ShowDialog();
        }
        public void MostrarMensajeConflicto()
        {
            if ((milista.GetFlightPlan(0).Conflicto(milista.GetFlightPlan(1), 2 * (simulator.GetDistancia()))) && !conflicto1)
            {
                MessageBox.Show("Traffic, Traffic, TCAS on");
                conflicto1 = true;
            }
        }
        private void Conflicto_Click(object sender, EventArgs e)
        {
            double x1 = milista.GetFlightPlan(0).GetCurrentPosition().GetX();
            double y1 = milista.GetFlightPlan(0).GetCurrentPosition().GetY();
            double x2 = milista.GetFlightPlan(1).GetCurrentPosition().GetX();
            double y2 = milista.GetFlightPlan(1).GetCurrentPosition().GetY();
            bool conflicto = milista.GetFlightPlan(0).Conflicto(milista.GetFlightPlan(1), 2 * (simulator.GetDistancia()));
            while (conflicto == false && !milista.GetFlightPlan(0).EstaDestino())
            {
                milista.Mover(simulator.GetTiempo());
                conflicto = milista.GetFlightPlan(0).Conflicto(milista.GetFlightPlan(1), 2 * (simulator.GetDistancia()));
            }
            if (conflicto == true)
            {
                MessageBox.Show("Van a Chocar!!!!!!!!!!!");
            }
            else
            {
                MessageBox.Show("No habrá Conflicto");
            }
            milista.GetFlightPlan(0).SetCurrentPosition(new Position(x1, y1));
            milista.GetFlightPlan(1).SetCurrentPosition(new Position(x2, y2));
        }

        private void VolverAtrasBoton_EspacioAereo_Click(object sender, EventArgs e)
        {
            milista.GetFlightPlan(0).Restart();
            milista.GetFlightPlan(1).Restart();
            Close();
        }

        private void CambiarVelocidad_Click(object sender, EventArgs e)
        {
            CambiarVel f = new CambiarVel();
            f.SetLista(milista);
            f.ShowDialog();
            this.milista = f.GetLista();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < milista.GetNumFlightPlans(); i++)
            {
                FlightPlan plan = milista.GetFlightPlan(i);
                plan.Restart();
                int X = Convert.ToInt32(plan.GetCurrentPosition().GetX());
                int Y = Convert.ToInt32(plan.GetCurrentPosition().GetY());
                mispics[i].Location = new Point(X - 5, Y - 5);
            }
            panel1.Invalidate();
        }
    }
}
