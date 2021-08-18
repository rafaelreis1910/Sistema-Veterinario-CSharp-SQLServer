using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Apresentação
{
    public partial class CadCliente : Form
    {
        

        public CadCliente()
        {
            InitializeComponent();
        }

     

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try  // para tentar
            {
            this.Validate();
            this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(bancoVeterináriaDataSet.cliente);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro salvo");
            }
            catch (Exception) // capturar
            {
                MessageBox.Show("Ocorreu um erro o salvar"); 
            }
            
            
            

        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoVeterináriaDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bancoVeterináriaDataSet.cliente);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirme exclusão do registro", "Projeto Veterinária", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent(); //remove
                    clienteTableAdapter.Update(bancoVeterináriaDataSet.cliente); //salva
                }

            }
            catch (Exception) //captura o erro
            {

                clienteTableAdapter.Fill(bancoVeterináriaDataSet.cliente);
                MessageBox.Show("Registro não pode ser removido");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cli_codigoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
