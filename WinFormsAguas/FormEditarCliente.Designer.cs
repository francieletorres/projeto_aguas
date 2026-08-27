namespace WinFormsAguas
{
    partial class FormEditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarCliente));
            btnCancelar = new Button();
            btnGuardarCliente = new Button();
            txtEmail = new TextBox();
            txtNif = new TextBox();
            txtContacto = new TextBox();
            txtMorada = new TextBox();
            txtNomeCliente = new TextBox();
            lblEmail = new Label();
            lblContacto = new Label();
            lblNif = new Label();
            lblNome = new Label();
            lblMorada = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblEstadoCliente = new Label();
            checkBoxEstadoCliente = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(24, 104, 153);
            btnCancelar.Font = new Font("Arial", 14F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(545, 536);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 50);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = Color.FromArgb(24, 104, 153);
            btnGuardarCliente.Font = new Font("Arial", 14F);
            btnGuardarCliente.ForeColor = Color.White;
            btnGuardarCliente.Location = new Point(706, 536);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(130, 50);
            btnGuardarCliente.TabIndex = 27;
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.UseVisualStyleBackColor = false;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 14F);
            txtEmail.Location = new Point(275, 456);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(561, 29);
            txtEmail.TabIndex = 26;
            // 
            // txtNif
            // 
            txtNif.Font = new Font("Arial", 14F);
            txtNif.Location = new Point(275, 400);
            txtNif.MaxLength = 9;
            txtNif.Name = "txtNif";
            txtNif.Size = new Size(561, 29);
            txtNif.TabIndex = 25;
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Arial", 14F);
            txtContacto.Location = new Point(275, 334);
            txtContacto.MaxLength = 9;
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(561, 29);
            txtContacto.TabIndex = 24;
            // 
            // txtMorada
            // 
            txtMorada.Font = new Font("Arial", 14F);
            txtMorada.Location = new Point(275, 276);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(561, 29);
            txtMorada.TabIndex = 23;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Arial", 14F);
            txtNomeCliente.Location = new Point(275, 214);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(561, 29);
            txtNomeCliente.TabIndex = 22;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 14F);
            lblEmail.Location = new Point(275, 432);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 22);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Email";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Arial", 14F);
            lblContacto.Location = new Point(275, 309);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(86, 22);
            lblContacto.TabIndex = 20;
            lblContacto.Text = "Contacto";
            // 
            // lblNif
            // 
            lblNif.AutoSize = true;
            lblNif.Font = new Font("Arial", 14F);
            lblNif.Location = new Point(275, 374);
            lblNif.Name = "lblNif";
            lblNif.Size = new Size(210, 22);
            lblNif.TabIndex = 19;
            lblNif.Text = "Número de Contribuinte";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 14F);
            lblNome.Location = new Point(275, 189);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 22);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome";
            // 
            // lblMorada
            // 
            lblMorada.AutoSize = true;
            lblMorada.Font = new Font("Arial", 14F);
            lblMorada.Location = new Point(275, 250);
            lblMorada.Name = "lblMorada";
            lblMorada.Size = new Size(73, 22);
            lblMorada.TabIndex = 17;
            lblMorada.Text = "Morada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(459, 150);
            label2.Name = "label2";
            label2.Size = new Size(157, 27);
            label2.TabIndex = 16;
            label2.Text = "Editar Cliente";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(468, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 515);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1162, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // lblEstadoCliente
            // 
            lblEstadoCliente.AutoSize = true;
            lblEstadoCliente.Font = new Font("Arial", 14F);
            lblEstadoCliente.Location = new Point(275, 489);
            lblEstadoCliente.Name = "lblEstadoCliente";
            lblEstadoCliente.Size = new Size(134, 22);
            lblEstadoCliente.TabIndex = 58;
            lblEstadoCliente.Text = "Estado Cliente";
            // 
            // checkBoxEstadoCliente
            // 
            checkBoxEstadoCliente.AutoSize = true;
            checkBoxEstadoCliente.Font = new Font("Arial", 14F);
            checkBoxEstadoCliente.Location = new Point(468, 489);
            checkBoxEstadoCliente.Name = "checkBoxEstadoCliente";
            checkBoxEstadoCliente.Size = new Size(71, 26);
            checkBoxEstadoCliente.TabIndex = 57;
            checkBoxEstadoCliente.Text = "Ativo";
            checkBoxEstadoCliente.UseVisualStyleBackColor = true;
            // 
            // FormEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1162, 744);
            Controls.Add(lblEstadoCliente);
            Controls.Add(checkBoxEstadoCliente);
            Controls.Add(pictureBox2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarCliente);
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
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "FormEditarCliente";
            Text = "FormEditarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardarCliente;
        private TextBox txtEmail;
        private TextBox txtNif;
        private TextBox txtContacto;
        private TextBox txtMorada;
        private TextBox txtNomeCliente;
        private Label lblEmail;
        private Label lblContacto;
        private Label lblNif;
        private Label lblNome;
        private Label lblMorada;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblEstadoCliente;
        private CheckBox checkBoxEstadoCliente;
    }
}