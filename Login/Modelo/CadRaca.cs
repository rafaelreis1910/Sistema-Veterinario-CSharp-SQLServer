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
    public partial class CadRaca : Form
    {
        public CadRaca()
        {
            InitializeComponent();
        }

        private void CadRaca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoVeterináriaDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.bancoVeterináriaDataSet.raca);

        }

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.racaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoVeterináriaDataSet);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.racaTableAdapter.FillBy(this.bancoVeterináriaDataSet.raca);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
