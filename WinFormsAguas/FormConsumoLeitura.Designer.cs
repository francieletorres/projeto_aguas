namespace WinFormsAguas
{
    partial class FormConsumoLeitura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsumoLeitura));
            txtObs = new TextBox();
            lblVolumeCons = new Label();
            lblObs = new Label();
            btnCancelar = new Button();
            btnRegistarLeitura = new Button();
            dateTimePickerLeitura = new DateTimePicker();
            txtLeitura = new TextBox();
            lblLeituraContador = new Label();
            lblDataLeitura = new Label();
            pictureBox1 = new PictureBox();
            lblLeitura = new Label();
            pictureBox2 = new PictureBox();
            lblVolumeConsumido = new Label();
            lblClienteContador = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtObs
            // 
            txtObs.Font = new Font("Arial", 14F);
            txtObs.Location = new Point(346, 462);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(491, 89);
            txtObs.TabIndex = 41;
            txtObs.Text = " ";
            // 
            // lblVolumeCons
            // 
            lblVolumeCons.AutoSize = true;
            lblVolumeCons.Font = new Font("Arial", 14F);
            lblVolumeCons.Location = new Point(346, 392);
            lblVolumeCons.Name = "lblVolumeCons";
            lblVolumeCons.Size = new Size(181, 22);
            lblVolumeCons.TabIndex = 39;
            lblVolumeCons.Text = "Volume Consumido:";
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Arial", 14F);
            lblObs.Location = new Point(346, 434);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(113, 22);
            lblObs.TabIndex = 38;
            lblObs.Text = "Observação";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(24, 104, 153);
            btnCancelar.Font = new Font("Arial", 14F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(493, 570);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 50);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistarLeitura
            // 
            btnRegistarLeitura.BackColor = Color.FromArgb(24, 104, 153);
            btnRegistarLeitura.Font = new Font("Arial", 14F);
            btnRegistarLeitura.ForeColor = Color.White;
            btnRegistarLeitura.Location = new Point(660, 570);
            btnRegistarLeitura.Name = "btnRegistarLeitura";
            btnRegistarLeitura.Size = new Size(130, 50);
            btnRegistarLeitura.TabIndex = 36;
            btnRegistarLeitura.Text = "Registar";
            btnRegistarLeitura.UseVisualStyleBackColor = false;
            btnRegistarLeitura.Click += btnRegistarLeitura_Click;
            // 
            // dateTimePickerLeitura
            // 
            dateTimePickerLeitura.CalendarFont = new Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerLeitura.Font = new Font("Arial", 14F);
            dateTimePickerLeitura.Format = DateTimePickerFormat.Short;
            dateTimePickerLeitura.Location = new Point(584, 334);
            dateTimePickerLeitura.Name = "dateTimePickerLeitura";
            dateTimePickerLeitura.Size = new Size(135, 29);
            dateTimePickerLeitura.TabIndex = 35;
            dateTimePickerLeitura.ValueChanged += dateTimePickerLeitura_ValueChanged;
            // 
            // txtLeitura
            // 
            txtLeitura.Font = new Font("Arial", 14F);
            txtLeitura.Location = new Point(346, 334);
            txtLeitura.Name = "txtLeitura";
            txtLeitura.Size = new Size(174, 29);
            txtLeitura.TabIndex = 34;
            txtLeitura.TextChanged += txtLeitura_TextChanged;
            // 
            // lblLeituraContador
            // 
            lblLeituraContador.AutoSize = true;
            lblLeituraContador.Font = new Font("Arial", 14F);
            lblLeituraContador.Location = new Point(346, 298);
            lblLeituraContador.Name = "lblLeituraContador";
            lblLeituraContador.Size = new Size(146, 22);
            lblLeituraContador.TabIndex = 33;
            lblLeituraContador.Text = "Leitura contador";
            // 
            // lblDataLeitura
            // 
            lblDataLeitura.AutoSize = true;
            lblDataLeitura.Font = new Font("Arial", 14F);
            lblDataLeitura.Location = new Point(584, 298);
            lblDataLeitura.Name = "lblDataLeitura";
            lblDataLeitura.Size = new Size(130, 22);
            lblDataLeitura.TabIndex = 32;
            lblDataLeitura.Text = "Data da leitura";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 539);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1160, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // lblLeitura
            // 
            lblLeitura.AutoSize = true;
            lblLeitura.Font = new Font("Arial", 18F);
            lblLeitura.Location = new Point(496, 174);
            lblLeitura.Name = "lblLeitura";
            lblLeitura.Size = new Size(208, 27);
            lblLeitura.TabIndex = 43;
            lblLeitura.Text = "Comunicar Leitura";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(516, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // lblVolumeConsumido
            // 
            lblVolumeConsumido.AutoSize = true;
            lblVolumeConsumido.Font = new Font("Arial", 14F);
            lblVolumeConsumido.Location = new Point(548, 392);
            lblVolumeConsumido.Name = "lblVolumeConsumido";
            lblVolumeConsumido.Size = new Size(21, 22);
            lblVolumeConsumido.TabIndex = 45;
            lblVolumeConsumido.Text = "0";
            // 
            // lblClienteContador
            // 
            lblClienteContador.AutoSize = true;
            lblClienteContador.Font = new Font("Arial", 14F);
            lblClienteContador.Location = new Point(346, 253);
            lblClienteContador.Name = "lblClienteContador";
            lblClienteContador.Size = new Size(0, 22);
            lblClienteContador.TabIndex = 46;
            // 
            // FormConsumoLeitura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1160, 768);
            Controls.Add(lblClienteContador);
            Controls.Add(lblVolumeConsumido);
            Controls.Add(pictureBox2);
            Controls.Add(lblLeitura);
            Controls.Add(txtObs);
            Controls.Add(lblVolumeCons);
            Controls.Add(lblObs);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistarLeitura);
            Controls.Add(dateTimePickerLeitura);
            Controls.Add(txtLeitura);
            Controls.Add(lblLeituraContador);
            Controls.Add(lblDataLeitura);
            Controls.Add(pictureBox1);
            Name = "FormConsumoLeitura";
            Text = "FormConsumoLeitura";
            Load += FormConsumoLeitura_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObs;
        private Label lblVolumeCons;
        private Label lblObs;
        private Button btnCancelar;
        private Button btnRegistarLeitura;
        private DateTimePicker dateTimePickerLeitura;
        private TextBox txtLeitura;
        private Label lblLeituraContador;
        private Label lblDataLeitura;
        private PictureBox pictureBox1;
        private Label lblLeitura;
        private PictureBox pictureBox2;
        private Label lblVolumeConsumido;
        private Label lblClienteContador;
    }
}