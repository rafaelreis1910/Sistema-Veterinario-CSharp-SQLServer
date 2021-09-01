
namespace Login.Modelo
{
    partial class frmServicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label serv_precoLabel;
            this.tbservicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.servcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servdescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servprecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servtempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serv_precoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            serv_precoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbservicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbservicoBindingSource
            // 
            this.tbservicoBindingSource.DataSource = typeof(sistema.dal.tb_servico);
            // 
            // txtdescricao
            // 
            this.txtdescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbservicoBindingSource, "serv_descricao", true));
            this.txtdescricao.Location = new System.Drawing.Point(261, 280);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(100, 20);
            this.txtdescricao.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Descricao";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 65);
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
            this.servcodigoDataGridViewTextBoxColumn,
            this.servdescricaoDataGridViewTextBoxColumn,
            this.servprecoDataGridViewTextBoxColumn,
            this.servtempoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbservicoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(755, 235);
            this.dataGridView1.TabIndex = 46;
            // 
            // servcodigoDataGridViewTextBoxColumn
            // 
            this.servcodigoDataGridViewTextBoxColumn.DataPropertyName = "serv_codigo";
            this.servcodigoDataGridViewTextBoxColumn.HeaderText = "Codigo do Serviço";
            this.servcodigoDataGridViewTextBoxColumn.Name = "servcodigoDataGridViewTextBoxColumn";
            this.servcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servdescricaoDataGridViewTextBoxColumn
            // 
            this.servdescricaoDataGridViewTextBoxColumn.DataPropertyName = "serv_descricao";
            this.servdescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição do Serviço";
            this.servdescricaoDataGridViewTextBoxColumn.Name = "servdescricaoDataGridViewTextBoxColumn";
            this.servdescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servprecoDataGridViewTextBoxColumn
            // 
            this.servprecoDataGridViewTextBoxColumn.DataPropertyName = "serv_preco";
            this.servprecoDataGridViewTextBoxColumn.HeaderText = "Preço do Serviço";
            this.servprecoDataGridViewTextBoxColumn.Name = "servprecoDataGridViewTextBoxColumn";
            this.servprecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servtempoDataGridViewTextBoxColumn
            // 
            this.servtempoDataGridViewTextBoxColumn.DataPropertyName = "serv_tempo";
            this.servtempoDataGridViewTextBoxColumn.HeaderText = "Tempo de Serviço";
            this.servtempoDataGridViewTextBoxColumn.Name = "servtempoDataGridViewTextBoxColumn";
            this.servtempoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(370, 320);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 45;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(275, 320);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 44;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(185, 320);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 43;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(90, 320);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 42;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbservicoBindingSource, "serv_codigo", true));
            this.txt_codigo.Location = new System.Drawing.Point(115, 280);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(81, 20);
            this.txt_codigo.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Codigo";
            // 
            // txtempo
            // 
            this.txtempo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbservicoBindingSource, "serv_tempo", true));
            this.txtempo.Location = new System.Drawing.Point(566, 280);
            this.txtempo.Name = "txtempo";
            this.txtempo.Size = new System.Drawing.Size(109, 20);
            this.txtempo.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tempo";
            // 
            // serv_precoLabel
            // 
            serv_precoLabel.AutoSize = true;
            serv_precoLabel.Location = new System.Drawing.Point(364, 283);
            serv_precoLabel.Name = "serv_precoLabel";
            serv_precoLabel.Size = new System.Drawing.Size(35, 13);
            serv_precoLabel.TabIndex = 53;
            serv_precoLabel.Text = "Preço";
            // 
            // serv_precoMaskedTextBox
            // 
            this.serv_precoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbservicoBindingSource, "serv_preco", true));
            this.serv_precoMaskedTextBox.Location = new System.Drawing.Point(405, 280);
            this.serv_precoMaskedTextBox.Mask = "$";
            this.serv_precoMaskedTextBox.Name = "serv_precoMaskedTextBox";
            this.serv_precoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.serv_precoMaskedTextBox.TabIndex = 54;
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 408);
            this.Controls.Add(serv_precoLabel);
            this.Controls.Add(this.serv_precoMaskedTextBox);
            this.Controls.Add(this.txtempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label6);
            this.Name = "frmServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicos";
            ((System.ComponentModel.ISupportInitialize)(this.tbservicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tbservicoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn servcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servdescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servprecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servtempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox serv_precoMaskedTextBox;
    }
}