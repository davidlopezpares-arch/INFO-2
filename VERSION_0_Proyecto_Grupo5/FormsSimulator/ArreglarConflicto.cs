using FlightLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsSimulator
{
    public partial class ArreglarConflicto : Form
    {
        public ArreglarConflicto()
        {
            InitializeComponent();
        }
        FlightPlanList milista = new FlightPlanList();
        Simulator simulator = new Simulator();
        public void SetFlightPlanList(FlightPlanList milista)
        {
            this.milista = milista;
        }
        public void SetSimulator(Simulator simulator)
        {
            this.simulator = simulator;
        }
        private void SiButton_Click(object sender, EventArgs e)
        {
            double vel1 = milista.GetFlightPlan(0).GetVelocidad();
            double vel2 = milista.GetFlightPlan(1).GetVelocidad();
            if (milista.GetFlightPlan(0).Distancia(milista.GetFlightPlan(1))< 2 * simulator.GetDistancia())
            {
                MessageBox.Show("No hay manera de arreglarlo, tienes que poner menos distancia de seguridad");
            }
            while (DistanciaMinima()< 2* simulator.GetDistancia())
            {
                vel1 = vel1 - 0.1;
                vel2 = vel2 + 0.1;
                milista.GetFlightPlan(0).SetVelocidad(vel1);
                milista.GetFlightPlan(1).SetVelocidad(vel2);
            }
            for (int i = 0; i < milista.GetNumFlightPlans(); i++)
            {
                milista.GetFlightPlan(i).Restart();
            }

            EspacioAéreo Form = new EspacioAéreo(milista);
            Form.SetSimulator(simulator);
            Form.ShowDialog();
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            EspacioAéreo Form = new EspacioAéreo(milista);
            Form.SetSimulator(simulator);
            Form.ShowDialog();
        }
        public bool ListaConflicto(FlightPlanList lista)
        {
            bool conflicto = false;
            for (int i = 0; i < lista.GetNumFlightPlans(); i++)
            {
                lista.GetFlightPlan(i).SetCurrentPosition(lista.GetFlightPlan(i).GetInitialPosition());
            }
            while (!conflicto)
            {
                lista.Mover(simulator.GetTiempo());
                conflicto = lista.GetFlightPlan(0).Conflicto(lista.GetFlightPlan(1), 2 * (simulator.GetDistancia()));
            }
            milista.GetFlightPlan(0).Restart();
            milista.GetFlightPlan(1).Restart();
            return conflicto;
        }
        public double DistanciaMinima()
        {
            for (int i = 0; i < milista.GetNumFlightPlans(); i++)
            {
                milista.GetFlightPlan(i).Restart();
            }
            double distanciaminima = milista.GetFlightPlan(0).Distancia(milista.GetFlightPlan(1));
            double tiempominimo = 1;
            while (!milista.GetFlightPlan(0).EstaDestino() || !milista.GetFlightPlan(1).EstaDestino())
            {
                milista.Mover(tiempominimo);
                if (milista.GetFlightPlan(0).Distancia(milista.GetFlightPlan(1)) < distanciaminima)
                {
                    distanciaminima = milista.GetFlightPlan(0).Distancia(milista.GetFlightPlan(1));
                }
            }
            return distanciaminima;
        }
    }
}
