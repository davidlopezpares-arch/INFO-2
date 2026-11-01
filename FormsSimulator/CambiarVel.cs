using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsSimulator
{
    public partial class CambiarVel : Form
    {
        FlightPlanList milista;
        int cont = 0;
        public CambiarVel()
        {
            InitializeComponent();
        }
        public void SetLista(FlightPlanList milista)
        {
            this.milista = milista;
        }
        public FlightPlanList GetLista()
        {
            return this.milista;
        }

        private void CambiarVel_Load(object sender, EventArgs e)
        {
            Vuelolbl.Text = ("Vuelo " + 1);
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                milista.GetFlightPlan(cont).SetVelocidad(Convert.ToDouble(VelocidadBox.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numérico válido para la velocidad.");
                return;
            }
            if (cont < milista.GetNumFlightPlans() - 1)
            {
                cont++;
                Vuelolbl.Text = ("Vuelo " + (cont + 1));
            }
            else
            {
                MessageBox.Show("Velocidad cambiada para todos los vuelos.");
                this.Close();
            }
        }
    }
}
