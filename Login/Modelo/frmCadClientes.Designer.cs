
namespace Login.Modelo
{
    partial class frmCadClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label cli_celularLabel;
            System.Windows.Forms.Label cli_cpfLabel;
            this.txt_cadcliente = new System.Windows.Forms.TextBox();
            this.cadClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clinomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cli_celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cli_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            cli_celularLabel = new System.Windows.Forms.Label();
            cli_cpfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cadcliente
            // 
            this.txt_cadcliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadClienteBindingSource, "cli_nome", true));
            this.txt_cadcliente.Location = new System.Drawing.Point(72, 247);
            this.txt_cadcliente.Name = "txt_cadcliente";
            this.txt_cadcliente.Size = new System.Drawing.Size(81, 20);
            this.txt_cadcliente.TabIndex = 11;
            this.txt_cadcliente.TextChanged += new System.EventHandler(this.txtcategorias_TextChanged);
            // 
            // cadClienteBindingSource
            // 
            this.cadClienteBindingSource.DataSource = typeof(sistema.dal.tb_cadcliente);
            this.cadClienteBindingSource.CurrentChanged += new System.EventHandler(this.cadClienteBindingSource_CurrentChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cliente";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(47, 287);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 14;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(142, 287);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 15;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(232, 287);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 16;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(327, 287);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clinomeDataGridViewTextBoxColumn,
            this.clicodigoDataGridViewTextBoxColumn,
            this.clicelularDataGridViewTextBoxColumn,
            this.cliemailDataGridViewTextBoxColumn,
            this.clicpfDataGridViewTextBoxColumn,
            this.clienderecoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadClienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(790, 220);
            this.dataGridView1.TabIndex = 18;
            // 
            // clinomeDataGridViewTextBoxColumn
            // 
            this.clinomeDataGridViewTextBoxColumn.DataPropertyName = "cli_nome";
            this.clinomeDataGridViewTextBoxColumn.FillWeight = 200F;
            this.clinomeDataGridViewTextBoxColumn.HeaderText = "Nome do Cliente";
            this.clinomeDataGridViewTextBoxColumn.Name = "clinomeDataGridViewTextBoxColumn";
            this.clinomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clicodigoDataGridViewTextBoxColumn
            // 
            this.clicodigoDataGridViewTextBoxColumn.DataPropertyName = "cli_codigo";
            this.clicodigoDataGridViewTextBoxColumn.HeaderText = "Código do Cliente";
            this.clicodigoDataGridViewTextBoxColumn.Name = "clicodigoDataGridViewTextBoxColumn";
            this.clicodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clicelularDataGridViewTextBoxColumn
            // 
            this.clicelularDataGridViewTextBoxColumn.DataPropertyName = "cli_celular";
            this.clicelularDataGridViewTextBoxColumn.HeaderText = "Celular do Cliente";
            this.clicelularDataGridViewTextBoxColumn.Name = "clicelularDataGridViewTextBoxColumn";
            this.clicelularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliemailDataGridViewTextBoxColumn
            // 
            this.cliemailDataGridViewTextBoxColumn.DataPropertyName = "cli_email";
            this.cliemailDataGridViewTextBoxColumn.HeaderText = "Email do Cliente";
            this.cliemailDataGridViewTextBoxColumn.Name = "cliemailDataGridViewTextBoxColumn";
            this.cliemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clicpfDataGridViewTextBoxColumn
            // 
            this.clicpfDataGridViewTextBoxColumn.DataPropertyName = "cli_cpf";
            this.clicpfDataGridViewTextBoxColumn.HeaderText = "CPF do Cliente";
            this.clicpfDataGridViewTextBoxColumn.Name = "clicpfDataGridViewTextBoxColumn";
            this.clicpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienderecoDataGridViewTextBoxColumn
            // 
            this.clienderecoDataGridViewTextBoxColumn.DataPropertyName = "cli_endereco";
            this.clienderecoDataGridViewTextBoxColumn.HeaderText = "Endereço do Cliente";
            this.clienderecoDataGridViewTextBoxColumn.Name = "clienderecoDataGridViewTextBoxColumn";
            this.clienderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 19;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadClienteBindingSource, "cli_email", true));
            this.txtemail.Location = new System.Drawing.Point(381, 247);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(109, 20);
            this.txtemail.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email";
            // 
            // txtendereco
            // 
            this.txtendereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadClienteBindingSource, "cli_endereco", true));
            this.txtendereco.Location = new System.Drawing.Point(526, 294);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(100, 20);
            this.txtendereco.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Endereco";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cli_celularLabel
            // 
            cli_celularLabel.AutoSize = true;
            cli_celularLabel.Location = new System.Drawing.Point(163, 250);
            cli_celularLabel.Name = "cli_celularLabel";
            cli_celularLabel.Size = new System.Drawing.Size(39, 13);
            cli_celularLabel.TabIndex = 27;
            cli_celularLabel.Text = "Celular";
            // 
            // cli_celularMaskedTextBox
            // 
            this.cli_celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadClienteBindingSource, "cli_celular", true));
            this.cli_celularMaskedTextBox.Location = new System.Drawing.Point(218, 247);
            this.cli_celularMaskedTextBox.Mask = "(99) 99999-9999";
            this.cli_celularMaskedTextBox.Name = "cli_celularMaskedTextBox";
            this.cli_celularMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cli_celularMaskedTextBox.TabIndex = 28;
            // 
            // cli_cpfLabel
            // 
            cli_cpfLabel.AutoSize = true;
            cli_cpfLabel.Location = new System.Drawing.Point(507, 250);
            cli_cpfLabel.Name = "cli_cpfLabel";
            cli_cpfLabel.Size = new System.Drawing.Size(27, 13);
            cli_cpfLabel.TabIndex = 28;
            cli_cpfLabel.Text = "CPF";
            // 
            // cli_cpfMaskedTextBox
            // 
            this.cli_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadClienteBindingSource, "cli_cpf", true));
            this.cli_cpfMaskedTextBox.Location = new System.Drawing.Point(551, 247);
            this.cli_cpfMaskedTextBox.Mask = "999.999.999/99";
            this.cli_cpfMaskedTextBox.Name = "cli_cpfMaskedTextBox";
            this.cli_cpfMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cli_cpfMaskedTextBox.TabIndex = 29;
            // 
            // frmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 390);
            this.Controls.Add(cli_cpfLabel);
            this.Controls.Add(this.cli_cpfMaskedTextBox);
            this.Controls.Add(cli_celularLabel);
            this.Controls.Add(this.cli_celularMaskedTextBox);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.txt_cadcliente);
            this.Controls.Add(this.label6);
            this.Name = "frmCadClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadClientes";
            this.Load += new System.EventHandler(this.frmCadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_cadcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource cadClienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox cli_celularMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cli_cpfMaskedTextBox;
    }
}