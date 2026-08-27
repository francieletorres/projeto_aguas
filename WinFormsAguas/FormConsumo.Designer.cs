namespace WinFormsAguas
{
    partial class FormConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsumo));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lblLogo = new Label();
            label2 = new Label();
            lblSelecionarCliente = new Label();
            ComboBoxClientes = new ComboBox();
            label1 = new Label();
            ComboBoxContadores = new ComboBox();
            DataGridViewListaConsumos = new DataGridView();
            btnCancelar = new Button();
            btnRegistarLeitura = new Button();
            lblListaConsumos = new Label();
            btnApagarConsumo = new Button();
            btnEditarConsumo = new Button();
            btnGerarFatura = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaConsumos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 48, 91);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblLogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 139);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(91, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(220, 65);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(364, 20);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "CONECTA VOCÊ AO QUE É ESSENCIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(432, 158);
            label2.Name = "label2";
            label2.Size = new Size(284, 27);
            label2.TabIndex = 8;
            label2.Text = "Comunicação de Leituras";
            // 
            // lblSelecionarCliente
            // 
            lblSelecionarCliente.AutoSize = true;
            lblSelecionarCliente.Font = new Font("Arial", 14F);
            lblSelecionarCliente.Location = new Point(303, 217);
            lblSelecionarCliente.Name = "lblSelecionarCliente";
            lblSelecionarCliente.Size = new Size(164, 22);
            lblSelecionarCliente.TabIndex = 26;
            lblSelecionarCliente.Text = "Selecionar Cliente";
            // 
            // ComboBoxClientes
            // 
            ComboBoxClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxClientes.Font = new Font("Arial", 14F);
            ComboBoxClientes.FormattingEnabled = true;
            ComboBoxClientes.Location = new Point(303, 245);
            ComboBoxClientes.Name = "ComboBoxClientes";
            ComboBoxClientes.Size = new Size(604, 30);
            ComboBoxClientes.TabIndex = 25;
            ComboBoxClientes.SelectedIndexChanged += ComboBoxClientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F);
            label1.Location = new Point(303, 280);
            label1.Name = "label1";
            label1.Size = new Size(183, 22);
            label1.TabIndex = 28;
            label1.Text = "Selecionar Contador";
            // 
            // ComboBoxContadores
            // 
            ComboBoxContadores.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxContadores.Font = new Font("Arial", 14F);
            ComboBoxContadores.FormattingEnabled = true;
            ComboBoxContadores.Location = new Point(303, 308);
            ComboBoxContadores.Name = "ComboBoxContadores";
            ComboBoxContadores.Size = new Size(604, 30);
            ComboBoxContadores.TabIndex = 27;
            ComboBoxContadores.SelectedIndexChanged += ComboBoxContadores_SelectedIndexChanged;
            // 
            // DataGridViewListaConsumos
            // 
            DataGridViewListaConsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListaConsumos.BackgroundColor = Color.White;
            DataGridViewListaConsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewListaConsumos.Location = new Point(287, 492);
            DataGridViewListaConsumos.MultiSelect = false;
            DataGridViewListaConsumos.Name = "DataGridViewListaConsumos";
            DataGridViewListaConsumos.ReadOnly = true;
            DataGridViewListaConsumos.Size = new Size(611, 144);
            DataGridViewListaConsumos.TabIndex = 29;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(24, 104, 153);
            btnCancelar.Font = new Font("Arial", 14F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(341, 372);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(243, 50);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Limpar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistarLeitura
            // 
            btnRegistarLeitura.BackColor = Color.FromArgb(24, 104, 153);
            btnRegistarLeitura.Font = new Font("Arial", 14F);
            btnRegistarLeitura.ForeColor = Color.White;
            btnRegistarLeitura.Location = new Point(655, 372);
            btnRegistarLeitura.Name = "btnRegistarLeitura";
            btnRegistarLeitura.Size = new Size(243, 50);
            btnRegistarLeitura.TabIndex = 30;
            btnRegistarLeitura.Text = "Inserir Leitura";
            btnRegistarLeitura.UseVisualStyleBackColor = false;
            btnRegistarLeitura.Click += btnRegistarLeitura_Click;
            // 
            // lblListaConsumos
            // 
            lblListaConsumos.AutoSize = true;
            lblListaConsumos.Font = new Font("Arial", 14F);
            lblListaConsumos.Location = new Point(294, 457);
            lblListaConsumos.Name = "lblListaConsumos";
            lblListaConsumos.Size = new Size(174, 22);
            lblListaConsumos.TabIndex = 39;
            lblListaConsumos.Text = "Lista de Consumos";
            // 
            // btnApagarConsumo
            // 
            btnApagarConsumo.BackColor = Color.FromArgb(24, 104, 153);
            btnApagarConsumo.Font = new Font("Arial", 14F);
            btnApagarConsumo.ForeColor = Color.White;
            btnApagarConsumo.Location = new Point(341, 668);
            btnApagarConsumo.Name = "btnApagarConsumo";
            btnApagarConsumo.Size = new Size(243, 50);
            btnApagarConsumo.TabIndex = 41;
            btnApagarConsumo.Text = "Apagar Consumo";
            btnApagarConsumo.UseVisualStyleBackColor = false;
            btnApagarConsumo.Click += btnApagarConsumo_Click;
            // 
            // btnEditarConsumo
            // 
            btnEditarConsumo.BackColor = Color.FromArgb(24, 104, 153);
            btnEditarConsumo.Font = new Font("Arial", 14F);
            btnEditarConsumo.ForeColor = Color.White;
            btnEditarConsumo.Location = new Point(655, 668);
            btnEditarConsumo.Name = "btnEditarConsumo";
            btnEditarConsumo.Size = new Size(243, 50);
            btnEditarConsumo.TabIndex = 40;
            btnEditarConsumo.Text = "Editar Consumo";
            btnEditarConsumo.UseVisualStyleBackColor = false;
            btnEditarConsumo.Click += btnEditarConsumo_Click;
            // 
            // btnGerarFatura
            // 
            btnGerarFatura.BackColor = Color.FromArgb(24, 104, 153);
            btnGerarFatura.Font = new Font("Arial", 14F);
            btnGerarFatura.ForeColor = Color.White;
            btnGerarFatura.Location = new Point(955, 517);
            btnGerarFatura.Name = "btnGerarFatura";
            btnGerarFatura.Size = new Size(157, 95);
            btnGerarFatura.TabIndex = 42;
            btnGerarFatura.Text = "Gerar Fatura";
            btnGerarFatura.UseVisualStyleBackColor = false;
            btnGerarFatura.Click += btnGerarFatura_Click;
            // 
            // FormConsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1163, 766);
            Controls.Add(btnGerarFatura);
            Controls.Add(btnApagarConsumo);
            Controls.Add(btnEditarConsumo);
            Controls.Add(lblListaConsumos);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistarLeitura);
            Controls.Add(DataGridViewListaConsumos);
            Controls.Add(label1);
            Controls.Add(ComboBoxContadores);
            Controls.Add(lblSelecionarCliente);
            Controls.Add(ComboBoxClientes);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormConsumo";
            Text = "FormConsumo";
            Load += FormConsumo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaConsumos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lblLogo;
        private Label label2;
        private Label lblSelecionarCliente;
        private ComboBox ComboBoxClientes;
        private Label label1;
        private ComboBox ComboBoxContadores;
        private DataGridView DataGridViewListaConsumos;
        private Button btnCancelar;
        private Button btnRegistarLeitura;
        private Label lblListaConsumos;
        private Button btnApagarConsumo;
        private Button btnEditarConsumo;
        private Button btnGerarFatura;
    }
}