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
            EspacioAéreo Form = new EspacioAéreo(milista);
            Form.ShowDialog();
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
