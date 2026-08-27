namespace WinFormsAguas
{
    partial class FormVisualizarFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizarFatura));
            lbl5 = new Label();
            btnFechar = new Button();
            btnPagar = new Button();
            lbl1 = new Label();
            pictureBox2 = new PictureBox();
            lblFatura = new Label();
            pictureBox1 = new PictureBox();
            lbl7 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl6 = new Label();
            lbl8 = new Label();
            lblIdFatura = new Label();
            lblNomeCliente = new Label();
            lblMorada = new Label();
            lblContacto = new Label();
            lblIdContador = new Label();
            lblDataEmissao = new Label();
            lblValorTotal = new Label();
            lblEstado = new Label();
            btnAnular = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Arial", 14F);
            lbl5.Location = new Point(166, 375);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(230, 22);
            lbl5.TabIndex = 63;
            lbl5.Text = "Identificador do Contador:";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(24, 104, 153);
            btnFechar.Font = new Font("Arial", 14F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(449, 495);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(130, 50);
            btnFechar.TabIndex = 61;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(24, 104, 153);
            btnPagar.Font = new Font("Arial", 14F);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(855, 495);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(130, 50);
            btnPagar.TabIndex = 60;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Arial", 14F);
            lbl1.Location = new Point(166, 218);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(93, 22);
            lbl1.TabIndex = 58;
            lbl1.Text = "Fatura Nº:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(431, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 56;
            pictureBox2.TabStop = false;
            // 
            // lblFatura
            // 
            lblFatura.AutoSize = true;
            lblFatura.Font = new Font("Arial", 18F);
            lblFatura.Location = new Point(460, 151);
            lblFatura.Name = "lblFatura";
            lblFatura.Size = new Size(82, 27);
            lblFatura.TabIndex = 55;
            lblFatura.Text = "Fatura";
            lblFatura.Click += lblFatura_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 480);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1061, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Arial", 14F);
            lbl7.Location = new Point(166, 446);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(103, 22);
            lbl7.TabIndex = 64;
            lbl7.Text = "Valor Total:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Arial", 14F);
            lbl2.Location = new Point(166, 256);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(74, 22);
            lbl2.TabIndex = 65;
            lbl2.Text = "Cliente:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Arial", 14F);
            lbl3.Location = new Point(166, 296);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(78, 22);
            lbl3.TabIndex = 66;
            lbl3.Text = "Morada:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Arial", 14F);
            lbl4.Location = new Point(166, 334);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(91, 22);
            lbl4.TabIndex = 67;
            lbl4.Text = "Contacto:";
            lbl4.Click += label4_Click;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Arial", 14F);
            lbl6.Location = new Point(166, 410);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(160, 22);
            lbl6.TabIndex = 68;
            lbl6.Text = "Data de Emissão:";
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Font = new Font("Arial", 14F);
            lbl8.Location = new Point(565, 218);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(75, 22);
            lbl8.TabIndex = 69;
            lbl8.Text = "Estado:";
            // 
            // lblIdFatura
            // 
            lblIdFatura.AutoSize = true;
            lblIdFatura.Font = new Font("Arial", 14F);
            lblIdFatura.Location = new Point(310, 218);
            lblIdFatura.Name = "lblIdFatura";
            lblIdFatura.Size = new Size(0, 22);
            lblIdFatura.TabIndex = 71;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Arial", 14F);
            lblNomeCliente.Location = new Point(310, 256);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(0, 22);
            lblNomeCliente.TabIndex = 72;
            // 
            // lblMorada
            // 
            lblMorada.AutoSize = true;
            lblMorada.Font = new Font("Arial", 14F);
            lblMorada.Location = new Point(310, 296);
            lblMorada.Name = "lblMorada";
            lblMorada.Size = new Size(0, 22);
            lblMorada.TabIndex = 73;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Arial", 14F);
            lblContacto.Location = new Point(310, 334);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(0, 22);
            lblContacto.TabIndex = 74;
            // 
            // lblIdContador
            // 
            lblIdContador.AutoSize = true;
            lblIdContador.Font = new Font("Arial", 14F);
            lblIdContador.Location = new Point(449, 375);
            lblIdContador.Name = "lblIdContador";
            lblIdContador.Size = new Size(0, 22);
            lblIdContador.TabIndex = 75;
            // 
            // lblDataEmissao
            // 
            lblDataEmissao.AutoSize = true;
            lblDataEmissao.Font = new Font("Arial", 14F);
            lblDataEmissao.Location = new Point(366, 410);
            lblDataEmissao.Name = "lblDataEmissao";
            lblDataEmissao.Size = new Size(0, 22);
            lblDataEmissao.TabIndex = 76;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Arial", 14F);
            lblValorTotal.Location = new Point(310, 446);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(0, 22);
            lblValorTotal.TabIndex = 77;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Arial", 14F);
            lblEstado.Location = new Point(657, 218);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 22);
            lblEstado.TabIndex = 78;
            // 
            // btnAnular
            // 
            btnAnular.BackColor = Color.FromArgb(24, 104, 153);
            btnAnular.Font = new Font("Arial", 14F);
            btnAnular.ForeColor = Color.White;
            btnAnular.Location = new Point(621, 495);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(186, 50);
            btnAnular.TabIndex = 60;
            btnAnular.Text = "Anular Fatura";
            btnAnular.UseVisualStyleBackColor = false;
            btnAnular.Click += btnAnular_Click;
            // 
            // FormVisualizarFatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1061, 709);
            Controls.Add(btnAnular);
            Controls.Add(lblEstado);
            Controls.Add(lblValorTotal);
            Controls.Add(lblDataEmissao);
            Controls.Add(lblIdContador);
            Controls.Add(lblContacto);
            Controls.Add(lblMorada);
            Controls.Add(lblNomeCliente);
            Controls.Add(lblIdFatura);
            Controls.Add(lbl8);
            Controls.Add(lbl6);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl7);
            Controls.Add(lbl5);
            Controls.Add(btnFechar);
            Controls.Add(btnPagar);
            Controls.Add(lbl1);
            Controls.Add(pictureBox2);
            Controls.Add(lblFatura);
            Controls.Add(pictureBox1);
            Name = "FormVisualizarFatura";
            Text = "FormVisualizarFatura";
            Load += FormVisualizarFatura_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl5;
        private Button btnFechar;
        private Button btnPagar;
        private Label lbl1;
        private PictureBox pictureBox2;
        private Label lblFatura;
        private PictureBox pictureBox1;
        private Label lbl7;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl6;
        private Label lbl8;
        private Label lblIdFatura;
        private Label lblNomeCliente;
        private Label lblMorada;
        private Label lblContacto;
        private Label lblIdContador;
        private Label lblDataEmissao;
        private Label lblValorTotal;
        private Label lblEstado;
        private Button btnAnular;
    }
}