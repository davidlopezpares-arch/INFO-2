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
        bool enviado; // Variable que se utiliza para indicar si se ha enviado la información de distancia y tiempo desde el formulario DistanciaSeguridad

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
            enviado = Form.GetEnviado();
        }

        private void espacioAéreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(milista.GetNumFlightPlans() < 2 || !enviado)
            {
                MessageBox.Show("Se necesitan al menos 2 planes de vuelo y/o los parámetros de distancia y/o tiempo deben estar definidos.");
                return;
            }
            while (milista.GetFlightPlan(0).Conflicto(milista.GetFlightPlan(1), 2 * (GetDistancia())) == false)
            {
                milista.Mover(GetTiempo());
            }
            if (milista.GetFlightPlan(0).Conflicto(milista.GetFlightPlan(1), 2 * (GetDistancia())) == true)
                {
                    milista.GetFlightPlan(0).Restart();
                    milista.GetFlightPlan(1).Restart();
                    ArreglarConflicto form = new ArreglarConflicto();
                    form.SetFlightPlanList(milista);
                    form.SetSimulator(this);
                    form.ShowDialog();
                    milista = form.GetLista();
                }
                else
                {
                    milista.GetFlightPlan(0).Restart();
                    milista.GetFlightPlan(1).Restart();
                    EspacioAéreo Form = new EspacioAéreo(milista);
                    Form.SetSimulator(this);
                    Form.ShowDialog();
                    milista = Form.GetLista();
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
