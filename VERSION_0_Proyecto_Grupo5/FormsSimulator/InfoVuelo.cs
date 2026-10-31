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
    public partial class InfoVuelo : Form
    {
        FlightPlan plan = new FlightPlan("", 0, 0, 0, 0, 0);
        public InfoVuelo(FlightPlan plan)
        {
            InitializeComponent();
            this.plan = plan;
        }

        private void InfoVuelo_Load(object sender, EventArgs e)
        {
            Matriz.RowCount = 8;
            Matriz.ColumnCount = 2;
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
            Matriz.Rows[0].Cells[1].Value = plan.GetId();
            Matriz.Rows[1].Cells[1].Value = plan.GetInitialPosition().GetX();
            Matriz.Rows[2].Cells[1].Value = plan.GetInitialPosition().GetY();
            Matriz.Rows[3].Cells[1].Value = plan.GetCurrentPosition().GetX();
            Matriz.Rows[4].Cells[1].Value = plan.GetCurrentPosition().GetY();
            Matriz.Rows[5].Cells[1].Value = plan.GetFinalPosition().GetX();
            Matriz.Rows[6].Cells[1].Value = plan.GetFinalPosition().GetY();
            Matriz.Rows[7].Cells[1].Value = plan.GetVelocidad();
        }

        private void VolverAtrasBoton_InfoVuelo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
