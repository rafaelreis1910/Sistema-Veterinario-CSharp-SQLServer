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
namespace Login
{
    public partial class frmpesquisarcliente : Form
    {
        public frmpesquisarcliente()
        {
            InitializeComponent();
        }

        private void frmpesquisarcliente_Load(object sender, EventArgs e)
        {
            this.cadClienteBindingSource.DataSource = DataContextFactory.DataContext.tb_cadcliente;
        }

        private void btnbutton_Click(object sender, EventArgs e)
        {
            
        }
        public void Pesquisar(int NomeCliente)
        {
            
        }
            
   
        

           
        }
    }

