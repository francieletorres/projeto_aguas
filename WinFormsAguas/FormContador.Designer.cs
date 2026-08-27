namespace WinFormsAguas
{
    partial class FormContador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContador));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lblLogo = new Label();
            lblInstalacaoContador = new Label();
            dateTimePickerContador = new DateTimePicker();
            btnRegistarContador = new Button();
            btnCancelar = new Button();
            lblAdicionarContador = new Label();
            ComboBoxClientes = new ComboBox();
            btnApagarContador = new Button();
            btnEditarContador = new Button();
            lblSelecionarCliente = new Label();
            dataGridViewContador = new DataGridView();
            checkBoxEstadoContador = new CheckBox();
            lblEstadoContador = new Label();
            lblListaContadores = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContador).BeginInit();
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
            panel1.Size = new Size(1201, 139);
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
            // lblInstalacaoContador
            // 
            lblInstalacaoContador.AutoSize = true;
            lblInstalacaoContador.Font = new Font("Arial", 14F);
            lblInstalacaoContador.Location = new Point(307, 340);
            lblInstalacaoContador.Name = "lblInstalacaoContador";
            lblInstalacaoContador.Size = new Size(166, 22);
            lblInstalacaoContador.TabIndex = 8;
            lblInstalacaoContador.Text = "Data da Instalação";
            // 
            // dateTimePickerContador
            // 
            dateTimePickerContador.CalendarFont = new Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerContador.Enabled = false;
            dateTimePickerContador.Font = new Font("Arial", 14F);
            dateTimePickerContador.Format = DateTimePickerFormat.Short;
            dateTimePickerContador.Location = new Point(494, 333);
            dateTimePickerContador.Margin = new Padding(2);
            dateTimePickerContador.Name = "dateTimePickerContador";
            dateTimePickerContador.Size = new Size(136, 29);
            dateTimePickerContador.TabIndex = 9;
            // 
            // btnRegistarContador
            // 
            btnRegistarContador.BackColor = Color.FromArgb(24, 104, 153);
            btnRegistarContador.Font = new Font("Arial", 14F);
            btnRegistarContador.ForeColor = Color.White;
            btnRegistarContador.Location = new Point(795, 445);
            btnRegistarContador.Name = "btnRegistarContador";
            btnRegistarContador.Size = new Size(130, 50);
            btnRegistarContador.TabIndex = 15;
            btnRegistarContador.Text = "Registar";
            btnRegistarContador.UseVisualStyleBackColor = false;
            btnRegistarContador.Click += btnRegistarContador_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(24, 104, 153);
            btnCancelar.Font = new Font("Arial", 14F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(635, 445);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 50);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Limpar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblAdicionarContador
            // 
            lblAdicionarContador.AutoSize = true;
            lblAdicionarContador.Font = new Font("Arial", 18F);
            lblAdicionarContador.Location = new Point(494, 183);
            lblAdicionarContador.Name = "lblAdicionarContador";
            lblAdicionarContador.Size = new Size(215, 27);
            lblAdicionarContador.TabIndex = 17;
            lblAdicionarContador.Text = "Cadastro Contador";
            // 
            // ComboBoxClientes
            // 
            ComboBoxClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxClientes.Font = new Font("Arial", 14F);
            ComboBoxClientes.FormattingEnabled = true;
            ComboBoxClientes.Location = new Point(307, 288);
            ComboBoxClientes.Name = "ComboBoxClientes";
            ComboBoxClientes.Size = new Size(604, 30);
            ComboBoxClientes.TabIndex = 18;
            ComboBoxClientes.SelectedIndexChanged += ComboBoxClientes_SelectedIndexChanged;
            // 
            // btnApagarContador
            // 
            btnApagarContador.BackColor = Color.FromArgb(24, 104, 153);
            btnApagarContador.Font = new Font("Arial", 14F);
            btnApagarContador.ForeColor = Color.White;
            btnApagarContador.Location = new Point(981, 629);
            btnApagarContador.Name = "btnApagarContador";
            btnApagarContador.Size = new Size(138, 68);
            btnApagarContador.TabIndex = 21;
            btnApagarContador.Text = "Apagar Contador";
            btnApagarContador.UseVisualStyleBackColor = false;
            btnApagarContador.Click += btnApagarContador_Click;
            // 
            // btnEditarContador
            // 
            btnEditarContador.BackColor = Color.FromArgb(24, 104, 153);
            btnEditarContador.Font = new Font("Arial", 14F);
            btnEditarContador.ForeColor = Color.White;
            btnEditarContador.Location = new Point(981, 545);
            btnEditarContador.Name = "btnEditarContador";
            btnEditarContador.Size = new Size(138, 68);
            btnEditarContador.TabIndex = 20;
            btnEditarContador.Text = "Editar Contador";
            btnEditarContador.UseVisualStyleBackColor = false;
            btnEditarContador.Click += btnEditarContador_Click;
            // 
            // lblSelecionarCliente
            // 
            lblSelecionarCliente.AutoSize = true;
            lblSelecionarCliente.Font = new Font("Arial", 14F);
            lblSelecionarCliente.Location = new Point(307, 258);
            lblSelecionarCliente.Name = "lblSelecionarCliente";
            lblSelecionarCliente.Size = new Size(164, 22);
            lblSelecionarCliente.TabIndex = 23;
            lblSelecionarCliente.Text = "Selecionar Cliente";
            // 
            // dataGridViewContador
            // 
            dataGridViewContador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewContador.BackgroundColor = Color.White;
            dataGridViewContador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContador.Location = new Point(235, 544);
            dataGridViewContador.MultiSelect = false;
            dataGridViewContador.Name = "dataGridViewContador";
            dataGridViewContador.ReadOnly = true;
            dataGridViewContador.Size = new Size(738, 153);
            dataGridViewContador.TabIndex = 24;
            dataGridViewContador.CellContentClick += dataGridViewContador_CellContentClick;
            // 
            // checkBoxEstadoContador
            // 
            checkBoxEstadoContador.AutoSize = true;
            checkBoxEstadoContador.Font = new Font("Arial", 14F);
            checkBoxEstadoContador.Location = new Point(494, 380);
            checkBoxEstadoContador.Name = "checkBoxEstadoContador";
            checkBoxEstadoContador.Size = new Size(71, 26);
            checkBoxEstadoContador.TabIndex = 25;
            checkBoxEstadoContador.Text = "Ativo";
            checkBoxEstadoContador.UseVisualStyleBackColor = true;
            // 
            // lblEstadoContador
            // 
            lblEstadoContador.AutoSize = true;
            lblEstadoContador.Font = new Font("Arial", 14F);
            lblEstadoContador.Location = new Point(307, 384);
            lblEstadoContador.Name = "lblEstadoContador";
            lblEstadoContador.Size = new Size(145, 22);
            lblEstadoContador.TabIndex = 26;
            lblEstadoContador.Text = "Ativar  Contador";
            // 
            // lblListaContadores
            // 
            lblListaContadores.AutoSize = true;
            lblListaContadores.Font = new Font("Arial", 14F);
            lblListaContadores.Location = new Point(241, 512);
            lblListaContadores.Name = "lblListaContadores";
            lblListaContadores.Size = new Size(181, 22);
            lblListaContadores.TabIndex = 27;
            lblListaContadores.Text = "Lista de Contadores";
            // 
            // FormContador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1201, 769);
            Controls.Add(lblListaContadores);
            Controls.Add(lblEstadoContador);
            Controls.Add(checkBoxEstadoContador);
            Controls.Add(dataGridViewContador);
            Controls.Add(lblSelecionarCliente);
            Controls.Add(btnApagarContador);
            Controls.Add(btnEditarContador);
            Controls.Add(ComboBoxClientes);
            Controls.Add(lblAdicionarContador);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistarContador);
            Controls.Add(dateTimePickerContador);
            Controls.Add(lblInstalacaoContador);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FormContador";
            Text = "FormContador";
            Load += FormContador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lblLogo;
        private Label lblInstalacaoContador;
        private DateTimePicker dateTimePickerContador;
        private Button btnRegistarContador;
        private Button btnCancelar;
        private Label lblAdicionarContador;
        private ComboBox ComboBoxClientes;
        private Button btnApagarContador;
        private Button btnEditarContador;
        private Label lblSelecionarCliente;
        private DataGridView dataGridViewContador;
        private CheckBox checkBoxEstadoContador;
        private Label lblEstadoContador;
        private Label lblListaContadores;
    }
}