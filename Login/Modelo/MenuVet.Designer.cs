
namespace Login.Modelo
{
    partial class MenuVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVet));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.PanelEsquerda = new System.Windows.Forms.Panel();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnAgendamentos = new System.Windows.Forms.Button();
            this.BtnServicos = new System.Windows.Forms.Button();
            this.BtnAnimais = new System.Windows.Forms.Button();
            this.BtnRacas = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            this.PanelEsquerda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelTop.Controls.Add(this.BtnMin);
            this.PanelTop.Controls.Add(this.BtnSair);
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1105, 58);
            this.PanelTop.TabIndex = 1;
            this.PanelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnMin
            // 
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Location = new System.Drawing.Point(992, 12);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(40, 40);
            this.BtnMin.TabIndex = 1;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Location = new System.Drawing.Point(1053, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(40, 40);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelCentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelCentral.BackgroundImage")));
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(0, 0);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1105, 462);
            this.PanelCentral.TabIndex = 2;
            this.PanelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentral_Paint);
            // 
            // PanelEsquerda
            // 
            this.PanelEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelEsquerda.Controls.Add(this.panel1);
            this.PanelEsquerda.Controls.Add(this.button1);
            this.PanelEsquerda.Controls.Add(this.BtnInicio);
            this.PanelEsquerda.Controls.Add(this.BtnAgendamentos);
            this.PanelEsquerda.Controls.Add(this.BtnServicos);
            this.PanelEsquerda.Controls.Add(this.BtnAnimais);
            this.PanelEsquerda.Controls.Add(this.BtnRacas);
            this.PanelEsquerda.Controls.Add(this.BtnClientes);
            this.PanelEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelEsquerda.Location = new System.Drawing.Point(0, 0);
            this.PanelEsquerda.Name = "PanelEsquerda";
            this.PanelEsquerda.Size = new System.Drawing.Size(182, 462);
            this.PanelEsquerda.TabIndex = 3;
            this.PanelEsquerda.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnInicio
            // 
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInicio.Location = new System.Drawing.Point(30, 20);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(125, 44);
            this.BtnInicio.TabIndex = 9;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnAgendamentos
            // 
            this.BtnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgendamentos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgendamentos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAgendamentos.Location = new System.Drawing.Point(30, 331);
            this.BtnAgendamentos.Name = "BtnAgendamentos";
            this.BtnAgendamentos.Size = new System.Drawing.Size(125, 44);
            this.BtnAgendamentos.TabIndex = 8;
            this.BtnAgendamentos.Text = "Agendamentos";
            this.BtnAgendamentos.UseVisualStyleBackColor = true;
            this.BtnAgendamentos.Click += new System.EventHandler(this.BtnAgendamentos_Click);
            // 
            // BtnServicos
            // 
            this.BtnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServicos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServicos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnServicos.Location = new System.Drawing.Point(30, 270);
            this.BtnServicos.Name = "BtnServicos";
            this.BtnServicos.Size = new System.Drawing.Size(125, 44);
            this.BtnServicos.TabIndex = 7;
            this.BtnServicos.Text = "Serviços";
            this.BtnServicos.UseVisualStyleBackColor = true;
            this.BtnServicos.Click += new System.EventHandler(this.BtnServicos_Click);
            // 
            // BtnAnimais
            // 
            this.BtnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnimais.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnimais.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAnimais.Location = new System.Drawing.Point(30, 211);
            this.BtnAnimais.Name = "BtnAnimais";
            this.BtnAnimais.Size = new System.Drawing.Size(125, 44);
            this.BtnAnimais.TabIndex = 6;
            this.BtnAnimais.Text = "Animais";
            this.BtnAnimais.UseVisualStyleBackColor = true;
            this.BtnAnimais.Click += new System.EventHandler(this.BtnAnimais_Click);
            // 
            // BtnRacas
            // 
            this.BtnRacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRacas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRacas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnRacas.Location = new System.Drawing.Point(30, 149);
            this.BtnRacas.Name = "BtnRacas";
            this.BtnRacas.Size = new System.Drawing.Size(125, 44);
            this.BtnRacas.TabIndex = 5;
            this.BtnRacas.Text = "Raças";
            this.BtnRacas.UseVisualStyleBackColor = true;
            this.BtnRacas.Click += new System.EventHandler(this.BtnRacas_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClientes.Location = new System.Drawing.Point(30, 86);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(125, 44);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Location = new System.Drawing.Point(992, 12);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(40, 40);
            this.BtnMax.TabIndex = 1;
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(30, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Em andamento ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 462);
            this.panel1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(30, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "Inicio";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(30, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "Agendamentos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(30, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 44);
            this.button5.TabIndex = 7;
            this.button5.Text = "Serviços";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(30, 211);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 44);
            this.button6.TabIndex = 6;
            this.button6.Text = "Animais";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(30, 149);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 44);
            this.button7.TabIndex = 5;
            this.button7.Text = "Raças";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(30, 86);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 44);
            this.button8.TabIndex = 0;
            this.button8.Text = "Clientes";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // MenuVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 462);
            this.Controls.Add(this.PanelEsquerda);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuVet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelTop.ResumeLayout(false);
            this.PanelEsquerda.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Panel PanelEsquerda;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnAgendamentos;
        private System.Windows.Forms.Button BtnServicos;
        private System.Windows.Forms.Button BtnAnimais;
        private System.Windows.Forms.Button BtnRacas;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
    }
}