namespace WinFormsAguas
{
    partial class FormCadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadCliente));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lblLogo = new Label();
            label2 = new Label();
            lblMorada = new Label();
            lblNome = new Label();
            lblNif = new Label();
            lblContacto = new Label();
            lblEmail = new Label();
            txtNomeCliente = new TextBox();
            txtMorada = new TextBox();
            txtContacto = new TextBox();
            txtNif = new TextBox();
            txtEmail = new TextBox();
            btnRegistarCliente = new Button();
            btnCancelar = new Button();
            btnEditarCliente = new Button();
            btnApagarCliente = new Button();
            DataGridViewClientes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 48, 91);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblLogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1691, 222);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(196, 20);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(163, 173);
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
            lblLogo.Location = new Point(430, 105);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(524, 28);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "CONECTA VOCÊ AO QUE É ESSENCIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(726, 283);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(283, 41);
            label2.TabIndex = 3;
            label2.Text = "Cadastro Cliente";
            // 
            // lblMorada
            // 
            lblMorada.AutoSize = true;
            lblMorada.Font = new Font("Arial", 14F);
            lblMorada.Location = new Point(463, 447);
            lblMorada.Margin = new Padding(4, 0, 4, 0);
            lblMorada.Name = "lblMorada";
            lblMorada.Size = new Size(107, 32);
            lblMorada.TabIndex = 4;
            lblMorada.Text = "Morada";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 14F);
            lblNome.ForeColor = Color.Black;
            lblNome.Location = new Point(463, 345);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(88, 32);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblNif
            // 
            lblNif.AutoSize = true;
            lblNif.Font = new Font("Arial", 14F);
            lblNif.Location = new Point(463, 653);
            lblNif.Margin = new Padding(4, 0, 4, 0);
            lblNif.Name = "lblNif";
            lblNif.Size = new Size(311, 32);
            lblNif.TabIndex = 6;
            lblNif.Text = "Número de Contribuinte";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Arial", 14F);
            lblContacto.Location = new Point(463, 545);
            lblContacto.Margin = new Padding(4, 0, 4, 0);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(125, 32);
            lblContacto.TabIndex = 7;
            lblContacto.Text = "Contacto";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 14F);
            lblEmail.Location = new Point(463, 750);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(84, 32);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Arial", 14F);
            txtNomeCliente.Location = new Point(463, 387);
            txtNomeCliente.Margin = new Padding(4, 5, 4, 5);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(800, 40);
            txtNomeCliente.TabIndex = 9;
            // 
            // txtMorada
            // 
            txtMorada.Font = new Font("Arial", 14F);
            txtMorada.Location = new Point(463, 490);
            txtMorada.Margin = new Padding(4, 5, 4, 5);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(800, 40);
            txtMorada.TabIndex = 10;
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Arial", 14F);
            txtContacto.Location = new Point(463, 587);
            txtContacto.Margin = new Padding(4, 5, 4, 5);
            txtContacto.MaxLength = 9;
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(800, 40);
            txtContacto.TabIndex = 11;
            // 
            // txtNif
            // 
            txtNif.Font = new Font("Arial", 14F);
            txtNif.Location = new Point(463, 697);
            txtNif.Margin = new Padding(4, 5, 4, 5);
            txtNif.MaxLength = 9;
            txtNif.Name = "txtNif";
            txtNif.Size = new Size(800, 40);
            txtNif.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 14F);
            txtEmail.Location = new Point(463, 790);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(800, 40);
            txtEmail.TabIndex = 13;
            // 
            // btnRegistarCliente
            // 
            btnRegistarCliente.BackColor = Color.FromArgb(24, 104, 153);
            btnRegistarCliente.Font = new Font("Arial", 14F);
            btnRegistarCliente.ForeColor = Color.White;
            btnRegistarCliente.Location = new Point(1141, 863);
            btnRegistarCliente.Margin = new Padding(4, 5, 4, 5);
            btnRegistarCliente.Name = "btnRegistarCliente";
            btnRegistarCliente.Size = new Size(186, 83);
            btnRegistarCliente.TabIndex = 14;
            btnRegistarCliente.Text = "Registar";
            btnRegistarCliente.UseVisualStyleBackColor = false;
            btnRegistarCliente.Click += btnRegistarCliente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(24, 104, 153);
            btnCancelar.Font = new Font("Arial", 14F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(909, 863);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(186, 83);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Limpar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.FromArgb(24, 104, 153);
            btnEditarCliente.Font = new Font("Arial", 14F);
            btnEditarCliente.ForeColor = Color.White;
            btnEditarCliente.Location = new Point(1401, 987);
            btnEditarCliente.Margin = new Padding(4, 5, 4, 5);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(197, 113);
            btnEditarCliente.TabIndex = 18;
            btnEditarCliente.Text = "Editar Cliente";
            btnEditarCliente.UseVisualStyleBackColor = false;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // btnApagarCliente
            // 
            btnApagarCliente.BackColor = Color.FromArgb(24, 104, 153);
            btnApagarCliente.Font = new Font("Arial", 14F);
            btnApagarCliente.ForeColor = Color.White;
            btnApagarCliente.Location = new Point(1401, 1110);
            btnApagarCliente.Margin = new Padding(4, 5, 4, 5);
            btnApagarCliente.Name = "btnApagarCliente";
            btnApagarCliente.Size = new Size(197, 113);
            btnApagarCliente.TabIndex = 19;
            btnApagarCliente.Text = "Apagar Cliente";
            btnApagarCliente.UseVisualStyleBackColor = false;
            btnApagarCliente.Click += btnApagarCliente_Click;
            // 
            // DataGridViewClientes
            // 
            DataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewClientes.BackgroundColor = Color.White;
            DataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewClientes.Location = new Point(352, 987);
            DataGridViewClientes.Margin = new Padding(4, 5, 4, 5);
            DataGridViewClientes.MultiSelect = false;
            DataGridViewClientes.Name = "DataGridViewClientes";
            DataGridViewClientes.ReadOnly = true;
            DataGridViewClientes.RowHeadersWidth = 62;
            DataGridViewClientes.Size = new Size(1007, 228);
            DataGridViewClientes.TabIndex = 20;
            DataGridViewClientes.CellContentClick += DataGridViewClientes_CellContentClick;
            // 
            // FormCadCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1691, 1283);
            Controls.Add(DataGridViewClientes);
            Controls.Add(btnApagarCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistarCliente);
            Controls.Add(txtEmail);
            Controls.Add(txtNif);
            Controls.Add(txtContacto);
            Controls.Add(txtMorada);
            Controls.Add(txtNomeCliente);
            Controls.Add(lblEmail);
            Controls.Add(lblContacto);
            Controls.Add(lblNif);
            Controls.Add(lblNome);
            Controls.Add(lblMorada);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCadCliente";
            Text = "FormCadCliente";
            Load += FormCadCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lblLogo;
        private Label label2;
        private Label lblMorada;
        private Label lblNome;
        private Label lblNif;
        private Label lblContacto;
        private Label lblEmail;
        private TextBox txtNomeCliente;
        private TextBox txtMorada;
        private TextBox txtContacto;
        private TextBox txtNif;
        private TextBox txtEmail;
        private Button btnRegistarCliente;
        private Button btnCancelar;
        private Button btnEditarCliente;
        private Button btnApagarCliente;
        private DataGridView DataGridViewClientes;
    }
}