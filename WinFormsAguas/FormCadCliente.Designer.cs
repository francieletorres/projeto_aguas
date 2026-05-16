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
            btnCriarContador = new Button();
            btnApagarCliente = new Button();
            listBoxClientes = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblLogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 139);
            panel1.TabIndex = 1;
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
            lblLogo.ForeColor = SystemColors.HotTrack;
            lblLogo.Location = new Point(220, 65);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(364, 20);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "CONECTA VOCÊ AO QUE É ESSENCIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(507, 162);
            label2.Name = "label2";
            label2.Size = new Size(200, 28);
            label2.TabIndex = 3;
            label2.Text = "Cadastro Cliente";
            // 
            // lblMorada
            // 
            lblMorada.AutoSize = true;
            lblMorada.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMorada.Location = new Point(323, 260);
            lblMorada.Name = "lblMorada";
            lblMorada.Size = new Size(88, 25);
            lblMorada.TabIndex = 4;
            lblMorada.Text = "Morada";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(323, 199);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 25);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblNif
            // 
            lblNif.AutoSize = true;
            lblNif.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNif.Location = new Point(323, 384);
            lblNif.Name = "lblNif";
            lblNif.Size = new Size(254, 25);
            lblNif.TabIndex = 6;
            lblNif.Text = "Número de Contribuinte";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(323, 319);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(99, 25);
            lblContacto.TabIndex = 7;
            lblContacto.Text = "Contacto";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(323, 442);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 25);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(323, 224);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(561, 23);
            txtNomeCliente.TabIndex = 9;
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(323, 286);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(561, 23);
            txtMorada.TabIndex = 10;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(323, 344);
            txtContacto.MaxLength = 9;
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(561, 23);
            txtContacto.TabIndex = 11;
            // 
            // txtNif
            // 
            txtNif.Location = new Point(323, 410);
            txtNif.MaxLength = 9;
            txtNif.Name = "txtNif";
            txtNif.Size = new Size(561, 23);
            txtNif.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(323, 466);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(561, 23);
            txtEmail.TabIndex = 13;
            // 
            // btnRegistarCliente
            // 
            btnRegistarCliente.BackColor = SystemColors.Control;
            btnRegistarCliente.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistarCliente.Location = new Point(752, 510);
            btnRegistarCliente.Name = "btnRegistarCliente";
            btnRegistarCliente.Size = new Size(130, 50);
            btnRegistarCliente.TabIndex = 14;
            btnRegistarCliente.Text = "Registar";
            btnRegistarCliente.UseVisualStyleBackColor = false;
            btnRegistarCliente.Click += btnRegistarCliente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Control;
            btnCancelar.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(581, 510);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 50);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCriarContador
            // 
            btnCriarContador.BackColor = SystemColors.Control;
            btnCriarContador.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCriarContador.Location = new Point(981, 580);
            btnCriarContador.Name = "btnCriarContador";
            btnCriarContador.Size = new Size(138, 68);
            btnCriarContador.TabIndex = 18;
            btnCriarContador.Text = "Criar Contador";
            btnCriarContador.UseVisualStyleBackColor = false;
            // 
            // btnApagarCliente
            // 
            btnApagarCliente.BackColor = SystemColors.Control;
            btnApagarCliente.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApagarCliente.Location = new Point(981, 666);
            btnApagarCliente.Name = "btnApagarCliente";
            btnApagarCliente.Size = new Size(138, 68);
            btnApagarCliente.TabIndex = 19;
            btnApagarCliente.Text = "Apagar Cliente";
            btnApagarCliente.UseVisualStyleBackColor = false;
            // 
            // listBoxClientes
            // 
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 15;
            listBoxClientes.Location = new Point(76, 579);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(875, 154);
            listBoxClientes.TabIndex = 20;
            // 
            // FormCadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 760);
            Controls.Add(listBoxClientes);
            Controls.Add(btnApagarCliente);
            Controls.Add(btnCriarContador);
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
            Name = "FormCadCliente";
            Text = "FormCadCliente";
            Load += FormCadCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button btnCriarContador;
        private Button btnApagarCliente;
        private ListBox listBoxClientes;
    }
}