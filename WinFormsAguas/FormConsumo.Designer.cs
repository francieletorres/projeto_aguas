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
            lblDataLeitura = new Label();
            lblLeitura = new Label();
            label2 = new Label();
            txtLeitura = new TextBox();
            dateTimePickerLeitura = new DateTimePicker();
            btnLeitura = new Button();
            btnCancelar = new Button();
            lblObs = new Label();
            lblVolumeConsumido = new Label();
            txtVolumeConsumido = new TextBox();
            txtObs = new TextBox();
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
            panel1.Size = new Size(1191, 139);
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
            lblLogo.ForeColor = SystemColors.HotTrack;
            lblLogo.Location = new Point(220, 65);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(364, 20);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "CONECTA VOCÊ AO QUE É ESSENCIAL";
            // 
            // lblDataLeitura
            // 
            lblDataLeitura.AutoSize = true;
            lblDataLeitura.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataLeitura.Location = new Point(319, 282);
            lblDataLeitura.Name = "lblDataLeitura";
            lblDataLeitura.Size = new Size(163, 25);
            lblDataLeitura.TabIndex = 6;
            lblDataLeitura.Text = "Data da leitura";
            // 
            // lblLeitura
            // 
            lblLeitura.AutoSize = true;
            lblLeitura.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLeitura.Location = new Point(319, 355);
            lblLeitura.Name = "lblLeitura";
            lblLeitura.Size = new Size(177, 25);
            lblLeitura.TabIndex = 7;
            lblLeitura.Text = "Leitura contador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(438, 209);
            label2.Name = "label2";
            label2.Size = new Size(295, 28);
            label2.TabIndex = 8;
            label2.Text = "Comunicação de Leituras";
            // 
            // txtLeitura
            // 
            txtLeitura.Location = new Point(319, 380);
            txtLeitura.Name = "txtLeitura";
            txtLeitura.Size = new Size(561, 23);
            txtLeitura.TabIndex = 10;
            // 
            // dateTimePickerLeitura
            // 
            dateTimePickerLeitura.CalendarFont = new Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerLeitura.Font = new Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerLeitura.Format = DateTimePickerFormat.Short;
            dateTimePickerLeitura.Location = new Point(319, 310);
            dateTimePickerLeitura.Name = "dateTimePickerLeitura";
            dateTimePickerLeitura.Size = new Size(135, 30);
            dateTimePickerLeitura.TabIndex = 11;
            // 
            // btnLeitura
            // 
            btnLeitura.BackColor = SystemColors.Control;
            btnLeitura.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLeitura.Location = new Point(683, 645);
            btnLeitura.Name = "btnLeitura";
            btnLeitura.Size = new Size(185, 50);
            btnLeitura.TabIndex = 15;
            btnLeitura.Text = "Enviar Leitura";
            btnLeitura.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Control;
            btnCancelar.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(495, 645);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 50);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObs.Location = new Point(319, 500);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(125, 25);
            lblObs.TabIndex = 17;
            lblObs.Text = "Observação";
            // 
            // lblVolumeConsumido
            // 
            lblVolumeConsumido.AutoSize = true;
            lblVolumeConsumido.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVolumeConsumido.Location = new Point(319, 430);
            lblVolumeConsumido.Name = "lblVolumeConsumido";
            lblVolumeConsumido.Size = new Size(205, 25);
            lblVolumeConsumido.TabIndex = 18;
            lblVolumeConsumido.Text = "Volume Consumido";
            // 
            // txtVolumeConsumido
            // 
            txtVolumeConsumido.Location = new Point(319, 458);
            txtVolumeConsumido.Name = "txtVolumeConsumido";
            txtVolumeConsumido.Size = new Size(561, 23);
            txtVolumeConsumido.TabIndex = 19;
            // 
            // txtObs
            // 
            txtObs.Location = new Point(319, 528);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(561, 89);
            txtObs.TabIndex = 20;
            // 
            // FormConsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1191, 762);
            Controls.Add(txtObs);
            Controls.Add(txtVolumeConsumido);
            Controls.Add(lblVolumeConsumido);
            Controls.Add(lblObs);
            Controls.Add(btnCancelar);
            Controls.Add(btnLeitura);
            Controls.Add(dateTimePickerLeitura);
            Controls.Add(txtLeitura);
            Controls.Add(label2);
            Controls.Add(lblLeitura);
            Controls.Add(lblDataLeitura);
            Controls.Add(panel1);
            Name = "FormConsumo";
            Text = "FormConsumo";
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
        private Label lblDataLeitura;
        private Label lblLeitura;
        private Label label2;
        private TextBox txtLeitura;
        private DateTimePicker dateTimePickerLeitura;
        private Button btnLeitura;
        private Button btnCancelar;
        private Label lblObs;
        private Label lblVolumeConsumido;
        private TextBox txtVolumeConsumido;
        private TextBox txtObs;
    }
}