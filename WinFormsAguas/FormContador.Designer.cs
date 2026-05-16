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
            lblCliente = new Label();
            lblInstalacaoContador = new Label();
            dateTimePickerContador = new DateTimePicker();
            lblNomeCliente = new Label();
            btnSalvarContador = new Button();
            btnCancelar = new Button();
            lblAdicionarContador = new Label();
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
            lblLogo.ForeColor = SystemColors.HotTrack;
            lblLogo.Location = new Point(220, 65);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(364, 20);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "CONECTA VOCÊ AO QUE É ESSENCIAL";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(227, 230);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(90, 25);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "Cliente:";
            // 
            // lblInstalacaoContador
            // 
            lblInstalacaoContador.AutoSize = true;
            lblInstalacaoContador.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstalacaoContador.Location = new Point(220, 287);
            lblInstalacaoContador.Name = "lblInstalacaoContador";
            lblInstalacaoContador.Size = new Size(205, 25);
            lblInstalacaoContador.TabIndex = 8;
            lblInstalacaoContador.Text = "Data da Instalaçao:";
            // 
            // dateTimePickerContador
            // 
            dateTimePickerContador.CalendarFont = new Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerContador.Font = new Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerContador.Format = DateTimePickerFormat.Short;
            dateTimePickerContador.Location = new Point(432, 286);
            dateTimePickerContador.Margin = new Padding(2, 2, 2, 2);
            dateTimePickerContador.Name = "dateTimePickerContador";
            dateTimePickerContador.Size = new Size(136, 30);
            dateTimePickerContador.TabIndex = 9;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeCliente.Location = new Point(332, 232);
            lblNomeCliente.Margin = new Padding(2, 0, 2, 0);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(65, 23);
            lblNomeCliente.TabIndex = 10;
            lblNomeCliente.Text = "label1";
            // 
            // btnSalvarContador
            // 
            btnSalvarContador.BackColor = SystemColors.Control;
            btnSalvarContador.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarContador.Location = new Point(540, 378);
            btnSalvarContador.Name = "btnSalvarContador";
            btnSalvarContador.Size = new Size(130, 50);
            btnSalvarContador.TabIndex = 15;
            btnSalvarContador.Text = "Salvar";
            btnSalvarContador.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Control;
            btnCancelar.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(371, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 50);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblAdicionarContador
            // 
            lblAdicionarContador.AutoSize = true;
            lblAdicionarContador.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdicionarContador.Location = new Point(418, 181);
            lblAdicionarContador.Name = "lblAdicionarContador";
            lblAdicionarContador.Size = new Size(231, 28);
            lblAdicionarContador.TabIndex = 17;
            lblAdicionarContador.Text = "Adicionar Contador";
            // 
            // FormContador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1201, 769);
            Controls.Add(lblAdicionarContador);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvarContador);
            Controls.Add(lblNomeCliente);
            Controls.Add(dateTimePickerContador);
            Controls.Add(lblInstalacaoContador);
            Controls.Add(lblCliente);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormContador";
            Text = "FormContador";
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
        private Label lblCliente;
        private Label lblInstalacaoContador;
        private DateTimePicker dateTimePickerContador;
        private Label lblNomeCliente;
        private Button btnSalvarContador;
        private Button btnCancelar;
        private Label lblAdicionarContador;
    }
}