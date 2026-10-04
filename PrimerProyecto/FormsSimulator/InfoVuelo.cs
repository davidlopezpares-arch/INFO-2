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
            dataGridView1.RowCount = 8;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Rows[0].Cells[0] = new DataGridViewTextBoxCell();
            dataGridView1.Rows[0].Cells[0].Value = "Identificador";
            dataGridView1.Rows[1].Cells[0] = new DataGridViewTextBoxCell();
            dataGridView1.Rows[1].Cells[0].Value = "X inicial";
            dataGridView1.Rows[2].Cells[0] = new DataGridViewTextBoxCell();
            dataGridView1.Rows[2].Cells[0].Value = "Y inicial";
            dataGridView1.Rows[3].Cells[0] = new DataGridViewTextBoxCell();
            dataGridView1.Rows[3].Cells[0].Value = "X actual";
            dataGridView1.Rows[4].Cells[0] = new DataGridViewTextBoxCell();
            dataGridView1.Rows[4].Cells[0].Value = "Y actual";
            dataGridView1.Rows[5].Cells[0] = new DataGridViewTextBoxCell();
            dataGridView1.Rows[5].Cells[0].Value = "X final";
            dataGridView1.Rows[6].Cells[0] = new DataGridViewTextBoxCell();
            dataGridView1.Rows[6].Cells[0].Value = "Y final";
            dataGridView1.Rows[7].Cells[0] = new DataGridViewTextBoxCell();
            dataGridView1.Rows[7].Cells[0].Value = "Velocidad";
            dataGridView1.Rows[0].Cells[1].Value = plan.GetId();
            dataGridView1.Rows[1].Cells[1].Value = plan.GetInitialPosition().GetX();
            dataGridView1.Rows[2].Cells[1].Value = plan.GetInitialPosition().GetY();
            dataGridView1.Rows[3].Cells[1].Value = plan.GetCurrentPosition().GetX();
            dataGridView1.Rows[4].Cells[1].Value = plan.GetCurrentPosition().GetY();
            dataGridView1.Rows[5].Cells[1].Value = plan.GetFinalPosition().GetX();
            dataGridView1.Rows[6].Cells[1].Value = plan.GetFinalPosition().GetY();
            dataGridView1.Rows[7].Cells[1].Value = plan.GetVelocidad();
        }
    }
}
