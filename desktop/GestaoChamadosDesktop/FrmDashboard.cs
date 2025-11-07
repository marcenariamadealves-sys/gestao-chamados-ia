using System;
using System.Windows.Forms;

namespace GestaoChamadosDesktop
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Bem-vindo, Administrador!";
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acesso ao módulo de chamados.");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
