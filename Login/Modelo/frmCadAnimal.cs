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
    public partial class frmCadAnimal : Form
    {
        public frmCadAnimal()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadAnimal_Load(object sender, EventArgs e)
        {
            this.tbcadanimalBindingSource.DataSource = DataContextFactory.DataContext.tb_cadanimal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tbcadanimalBindingSource.AddNew();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.tbcadanimalBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Excluido com sucesso!");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.tbcadanimalBindingSource.CancelEdit();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {


                this.tbcadanimalBindingSource.EndEdit();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ani_sexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ani_alergiaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
