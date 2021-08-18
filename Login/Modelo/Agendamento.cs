﻿using System;
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
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void agendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoVeterináriaDataSet);

        }

        private void Agendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoVeterináriaDataSet.agendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamentoTableAdapter.Fill(this.bancoVeterináriaDataSet.agendamento);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
