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
    public partial class frmServicos : Form
    {
        public frmServicos()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.tbservicoBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {


                this.tbservicoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Inserido com sucesso!");



            }

        }
        private bool valida()
        {
            if (txt_codigo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo é obrigatorio");
                txt_codigo.Focus();
                return false;
            }
            return true;


        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.tbservicoBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Excluido com sucesso!");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.tbservicoBindingSource.CancelEdit();
        }
    }
    }

