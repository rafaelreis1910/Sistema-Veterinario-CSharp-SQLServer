using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login.Modelo
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void BtnCadCliente_Click(object sender, EventArgs e)
        {
            frmCadClientes cliente = new frmCadClientes();
            cliente.Show();
        }

        private void BtnCadAnimal_Click(object sender, EventArgs e)
        {
            frmCadAnimal animal = new frmCadAnimal();
            animal.Show();
        }

        private void BtnCadRaca_Click(object sender, EventArgs e)
        {
            frmCadRaca raca = new frmCadRaca();
            raca.Show();
        }

        private void BtnServico_Click(object sender, EventArgs e)
        {
            frmServicos servicos = new frmServicos ();
            servicos.Show();
        }

        private void BtnAgendamento_Click(object sender, EventArgs e)
        {
            frmAgendamento agendamento = new frmAgendamento();
            agendamento.Show();
        }

        private void BtnAgenServicos_Click(object sender, EventArgs e)
        {
            
        }

        private void cadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpesquisarcliente cliente = new frmpesquisarcliente();
            cliente.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
