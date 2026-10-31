using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace FormsSimulator
{
    public partial class MostrarDatos : Form
    {
        FlightPlanList milista;
        public MostrarDatos(FlightPlanList milista)
        {
            InitializeComponent();
            this.milista = milista;
        }

        private void MostrarDatos_Load(object sender, EventArgs e)
        {
            Matriz.RowCount = 8;
            Matriz.ColumnCount = milista.GetNumFlightPlans() + 1;
            Matriz.Rows[0].Cells[0] = new DataGridViewTextBoxCell();
            Matriz.Rows[0].Cells[0].Value = "Identificador";
            Matriz.Rows[1].Cells[0] = new DataGridViewTextBoxCell();
            Matriz.Rows[1].Cells[0].Value = "X inicial";
            Matriz.Rows[2].Cells[0] = new DataGridViewTextBoxCell();
            Matriz.Rows[2].Cells[0].Value = "Y inicial";
            Matriz.Rows[3].Cells[0] = new DataGridViewTextBoxCell();
            Matriz.Rows[3].Cells[0].Value = "X actual";
            Matriz.Rows[4].Cells[0] = new DataGridViewTextBoxCell();
            Matriz.Rows[4].Cells[0].Value = "Y actual";
            Matriz.Rows[5].Cells[0] = new DataGridViewTextBoxCell();
            Matriz.Rows[5].Cells[0].Value = "X final";
            Matriz.Rows[6].Cells[0] = new DataGridViewTextBoxCell();
            Matriz.Rows[6].Cells[0].Value = "Y final";
            Matriz.Rows[7].Cells[0] = new DataGridViewTextBoxCell();
            Matriz.Rows[7].Cells[0].Value = "Velocidad";
            for (int i = 0; i < milista.GetNumFlightPlans(); i++)
            {
                FlightPlan plan = milista.GetFlightPlan(i);
                Matriz.Rows[0].Cells[i + 1].Value = plan.GetId();
                Matriz.Rows[1].Cells[i + 1].Value = plan.GetInitialPosition().GetX();
                Matriz.Rows[2].Cells[i + 1].Value = plan.GetInitialPosition().GetY();
                Matriz.Rows[3].Cells[i + 1].Value = plan.GetCurrentPosition().GetX();
                Matriz.Rows[4].Cells[i + 1].Value = plan.GetCurrentPosition().GetY();
                Matriz.Rows[5].Cells[i + 1].Value = plan.GetFinalPosition().GetX();
                Matriz.Rows[6].Cells[i + 1].Value = plan.GetFinalPosition().GetY();
                Matriz.Rows[7].Cells[i + 1].Value = plan.GetVelocidad();
            }
        }

        private void Matriz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double distancia = 0;
            if (e.ColumnIndex == 1)
            {
                distancia = milista.GetFlightPlan(0).Distancia(milista.GetFlightPlan(1));
            }
            else if (e.ColumnIndex == 2)
            {
                distancia = milista.GetFlightPlan(1).Distancia(milista.GetFlightPlan(0));
            }
            else
            {
                MessageBox.Show("Seleccione un vuelo para calcular la distancia.");
                return;
            }
            DistanciaVuelos f1 = new DistanciaVuelos();
            f1.SetDistancia(distancia);
            f1.ShowDialog();
        }

        private void VolverAtrasBoton_MostrarDatos_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
