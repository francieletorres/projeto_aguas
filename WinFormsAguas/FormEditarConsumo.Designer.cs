namespace WinFormsAguas
{
    partial class FormEditarConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarConsumo));
            lblClienteContador = new Label();
            lblVolumeConsumido = new Label();
            pictureBox2 = new PictureBox();
            lblLeitura = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblClienteContador
            // 
            lblClienteContador.AutoSize = true;
            lblClienteContador.Font = new Font("Arial", 14F);
            lblClienteContador.Location = new Point(260, 242);
            lblClienteContador.Name = "lblClienteContador";
            lblClienteContador.Size = new Size(0, 22);
            lblClienteContador.TabIndex = 60;
            // 
            // lblVolumeConsumido
            // 
            lblVolumeConsumido.AutoSize = true;
            lblVolumeConsumido.Font = new Font("Arial", 14F);
            lblVolumeConsumido.Location = new Point(462, 381);
            lblVolumeConsumido.Name = "lblVolumeConsumido";
            lblVolumeConsumido.Size = new Size(21, 22);
            lblVolumeConsumido.TabIndex = 59;
            lblVolumeConsumido.Text = "0";
            lblVolumeConsumido.Click += lblVolumeConsumido_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(430, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // lblLeitura
            // 
            lblLeitura.AutoSize = true;
            lblLeitura.Font = new Font("Arial", 18F);
            lblLeitura.Location = new Point(430, 159);
            lblLeitura.Name = "lblLeitura";
            lblLeitura.Size = new Size(155, 27);
            lblLeitura.TabIndex = 57;
            lblLeitura.Text = "Editar Leitura";
            // 
            // txtObs
            // 
            txtObs.Font = new Font("Arial", 14F);
            txtObs.Location = new Point(260, 448);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(491, 89);
            txtObs.TabIndex = 55;
            txtObs.Text = " ";
            // 
            // lblVolumeCons
            // 
            lblVolumeCons.AutoSize = true;
            lblVolumeCons.Font = new Font("Arial", 14F);
            lblVolumeCons.Location = new Point(260, 381);
            lblVolumeCons.Name = "lblVolumeCons";
            lblVolumeCons.Size = new Size(181, 22);
            lblVolumeCons.TabIndex = 54;
            lblVolumeCons.Text = "Volume Consumido:";
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Arial", 14F);
            lblObs.Location = new Point(260, 423);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(113, 22);
            lblObs.TabIndex = 53;
            lblObs.Text = "Observação";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(24, 104, 153);
            btnCancelar.Font = new Font("Arial", 14F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(430, 560);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 50);
            btnCancelar.TabIndex = 52;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistarLeitura
            // 
            btnRegistarLeitura.BackColor = Color.FromArgb(24, 104, 153);
            btnRegistarLeitura.Font = new Font("Arial", 14F);
            btnRegistarLeitura.ForeColor = Color.White;
            btnRegistarLeitura.Location = new Point(597, 560);
            btnRegistarLeitura.Name = "btnRegistarLeitura";
            btnRegistarLeitura.Size = new Size(130, 50);
            btnRegistarLeitura.TabIndex = 51;
            btnRegistarLeitura.Text = "Registar";
            btnRegistarLeitura.UseVisualStyleBackColor = false;
            btnRegistarLeitura.Click += btnRegistarLeitura_Click;
            // 
            // dateTimePickerLeitura
            // 
            dateTimePickerLeitura.CalendarFont = new Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerLeitura.Font = new Font("Arial", 14F);
            dateTimePickerLeitura.Format = DateTimePickerFormat.Short;
            dateTimePickerLeitura.Location = new Point(498, 323);
            dateTimePickerLeitura.Name = "dateTimePickerLeitura";
            dateTimePickerLeitura.Size = new Size(135, 29);
            dateTimePickerLeitura.TabIndex = 50;
            // 
            // txtLeitura
            // 
            txtLeitura.Font = new Font("Arial", 14F);
            txtLeitura.Location = new Point(260, 323);
            txtLeitura.Name = "txtLeitura";
            txtLeitura.Size = new Size(174, 29);
            txtLeitura.TabIndex = 49;
            txtLeitura.TextChanged += txtLeitura_TextChanged;
            // 
            // lblLeituraContador
            // 
            lblLeituraContador.AutoSize = true;
            lblLeituraContador.Font = new Font("Arial", 14F);
            lblLeituraContador.Location = new Point(260, 287);
            lblLeituraContador.Name = "lblLeituraContador";
            lblLeituraContador.Size = new Size(146, 22);
            lblLeituraContador.TabIndex = 48;
            lblLeituraContador.Text = "Leitura contador";
            // 
            // lblDataLeitura
            // 
            lblDataLeitura.AutoSize = true;
            lblDataLeitura.Font = new Font("Arial", 14F);
            lblDataLeitura.Location = new Point(498, 287);
            lblDataLeitura.Name = "lblDataLeitura";
            lblDataLeitura.Size = new Size(130, 22);
            lblDataLeitura.TabIndex = 47;
            lblDataLeitura.Text = "Data da leitura";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 492);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1048, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // FormEditarConsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1048, 721);
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
            Name = "FormEditarConsumo";
            Text = "FormEditarConsumo";
            Load += FormEditarConsumo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClienteContador;
        private Label lblVolumeConsumido;
        private PictureBox pictureBox2;
        private Label lblLeitura;
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
    }
}