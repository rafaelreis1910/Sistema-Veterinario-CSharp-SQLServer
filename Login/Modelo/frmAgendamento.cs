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
    public partial class frmAgendamento : Form
    {
        public frmAgendamento()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.tbagendamentoBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {


                this.tbagendamentoBindingSource.EndEdit();
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.tbagendamentoBindingSource.CancelEdit();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.tbagendamentoBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Excluido com sucesso!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
