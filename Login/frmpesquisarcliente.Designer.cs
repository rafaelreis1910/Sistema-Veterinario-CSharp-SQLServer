
namespace Login
{
    partial class frmpesquisarcliente
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
            this.tb_cadclienteDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cadClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tb_cadclienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_cadclienteDataGridView
            // 
            this.tb_cadclienteDataGridView.AllowUserToAddRows = false;
            this.tb_cadclienteDataGridView.AllowUserToDeleteRows = false;
            this.tb_cadclienteDataGridView.AutoGenerateColumns = false;
            this.tb_cadclienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_cadclienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clinomeDataGridViewTextBoxColumn,
            this.clicodigoDataGridViewTextBoxColumn,
            this.clicelularDataGridViewTextBoxColumn,
            this.cliemailDataGridViewTextBoxColumn,
            this.clicpfDataGridViewTextBoxColumn,
            this.clienderecoDataGridViewTextBoxColumn});
            this.tb_cadclienteDataGridView.DataSource = this.cadClienteBindingSource;
            this.tb_cadclienteDataGridView.Location = new System.Drawing.Point(-2, 169);
            this.tb_cadclienteDataGridView.Name = "tb_cadclienteDataGridView";
            this.tb_cadclienteDataGridView.ReadOnly = true;
            this.tb_cadclienteDataGridView.Size = new System.Drawing.Size(656, 238);
            this.tb_cadclienteDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar";
            // 
            // btnbutton
            // 
            this.btnbutton.Location = new System.Drawing.Point(475, 37);
            this.btnbutton.Name = "btnbutton";
            this.btnbutton.Size = new System.Drawing.Size(75, 23);
            this.btnbutton.TabIndex = 3;
            this.btnbutton.Text = "Buscar";
            this.btnbutton.UseVisualStyleBackColor = true;
            this.btnbutton.Click += new System.EventHandler(this.btnbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.cadClienteBindingSource;
            this.comboBox1.DisplayMember = "cli_codigo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "cli_codigo";
            // 
            // cadClienteBindingSource
            // 
            this.cadClienteBindingSource.DataSource = typeof(sistema.dal.tb_cadcliente);
            // 
            // clinomeDataGridViewTextBoxColumn
            // 
            this.clinomeDataGridViewTextBoxColumn.DataPropertyName = "cli_nome";
            this.clinomeDataGridViewTextBoxColumn.HeaderText = "Cliente Nome";
            this.clinomeDataGridViewTextBoxColumn.Name = "clinomeDataGridViewTextBoxColumn";
            this.clinomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clicodigoDataGridViewTextBoxColumn
            // 
            this.clicodigoDataGridViewTextBoxColumn.DataPropertyName = "cli_codigo";
            this.clicodigoDataGridViewTextBoxColumn.HeaderText = "Cliente Codigo";
            this.clicodigoDataGridViewTextBoxColumn.Name = "clicodigoDataGridViewTextBoxColumn";
            this.clicodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clicelularDataGridViewTextBoxColumn
            // 
            this.clicelularDataGridViewTextBoxColumn.DataPropertyName = "cli_celular";
            this.clicelularDataGridViewTextBoxColumn.HeaderText = "Cliente Celular";
            this.clicelularDataGridViewTextBoxColumn.Name = "clicelularDataGridViewTextBoxColumn";
            this.clicelularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliemailDataGridViewTextBoxColumn
            // 
            this.cliemailDataGridViewTextBoxColumn.DataPropertyName = "cli_email";
            this.cliemailDataGridViewTextBoxColumn.HeaderText = "Cliente Email";
            this.cliemailDataGridViewTextBoxColumn.Name = "cliemailDataGridViewTextBoxColumn";
            this.cliemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clicpfDataGridViewTextBoxColumn
            // 
            this.clicpfDataGridViewTextBoxColumn.DataPropertyName = "cli_cpf";
            this.clicpfDataGridViewTextBoxColumn.HeaderText = "Cliente CPF";
            this.clicpfDataGridViewTextBoxColumn.Name = "clicpfDataGridViewTextBoxColumn";
            this.clicpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienderecoDataGridViewTextBoxColumn
            // 
            this.clienderecoDataGridViewTextBoxColumn.DataPropertyName = "cli_endereco";
            this.clienderecoDataGridViewTextBoxColumn.HeaderText = "Cliente Endereço";
            this.clienderecoDataGridViewTextBoxColumn.Name = "clienderecoDataGridViewTextBoxColumn";
            this.clienderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmpesquisarcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 407);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cadclienteDataGridView);
            this.Name = "frmpesquisarcliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Cliente";
            this.Load += new System.EventHandler(this.frmpesquisarcliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_cadclienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tb_cadclienteDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cadClienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienderecoDataGridViewTextBoxColumn;
    }
}