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
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoVeterináriaDataSet);

        }

        private void Servicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoVeterináriaDataSet.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.bancoVeterináriaDataSet.servico);

        }

        private void serv_precoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void serv_codigoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void serv_descricaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void serv_codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void serv_precoLabel_Click(object sender, EventArgs e)
        {

        }

        private void serv_descricaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void serv_tempoLabel_Click(object sender, EventArgs e)
        {

        }

        private void serv_tempoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serv_precoMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
