
namespace Login.Modelo
{
    partial class frmCadRaca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcadcelular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.txt_cadcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbracaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racacodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racanomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racapaisorigemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbracaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbracaBindingSource, "raca_pais_origem", true));
            this.txtemail.Location = new System.Drawing.Point(407, 256);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(109, 20);
            this.txtemail.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Pais Origem";
            // 
            // txtcadcelular
            // 
            this.txtcadcelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbracaBindingSource, "raca_nome", true));
            this.txtcadcelular.Location = new System.Drawing.Point(214, 256);
            this.txtcadcelular.Name = "txtcadcelular";
            this.txtcadcelular.Size = new System.Drawing.Size(100, 20);
            this.txtcadcelular.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.racacodigoDataGridViewTextBoxColumn,
            this.racanomeDataGridViewTextBoxColumn,
            this.racapaisorigemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbracaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Size = new System.Drawing.Size(790, 220);
            this.dataGridView1.TabIndex = 34;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(341, 296);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 33;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(246, 296);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 32;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(156, 296);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 31;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(61, 296);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 30;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // txt_cadcliente
            // 
            this.txt_cadcliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbracaBindingSource, "raca_codigo", true));
            this.txt_cadcliente.Location = new System.Drawing.Point(86, 256);
            this.txt_cadcliente.Name = "txt_cadcliente";
            this.txt_cadcliente.Size = new System.Drawing.Size(81, 20);
            this.txt_cadcliente.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Codigo";
            // 
            // tbracaBindingSource
            // 
            this.tbracaBindingSource.DataSource = typeof(sistema.dal.tb_raca);
            // 
            // racacodigoDataGridViewTextBoxColumn
            // 
            this.racacodigoDataGridViewTextBoxColumn.DataPropertyName = "raca_codigo";
            this.racacodigoDataGridViewTextBoxColumn.HeaderText = "Codigo da Raça";
            this.racacodigoDataGridViewTextBoxColumn.Name = "racacodigoDataGridViewTextBoxColumn";
            this.racacodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racanomeDataGridViewTextBoxColumn
            // 
            this.racanomeDataGridViewTextBoxColumn.DataPropertyName = "raca_nome";
            this.racanomeDataGridViewTextBoxColumn.HeaderText = "Nome da Raça";
            this.racanomeDataGridViewTextBoxColumn.Name = "racanomeDataGridViewTextBoxColumn";
            this.racanomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racapaisorigemDataGridViewTextBoxColumn
            // 
            this.racapaisorigemDataGridViewTextBoxColumn.DataPropertyName = "raca_pais_origem";
            this.racapaisorigemDataGridViewTextBoxColumn.HeaderText = "Pais Origem da Raça";
            this.racapaisorigemDataGridViewTextBoxColumn.Name = "racapaisorigemDataGridViewTextBoxColumn";
            this.racapaisorigemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCadRaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 412);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcadcelular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.txt_cadcliente);
            this.Controls.Add(this.label6);
            this.Name = "frmCadRaca";
            this.Text = "CadRaca";
            this.Load += new System.EventHandler(this.frmCadRaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbracaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcadcelular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn racacodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racanomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racapaisorigemDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbracaBindingSource;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox txt_cadcliente;
        private System.Windows.Forms.Label label6;
    }
}