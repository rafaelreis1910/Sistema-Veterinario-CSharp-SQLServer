
namespace Login.Modelo
{
    partial class frmCadAnimal
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
            System.Windows.Forms.Label ani_sexoLabel;
            System.Windows.Forms.Label ani_agressivoLabel;
            System.Windows.Forms.Label ani_alergiaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label ani_clienteLabel1;
            System.Windows.Forms.Label ani_racaLabel1;
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.tbcadanimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtcadcelular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.txt_cadcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.anicodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aninomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anisexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniagressivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anicorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anialergiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ani_sexoComboBox = new System.Windows.Forms.ComboBox();
            this.ani_agressivoComboBox = new System.Windows.Forms.ComboBox();
            this.ani_alergiaComboBox = new System.Windows.Forms.ComboBox();
            this.cadClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ani_clienteTextBox = new System.Windows.Forms.TextBox();
            this.ani_racaTextBox = new System.Windows.Forms.TextBox();
            ani_sexoLabel = new System.Windows.Forms.Label();
            ani_agressivoLabel = new System.Windows.Forms.Label();
            ani_alergiaLabel = new System.Windows.Forms.Label();
            ani_clienteLabel1 = new System.Windows.Forms.Label();
            ani_racaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbcadanimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ani_sexoLabel
            // 
            ani_sexoLabel.AutoSize = true;
            ani_sexoLabel.Location = new System.Drawing.Point(306, 260);
            ani_sexoLabel.Name = "ani_sexoLabel";
            ani_sexoLabel.Size = new System.Drawing.Size(31, 13);
            ani_sexoLabel.TabIndex = 60;
            ani_sexoLabel.Text = "Sexo";
            // 
            // ani_agressivoLabel
            // 
            ani_agressivoLabel.AutoSize = true;
            ani_agressivoLabel.Location = new System.Drawing.Point(465, 262);
            ani_agressivoLabel.Name = "ani_agressivoLabel";
            ani_agressivoLabel.Size = new System.Drawing.Size(53, 13);
            ani_agressivoLabel.TabIndex = 61;
            ani_agressivoLabel.Text = "Agressivo";
            // 
            // ani_alergiaLabel
            // 
            ani_alergiaLabel.AutoSize = true;
            ani_alergiaLabel.Location = new System.Drawing.Point(636, 312);
            ani_alergiaLabel.Name = "ani_alergiaLabel";
            ani_alergiaLabel.Size = new System.Drawing.Size(39, 13);
            ani_alergiaLabel.TabIndex = 62;
            ani_alergiaLabel.Text = "Alergia";
            // 
            // txtendereco
            // 
            this.txtendereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcadanimalBindingSource, "ani_cor", true));
            this.txtendereco.Location = new System.Drawing.Point(526, 310);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(100, 20);
            this.txtendereco.TabIndex = 52;
            // 
            // tbcadanimalBindingSource
            // 
            this.tbcadanimalBindingSource.DataSource = typeof(sistema.dal.tb_cadanimal);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Cor";
            // 
            // txtcadcelular
            // 
            this.txtcadcelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcadanimalBindingSource, "ani_nome", true));
            this.txtcadcelular.Location = new System.Drawing.Point(197, 256);
            this.txtcadcelular.Name = "txtcadcelular";
            this.txtcadcelular.Size = new System.Drawing.Size(100, 20);
            this.txtcadcelular.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 44;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(361, 324);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 42;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(254, 324);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 41;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(150, 324);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 40;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(49, 324);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 39;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_cadcliente
            // 
            this.txt_cadcliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcadanimalBindingSource, "ani_codigo", true));
            this.txt_cadcliente.Location = new System.Drawing.Point(55, 257);
            this.txt_cadcliente.Name = "txt_cadcliente";
            this.txt_cadcliente.Size = new System.Drawing.Size(81, 20);
            this.txt_cadcliente.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Codigo";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anicodigoDataGridViewTextBoxColumn,
            this.aninomeDataGridViewTextBoxColumn,
            this.anisexoDataGridViewTextBoxColumn,
            this.aniagressivoDataGridViewTextBoxColumn,
            this.anicorDataGridViewTextBoxColumn,
            this.aniidadeDataGridViewTextBoxColumn,
            this.anialergiaDataGridViewTextBoxColumn,
            this.aniclienteDataGridViewTextBoxColumn,
            this.aniracaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tbcadanimalBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Size = new System.Drawing.Size(1041, 220);
            this.dataGridView2.TabIndex = 43;
            // 
            // anicodigoDataGridViewTextBoxColumn
            // 
            this.anicodigoDataGridViewTextBoxColumn.DataPropertyName = "ani_codigo";
            this.anicodigoDataGridViewTextBoxColumn.HeaderText = "Codigo do Animal";
            this.anicodigoDataGridViewTextBoxColumn.Name = "anicodigoDataGridViewTextBoxColumn";
            this.anicodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aninomeDataGridViewTextBoxColumn
            // 
            this.aninomeDataGridViewTextBoxColumn.DataPropertyName = "ani_nome";
            this.aninomeDataGridViewTextBoxColumn.HeaderText = "Nome do Animal";
            this.aninomeDataGridViewTextBoxColumn.Name = "aninomeDataGridViewTextBoxColumn";
            this.aninomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anisexoDataGridViewTextBoxColumn
            // 
            this.anisexoDataGridViewTextBoxColumn.DataPropertyName = "ani_sexo";
            this.anisexoDataGridViewTextBoxColumn.HeaderText = "Sexo do Animal";
            this.anisexoDataGridViewTextBoxColumn.Name = "anisexoDataGridViewTextBoxColumn";
            this.anisexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aniagressivoDataGridViewTextBoxColumn
            // 
            this.aniagressivoDataGridViewTextBoxColumn.DataPropertyName = "ani_agressivo";
            this.aniagressivoDataGridViewTextBoxColumn.HeaderText = "Animal Agressivo";
            this.aniagressivoDataGridViewTextBoxColumn.Name = "aniagressivoDataGridViewTextBoxColumn";
            this.aniagressivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anicorDataGridViewTextBoxColumn
            // 
            this.anicorDataGridViewTextBoxColumn.DataPropertyName = "ani_cor";
            this.anicorDataGridViewTextBoxColumn.HeaderText = "Cor do Animal";
            this.anicorDataGridViewTextBoxColumn.Name = "anicorDataGridViewTextBoxColumn";
            this.anicorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aniidadeDataGridViewTextBoxColumn
            // 
            this.aniidadeDataGridViewTextBoxColumn.DataPropertyName = "ani_idade";
            this.aniidadeDataGridViewTextBoxColumn.HeaderText = "Idade do Animal";
            this.aniidadeDataGridViewTextBoxColumn.Name = "aniidadeDataGridViewTextBoxColumn";
            this.aniidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anialergiaDataGridViewTextBoxColumn
            // 
            this.anialergiaDataGridViewTextBoxColumn.DataPropertyName = "ani_alergia";
            this.anialergiaDataGridViewTextBoxColumn.HeaderText = "Alergia do Animal";
            this.anialergiaDataGridViewTextBoxColumn.Name = "anialergiaDataGridViewTextBoxColumn";
            this.anialergiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aniclienteDataGridViewTextBoxColumn
            // 
            this.aniclienteDataGridViewTextBoxColumn.DataPropertyName = "ani_cliente";
            this.aniclienteDataGridViewTextBoxColumn.HeaderText = "Animal do Cliente";
            this.aniclienteDataGridViewTextBoxColumn.Name = "aniclienteDataGridViewTextBoxColumn";
            this.aniclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aniracaDataGridViewTextBoxColumn
            // 
            this.aniracaDataGridViewTextBoxColumn.DataPropertyName = "ani_raca";
            this.aniracaDataGridViewTextBoxColumn.HeaderText = "Raca do Animal";
            this.aniracaDataGridViewTextBoxColumn.Name = "aniracaDataGridViewTextBoxColumn";
            this.aniracaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcadanimalBindingSource, "ani_idade", true));
            this.textBox1.Location = new System.Drawing.Point(684, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Idade";
            // 
            // ani_sexoComboBox
            // 
            this.ani_sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcadanimalBindingSource, "ani_sexo", true));
            this.ani_sexoComboBox.FormattingEnabled = true;
            this.ani_sexoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.ani_sexoComboBox.Location = new System.Drawing.Point(340, 257);
            this.ani_sexoComboBox.Name = "ani_sexoComboBox";
            this.ani_sexoComboBox.Size = new System.Drawing.Size(121, 21);
            this.ani_sexoComboBox.TabIndex = 61;
            this.ani_sexoComboBox.SelectedIndexChanged += new System.EventHandler(this.ani_sexoComboBox_SelectedIndexChanged);
            // 
            // ani_agressivoComboBox
            // 
            this.ani_agressivoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcadanimalBindingSource, "ani_agressivo", true));
            this.ani_agressivoComboBox.FormattingEnabled = true;
            this.ani_agressivoComboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.ani_agressivoComboBox.Location = new System.Drawing.Point(517, 259);
            this.ani_agressivoComboBox.Name = "ani_agressivoComboBox";
            this.ani_agressivoComboBox.Size = new System.Drawing.Size(121, 21);
            this.ani_agressivoComboBox.TabIndex = 62;
            // 
            // ani_alergiaComboBox
            // 
            this.ani_alergiaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcadanimalBindingSource, "ani_alergia", true));
            this.ani_alergiaComboBox.FormattingEnabled = true;
            this.ani_alergiaComboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.ani_alergiaComboBox.Location = new System.Drawing.Point(681, 310);
            this.ani_alergiaComboBox.Name = "ani_alergiaComboBox";
            this.ani_alergiaComboBox.Size = new System.Drawing.Size(121, 21);
            this.ani_alergiaComboBox.TabIndex = 63;
            this.ani_alergiaComboBox.SelectedIndexChanged += new System.EventHandler(this.ani_alergiaComboBox_SelectedIndexChanged);
            // 
            // cadClienteBindingSource
            // 
            this.cadClienteBindingSource.DataSource = typeof(sistema.dal.tb_cadcliente);
            // 
            // ani_clienteLabel1
            // 
            ani_clienteLabel1.AutoSize = true;
            ani_clienteLabel1.Location = new System.Drawing.Point(818, 261);
            ani_clienteLabel1.Name = "ani_clienteLabel1";
            ani_clienteLabel1.Size = new System.Drawing.Size(85, 13);
            ani_clienteLabel1.TabIndex = 65;
            ani_clienteLabel1.Text = "Nome do Cliente";
            // 
            // ani_clienteTextBox
            // 
            this.ani_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcadanimalBindingSource, "ani_cliente", true));
            this.ani_clienteTextBox.Location = new System.Drawing.Point(882, 258);
            this.ani_clienteTextBox.Name = "ani_clienteTextBox";
            this.ani_clienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.ani_clienteTextBox.TabIndex = 66;
            // 
            // ani_racaLabel1
            // 
            ani_racaLabel1.AutoSize = true;
            ani_racaLabel1.Location = new System.Drawing.Point(828, 316);
            ani_racaLabel1.Name = "ani_racaLabel1";
            ani_racaLabel1.Size = new System.Drawing.Size(33, 13);
            ani_racaLabel1.TabIndex = 66;
            ani_racaLabel1.Text = "Raça";
            // 
            // ani_racaTextBox
            // 
            this.ani_racaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcadanimalBindingSource, "ani_raca", true));
            this.ani_racaTextBox.Location = new System.Drawing.Point(882, 313);
            this.ani_racaTextBox.Name = "ani_racaTextBox";
            this.ani_racaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ani_racaTextBox.TabIndex = 67;
            // 
            // frmCadAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 425);
            this.Controls.Add(ani_racaLabel1);
            this.Controls.Add(this.ani_racaTextBox);
            this.Controls.Add(ani_clienteLabel1);
            this.Controls.Add(this.ani_clienteTextBox);
            this.Controls.Add(ani_alergiaLabel);
            this.Controls.Add(this.ani_alergiaComboBox);
            this.Controls.Add(ani_agressivoLabel);
            this.Controls.Add(this.ani_agressivoComboBox);
            this.Controls.Add(ani_sexoLabel);
            this.Controls.Add(this.ani_sexoComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcadcelular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.txt_cadcliente);
            this.Controls.Add(this.label6);
            this.Name = "frmCadAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadAnimal";
            this.Load += new System.EventHandler(this.frmCadAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbcadanimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcadcelular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.TextBox txt_cadcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource tbcadanimalBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn anicodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aninomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anisexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniagressivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anicorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anialergiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniracaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox ani_sexoComboBox;
        private System.Windows.Forms.ComboBox ani_agressivoComboBox;
        private System.Windows.Forms.ComboBox ani_alergiaComboBox;
        private System.Windows.Forms.BindingSource cadClienteBindingSource;
        private System.Windows.Forms.TextBox ani_clienteTextBox;
        private System.Windows.Forms.TextBox ani_racaTextBox;
    }
}