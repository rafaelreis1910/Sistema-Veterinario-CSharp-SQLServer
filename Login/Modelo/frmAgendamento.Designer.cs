
namespace Login.Modelo
{
    partial class frmAgendamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label ag_situacaoLabel;
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbagendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agdataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aghorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agsituacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aganimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ag_situacaoComboBox = new System.Windows.Forms.ComboBox();
            ag_situacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbagendamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbagendamentoBindingSource, "ag_horario", true));
            this.txtemail.Location = new System.Drawing.Point(401, 258);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(109, 20);
            this.txtemail.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Horario";
            // 
            // txtcadcelular
            // 
            this.txtcadcelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbagendamentoBindingSource, "ag_data", true));
            this.txtcadcelular.Location = new System.Drawing.Point(219, 258);
            this.txtcadcelular.Name = "txtcadcelular";
            this.txtcadcelular.Size = new System.Drawing.Size(100, 20);
            this.txtcadcelular.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 47;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agcodigoDataGridViewTextBoxColumn,
            this.agdataDataGridViewTextBoxColumn,
            this.aghorarioDataGridViewTextBoxColumn,
            this.agsituacaoDataGridViewTextBoxColumn,
            this.aganimalDataGridViewTextBoxColumn,
            this.agtotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbagendamentoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(790, 220);
            this.dataGridView1.TabIndex = 46;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(346, 298);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 45;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(251, 298);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 44;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(161, 298);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 43;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(66, 298);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 42;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // txt_cadcliente
            // 
            this.txt_cadcliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbagendamentoBindingSource, "ag_codigo", true));
            this.txt_cadcliente.Location = new System.Drawing.Point(91, 258);
            this.txt_cadcliente.Name = "txt_cadcliente";
            this.txt_cadcliente.Size = new System.Drawing.Size(81, 20);
            this.txt_cadcliente.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Codigo";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbagendamentoBindingSource, "ag_animal", true));
            this.textBox2.Location = new System.Drawing.Point(504, 300);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 20);
            this.textBox2.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Animal";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbagendamentoBindingSource, "ag_total", true));
            this.textBox3.Location = new System.Drawing.Point(669, 301);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(109, 20);
            this.textBox3.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Total";
            // 
            // tbagendamentoBindingSource
            // 
            this.tbagendamentoBindingSource.DataSource = typeof(sistema.dal.tb_agendamento);
            // 
            // agcodigoDataGridViewTextBoxColumn
            // 
            this.agcodigoDataGridViewTextBoxColumn.DataPropertyName = "ag_codigo";
            this.agcodigoDataGridViewTextBoxColumn.HeaderText = "Codigo de Agendamento";
            this.agcodigoDataGridViewTextBoxColumn.Name = "agcodigoDataGridViewTextBoxColumn";
            this.agcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agdataDataGridViewTextBoxColumn
            // 
            this.agdataDataGridViewTextBoxColumn.DataPropertyName = "ag_data";
            this.agdataDataGridViewTextBoxColumn.HeaderText = "Data de Agendamento";
            this.agdataDataGridViewTextBoxColumn.Name = "agdataDataGridViewTextBoxColumn";
            this.agdataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aghorarioDataGridViewTextBoxColumn
            // 
            this.aghorarioDataGridViewTextBoxColumn.DataPropertyName = "ag_horario";
            this.aghorarioDataGridViewTextBoxColumn.HeaderText = "Horario de Agendamento";
            this.aghorarioDataGridViewTextBoxColumn.Name = "aghorarioDataGridViewTextBoxColumn";
            this.aghorarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agsituacaoDataGridViewTextBoxColumn
            // 
            this.agsituacaoDataGridViewTextBoxColumn.DataPropertyName = "ag_situacao";
            this.agsituacaoDataGridViewTextBoxColumn.HeaderText = "Situação de Agendamento";
            this.agsituacaoDataGridViewTextBoxColumn.Name = "agsituacaoDataGridViewTextBoxColumn";
            this.agsituacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aganimalDataGridViewTextBoxColumn
            // 
            this.aganimalDataGridViewTextBoxColumn.DataPropertyName = "ag_animal";
            this.aganimalDataGridViewTextBoxColumn.HeaderText = "Agendamento do Animal";
            this.aganimalDataGridViewTextBoxColumn.Name = "aganimalDataGridViewTextBoxColumn";
            this.aganimalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agtotalDataGridViewTextBoxColumn
            // 
            this.agtotalDataGridViewTextBoxColumn.DataPropertyName = "ag_total";
            this.agtotalDataGridViewTextBoxColumn.HeaderText = "Total de Agendamentos";
            this.agtotalDataGridViewTextBoxColumn.Name = "agtotalDataGridViewTextBoxColumn";
            this.agtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ag_situacaoLabel
            // 
            ag_situacaoLabel.AutoSize = true;
            ag_situacaoLabel.Location = new System.Drawing.Point(531, 264);
            ag_situacaoLabel.Name = "ag_situacaoLabel";
            ag_situacaoLabel.Size = new System.Drawing.Size(49, 13);
            ag_situacaoLabel.TabIndex = 57;
            ag_situacaoLabel.Text = "Situacao";
            // 
            // ag_situacaoComboBox
            // 
            this.ag_situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbagendamentoBindingSource, "ag_situacao", true));
            this.ag_situacaoComboBox.FormattingEnabled = true;
            this.ag_situacaoComboBox.Items.AddRange(new object[] {
            "Confirmada",
            "Não Confirmada"});
            this.ag_situacaoComboBox.Location = new System.Drawing.Point(586, 261);
            this.ag_situacaoComboBox.Name = "ag_situacaoComboBox";
            this.ag_situacaoComboBox.Size = new System.Drawing.Size(121, 21);
            this.ag_situacaoComboBox.TabIndex = 58;
            // 
            // frmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 452);
            this.Controls.Add(ag_situacaoLabel);
            this.Controls.Add(this.ag_situacaoComboBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
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
            this.Name = "frmAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbagendamentoBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox txt_cadcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource tbagendamentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn agcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agdataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aghorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agsituacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aganimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox ag_situacaoComboBox;
    }
}