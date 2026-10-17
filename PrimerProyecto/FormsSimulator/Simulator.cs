using FlightLib;

namespace FormsSimulator
{
    public partial class Simulator : Form
    {
        public Simulator()
        {
            InitializeComponent();
        }
        FlightPlanList milista = new FlightPlanList();
        double distancia;
        int tiempo;

        private void nuevoFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoForm Form = new NuevoForm(milista);
            Form.ShowDialog();
        }

        private void distSeguridadYTCicloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistanciaSeguridad Form = new DistanciaSeguridad();
            Form.ShowDialog();
            distancia = Form.GetDistancia();
            tiempo = Form.GetCiclo();
        }

        private void espacioAéreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (milista.GetFlightPlan(0).Conflicto(milista.GetFlightPlan(1), 2 * (GetDistancia())) == false)
            {
                milista.Mover(GetTiempo());
            }
            if (milista.GetFlightPlan(0).Conflicto(milista.GetFlightPlan(1), 2 * (GetDistancia())) == true)
            {
                ArreglarConflicto form = new ArreglarConflicto();
                form.SetFlightPlanList(milista);
                form.SetSimulator(this);
                form.ShowDialog();
            }
            else
            {
                EspacioAéreo Form = new EspacioAéreo(milista);
                Form.SetSimulator(this);
                Form.ShowDialog();
            }

            
        }
        public double GetDistancia()
        {
            return distancia;
        }
        public int GetTiempo()
        {
            return tiempo;  
        }
    }
}
