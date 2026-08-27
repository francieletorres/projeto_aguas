namespace WinFormsAguas
{
    partial class FormFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFatura));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lblLogo = new Label();
            lblFaturacao = new Label();
            lblCliente = new Label();
            lblPeriodo = new Label();
            btnAbrirFatura = new Button();
            btnCancelar = new Button();
            dataGridViewListaFaturas = new DataGridView();
            lblEstadoPagamento = new Label();
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFim = new DateTimePicker();
            label1 = new Label();
            btnPesquisar = new Button();
            txtCliente = new TextBox();
            comboBoxEstado = new ComboBox();
            lblListaConsumos = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaFaturas).BeginInit();
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
            panel1.Size = new Size(1212, 139);
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
            // lblFaturacao
            // 
            lblFaturacao.AutoSize = true;
            lblFaturacao.Font = new Font("Arial", 18F);
            lblFaturacao.Location = new Point(538, 158);
            lblFaturacao.Name = "lblFaturacao";
            lblFaturacao.Size = new Size(94, 27);
            lblFaturacao.TabIndex = 7;
            lblFaturacao.Text = "Faturas";
            lblFaturacao.Click += lblFaturacao_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial", 14F);
            lblCliente.Location = new Point(84, 226);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(74, 22);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "Cliente:";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new Font("Arial", 14F);
            lblPeriodo.Location = new Point(84, 271);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(326, 22);
            lblPeriodo.TabIndex = 11;
            lblPeriodo.Text = "Período  de Emissão das Faturas de:";
            // 
            // btnAbrirFatura
            // 
            btnAbrirFatura.BackColor = Color.FromArgb(24, 104, 153);
            btnAbrirFatura.Font = new Font("Arial", 15.75F);
            btnAbrirFatura.ForeColor = Color.White;
            btnAbrirFatura.Location = new Point(956, 474);
            btnAbrirFatura.Name = "btnAbrirFatura";
            btnAbrirFatura.Size = new Size(193, 50);
            btnAbrirFatura.TabIndex = 16;
            btnAbrirFatura.Text = "Abrir Fatura";
            btnAbrirFatura.UseVisualStyleBackColor = false;
            btnAbrirFatura.Click += btnAbrirFatura_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(24, 104, 153);
            btnCancelar.Font = new Font("Arial", 15.75F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(956, 556);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(193, 50);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dataGridViewListaFaturas
            // 
            dataGridViewListaFaturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListaFaturas.BackgroundColor = Color.White;
            dataGridViewListaFaturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaFaturas.Location = new Point(91, 433);
            dataGridViewListaFaturas.Name = "dataGridViewListaFaturas";
            dataGridViewListaFaturas.ReadOnly = true;
            dataGridViewListaFaturas.Size = new Size(849, 250);
            dataGridViewListaFaturas.TabIndex = 18;
            // 
            // lblEstadoPagamento
            // 
            lblEstadoPagamento.AutoSize = true;
            lblEstadoPagamento.Font = new Font("Arial", 14F);
            lblEstadoPagamento.Location = new Point(84, 320);
            lblEstadoPagamento.Name = "lblEstadoPagamento";
            lblEstadoPagamento.Size = new Size(177, 22);
            lblEstadoPagamento.TabIndex = 19;
            lblEstadoPagamento.Text = "Estado Pagamento:";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.CalendarFont = new Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerInicio.Font = new Font("Arial", 14F);
            dateTimePickerInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerInicio.Location = new Point(425, 266);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(135, 29);
            dateTimePickerInicio.TabIndex = 36;
            dateTimePickerInicio.ValueChanged += dateTimePickerInicio_ValueChanged;
            // 
            // dateTimePickerFim
            // 
            dateTimePickerFim.CalendarFont = new Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerFim.CustomFormat = "";
            dateTimePickerFim.Font = new Font("Arial", 14F);
            dateTimePickerFim.Format = DateTimePickerFormat.Short;
            dateTimePickerFim.Location = new Point(642, 266);
            dateTimePickerFim.Name = "dateTimePickerFim";
            dateTimePickerFim.Size = new Size(135, 29);
            dateTimePickerFim.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F);
            label1.Location = new Point(586, 271);
            label1.Name = "label1";
            label1.Size = new Size(46, 22);
            label1.TabIndex = 38;
            label1.Text = "até: ";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(24, 104, 153);
            btnPesquisar.Font = new Font("Arial", 15.75F);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(736, 355);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(185, 50);
            btnPesquisar.TabIndex = 39;
            btnPesquisar.Text = "Pesquisar:";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Arial", 14F);
            txtCliente.Location = new Point(180, 229);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(615, 29);
            txtCliente.TabIndex = 40;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.Font = new Font("Arial", 14F);
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Todas as Faturas", "Faturas Pagas", "Faturas em Dívida" });
            comboBoxEstado.Location = new Point(293, 317);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(237, 30);
            comboBoxEstado.TabIndex = 41;
            comboBoxEstado.SelectedIndexChanged += comboBoxEstado_SelectedIndexChanged;
            // 
            // lblListaConsumos
            // 
            lblListaConsumos.AutoSize = true;
            lblListaConsumos.Font = new Font("Arial", 14F);
            lblListaConsumos.Location = new Point(91, 393);
            lblListaConsumos.Name = "lblListaConsumos";
            lblListaConsumos.Size = new Size(145, 22);
            lblListaConsumos.TabIndex = 42;
            lblListaConsumos.Text = "Lista de Faturas";
            // 
            // FormFatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1212, 750);
            Controls.Add(lblListaConsumos);
            Controls.Add(comboBoxEstado);
            Controls.Add(txtCliente);
            Controls.Add(btnPesquisar);
            Controls.Add(lblFaturacao);
            Controls.Add(label1);
            Controls.Add(dateTimePickerFim);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(lblEstadoPagamento);
            Controls.Add(dataGridViewListaFaturas);
            Controls.Add(btnCancelar);
            Controls.Add(btnAbrirFatura);
            Controls.Add(lblPeriodo);
            Controls.Add(lblCliente);
            Controls.Add(panel1);
            Name = "FormFatura";
            Text = "FormFatura";
            Load += FormFatura_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaFaturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lblLogo;
        private Label lblCliente;
        private Label lblFaturacao;
        private Label lblPeriodo;
        private Button btnAbrirFatura;
        private Button btnCancelar;
        private DataGridView dataGridViewListaFaturas;
        private Label lblEstadoPagamento;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFim;
        private Label label1;
        private Button btnPesquisar;
        private TextBox txtCliente;
        private ComboBox comboBoxEstado;
        private Label lblListaConsumos;
    }
}