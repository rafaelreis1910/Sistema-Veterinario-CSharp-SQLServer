using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.dal;

namespace Login.Modelo
{
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            this.cadClienteBindingSource.DataSource = DataContextFactory.DataContext.tb_cadcliente;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.cadClienteBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {


                this.cadClienteBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Inserido com sucesso!");

                

            }
            
        }
        private bool valida()
        {
            if (txt_cadcliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo é obrigatorio");
                txt_cadcliente.Focus();
                return false;
            }
            return true;
        }
       
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.cadClienteBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Excluido com sucesso!");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.cadClienteBindingSource.CancelEdit();
        }
        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtcategorias_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadClienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
