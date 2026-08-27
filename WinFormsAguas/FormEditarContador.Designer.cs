namespace WinFormsAguas
{
    partial class FormEditarContador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarContador));
            pictureBox2 = new PictureBox();
            lblEditarContador = new Label();
            pictureBox1 = new PictureBox();
            lblEstadoContador = new Label();
            checkBoxEstadoContador = new CheckBox();
            btnCancelar = new Button();
            btnGuardarContador = new Button();
            dateTimePickerEditarContador = new DateTimePicker();
            lblInstalacaoContador = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(465, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // lblEditarContador
            // 
            lblEditarContador.AutoSize = true;
            lblEditarContador.Font = new Font("Arial", 18F);
            lblEditarContador.Location = new Point(447, 170);
            lblEditarContador.Name = "lblEditarContador";
            lblEditarContador.Size = new Size(181, 27);
            lblEditarContador.TabIndex = 31;
            lblEditarContador.Text = "Editar Contador";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 522);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1165, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // lblEstadoContador
            // 
            lblEstadoContador.AutoSize = true;
            lblEstadoContador.Font = new Font("Arial", 14F);
            lblEstadoContador.Location = new Point(344, 338);
            lblEstadoContador.Name = "lblEstadoContador";
            lblEstadoContador.Size = new Size(153, 22);
            lblEstadoContador.TabIndex = 54;
            lblEstadoContador.Text = "Estado Contador";
            // 
            // checkBoxEstadoContador
            // 
            checkBoxEstadoContador.AutoSize = true;
            checkBoxEstadoContador.Font = new Font("Arial", 14F);
            checkBoxEstadoContador.Location = new Point(558, 338);
            checkBoxEstadoContador.Name = "checkBoxEstadoContador";
            checkBoxEstadoContador.Size = new Size(71, 26);
            checkBoxEstadoContador.TabIndex = 53;
            checkBoxEstadoContador.Text = "Ativo";
            checkBoxEstadoContador.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(24, 104, 153);
            btnCancelar.Font = new Font("Arial", 14F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(465, 445);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 50);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarContador
            // 
            btnGuardarContador.BackColor = Color.FromArgb(24, 104, 153);
            btnGuardarContador.Font = new Font("Arial", 14F);
            btnGuardarContador.ForeColor = Color.White;
            btnGuardarContador.Location = new Point(658, 445);
            btnGuardarContador.Name = "btnGuardarContador";
            btnGuardarContador.Size = new Size(130, 50);
            btnGuardarContador.TabIndex = 48;
            btnGuardarContador.Text = "Guardar";
            btnGuardarContador.UseVisualStyleBackColor = false;
            btnGuardarContador.Click += btnGuardarContador_Click;
            // 
            // dateTimePickerEditarContador
            // 
            dateTimePickerEditarContador.CalendarFont = new Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerEditarContador.Enabled = false;
            dateTimePickerEditarContador.Font = new Font("Arial", 14F);
            dateTimePickerEditarContador.Format = DateTimePickerFormat.Short;
            dateTimePickerEditarContador.Location = new Point(558, 275);
            dateTimePickerEditarContador.Margin = new Padding(2);
            dateTimePickerEditarContador.Name = "dateTimePickerEditarContador";
            dateTimePickerEditarContador.Size = new Size(136, 29);
            dateTimePickerEditarContador.TabIndex = 47;
            // 
            // lblInstalacaoContador
            // 
            lblInstalacaoContador.AutoSize = true;
            lblInstalacaoContador.Font = new Font("Arial", 14F);
            lblInstalacaoContador.Location = new Point(344, 277);
            lblInstalacaoContador.Name = "lblInstalacaoContador";
            lblInstalacaoContador.Size = new Size(166, 22);
            lblInstalacaoContador.TabIndex = 46;
            lblInstalacaoContador.Text = "Data da Instalação";
            // 
            // FormEditarContador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1165, 751);
            Controls.Add(lblEstadoContador);
            Controls.Add(checkBoxEstadoContador);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarContador);
            Controls.Add(dateTimePickerEditarContador);
            Controls.Add(lblInstalacaoContador);
            Controls.Add(pictureBox2);
            Controls.Add(lblEditarContador);
            Controls.Add(pictureBox1);
            Name = "FormEditarContador";
            Text = "FormEditarContador";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label lblEditarContador;
        private PictureBox pictureBox1;
        private Label lblEstadoContador;
        private CheckBox checkBoxEstadoContador;
        private Button btnCancelar;
        private Button btnGuardarContador;
        private DateTimePicker dateTimePickerEditarContador;
        private Label lblInstalacaoContador;
    }
}