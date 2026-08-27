namespace WinFormsAguas
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new Panel();
            btnAbout = new Button();
            pictureBox2 = new PictureBox();
            lblLogo = new Label();
            btnCadastroCliente = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnContador = new Button();
            btnLeituraContador = new Button();
            btnFaturacao = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAbout);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblLogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 139);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbout.ForeColor = Color.FromArgb(21, 48, 91);
            btnAbout.Location = new Point(983, 48);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(129, 51);
            btnAbout.TabIndex = 6;
            btnAbout.Text = "Sobre";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
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
            lblLogo.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.FromArgb(21, 48, 91);
            lblLogo.Location = new Point(260, 74);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(376, 23);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "CONECTA VOCÊ AO QUE É ESSENCIAL";
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.BackColor = Color.Transparent;
            btnCadastroCliente.BackgroundImageLayout = ImageLayout.Zoom;
            btnCadastroCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastroCliente.ForeColor = Color.FromArgb(21, 48, 91);
            btnCadastroCliente.Image = (Image)resources.GetObject("btnCadastroCliente.Image");
            btnCadastroCliente.Location = new Point(145, 555);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(169, 129);
            btnCadastroCliente.TabIndex = 2;
            btnCadastroCliente.Text = "Cadastrar Cliente";
            btnCadastroCliente.TextAlign = ContentAlignment.BottomCenter;
            btnCadastroCliente.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCadastroCliente.UseVisualStyleBackColor = false;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-3529, 136);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1098, 323);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 182);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1194, 463);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // btnContador
            // 
            btnContador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContador.ForeColor = Color.FromArgb(21, 48, 91);
            btnContador.Image = (Image)resources.GetObject("btnContador.Image");
            btnContador.Location = new Point(381, 555);
            btnContador.Name = "btnContador";
            btnContador.Size = new Size(169, 129);
            btnContador.TabIndex = 3;
            btnContador.Text = "Cadastrar Contador";
            btnContador.TextAlign = ContentAlignment.BottomCenter;
            btnContador.TextImageRelation = TextImageRelation.ImageAboveText;
            btnContador.UseVisualStyleBackColor = true;
            btnContador.Click += btnContador_Click;
            // 
            // btnLeituraContador
            // 
            btnLeituraContador.BackgroundImageLayout = ImageLayout.None;
            btnLeituraContador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeituraContador.ForeColor = Color.FromArgb(21, 48, 91);
            btnLeituraContador.Image = (Image)resources.GetObject("btnLeituraContador.Image");
            btnLeituraContador.Location = new Point(623, 555);
            btnLeituraContador.Name = "btnLeituraContador";
            btnLeituraContador.Size = new Size(169, 129);
            btnLeituraContador.TabIndex = 2;
            btnLeituraContador.Text = "Leitura";
            btnLeituraContador.TextAlign = ContentAlignment.BottomCenter;
            btnLeituraContador.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLeituraContador.UseVisualStyleBackColor = true;
            btnLeituraContador.Click += btnLeituraContador_Click;
            // 
            // btnFaturacao
            // 
            btnFaturacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFaturacao.ForeColor = Color.FromArgb(21, 48, 91);
            btnFaturacao.Image = (Image)resources.GetObject("btnFaturacao.Image");
            btnFaturacao.Location = new Point(857, 555);
            btnFaturacao.Name = "btnFaturacao";
            btnFaturacao.Size = new Size(169, 129);
            btnFaturacao.TabIndex = 5;
            btnFaturacao.Text = "Consultar Faturas";
            btnFaturacao.TextAlign = ContentAlignment.BottomCenter;
            btnFaturacao.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFaturacao.UseVisualStyleBackColor = true;
            btnFaturacao.Click += btnFaturacao_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1194, 768);
            Controls.Add(btnFaturacao);
            Controls.Add(btnLeituraContador);
            Controls.Add(btnContador);
            Controls.Add(btnCadastroCliente);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Name = "FormPrincipal";
            Text = "Form1";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblLogo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnCadastroCliente;
        private PictureBox pictureBox4;
        private Button btnContador;
        private Button btnLeituraContador;
        private Button btnFaturacao;
        private Button btnAbout;
    }
}
