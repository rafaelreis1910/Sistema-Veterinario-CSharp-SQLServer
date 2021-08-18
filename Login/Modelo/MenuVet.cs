using Login.Apresentação;
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
    public partial class MenuVet : Form
    {
        public MenuVet()
        {
            InitializeComponent();
        }

       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            Application.Exit();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            // para minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            CadCliente cliente = new CadCliente();
            cliente.TopLevel = false; // para o botao cliente nao subir para o topo
             cliente.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(cliente); // para add no panel
                cliente.Show();
           
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            PanelCentral.Controls.Clear();
        }

        private void BtnAnimais_Click(object sender, EventArgs e)
        {
            CadAnimal animal = new CadAnimal();
            animal.TopLevel = false; // para o botao cliente nao subir para o topo
            animal.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(animal); // para add no panel
            animal.Show();
        }

        private void BtnRacas_Click(object sender, EventArgs e)
        {
            CadRaca raca = new CadRaca();
            raca.TopLevel = false; // para o botao cliente nao subir para o topo
            raca.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(raca); // para add no panel
            raca.Show();
        }

        private void BtnServicos_Click(object sender, EventArgs e)
        {
           Servicos Serv = new Servicos();
            Serv.TopLevel = false; // para o botao cliente nao subir para o topo
            Serv.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(Serv); // para add no panel
            Serv.Show();
        }

        private void BtnAgendamentos_Click(object sender, EventArgs e)
        {
            Agendamento agen = new Agendamento();
            agen.TopLevel = false; // para o botao cliente nao subir para o topo
            agen.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(agen); // para add no panel
            agen.Show();
        }
    }
}
