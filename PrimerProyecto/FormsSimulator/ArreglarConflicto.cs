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
            while (ListaConflicto())
            {
                milista.GetFlightPlan(0).SetVelocidad(vel1 - 1);
                milista.GetFlightPlan(1).SetVelocidad(vel2 + 1);
                vel1 = vel1 - 1;
                vel2 = vel2 + 1;
            }
            EspacioAéreo Form = new EspacioAéreo(milista);
            Form.SetSimulator(simulator);
            Form.ShowDialog();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            EspacioAéreo Form = new EspacioAéreo(milista);
            Form.SetSimulator(simulator);
            Form.ShowDialog();
        }
        public bool ListaConflicto()
        {
            bool conflicto = false;
            for (int i = 0; i < milista.GetNumFlightPlans(); i++)
            {
                milista.GetFlightPlan(i).SetCurrentPosition(milista.GetFlightPlan(i).GetInitialPosition());
            }
            while (!conflicto)
            {
                milista.Mover(simulator.GetTiempo());
                conflicto = milista.GetFlightPlan(0).Conflicto(milista.GetFlightPlan(1), 2 * (simulator.GetDistancia()));
            }
            return conflicto;
        }
    }
}
