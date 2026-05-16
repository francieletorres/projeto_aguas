namespace WinFormsAguas
{
    partial class FormFaturacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaturacao));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lblLogo = new Label();
            lblConsumoTotal = new Label();
            lblFaturacao = new Label();
            txtConsumoTotal = new TextBox();
            lblValorFatura = new Label();
            txtValorFatura = new TextBox();
            btnGerarFatura = new Button();
            btnCancelar = new Button();
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
            panel1.Size = new Size(1187, 139);
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
            // lblConsumoTotal
            // 
            lblConsumoTotal.AutoSize = true;
            lblConsumoTotal.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsumoTotal.Location = new Point(313, 295);
            lblConsumoTotal.Name = "lblConsumoTotal";
            lblConsumoTotal.Size = new Size(162, 25);
            lblConsumoTotal.TabIndex = 6;
            lblConsumoTotal.Text = "Consumo Total";
            // 
            // lblFaturacao
            // 
            lblFaturacao.AutoSize = true;
            lblFaturacao.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFaturacao.Location = new Point(462, 192);
            lblFaturacao.Name = "lblFaturacao";
            lblFaturacao.Size = new Size(125, 28);
            lblFaturacao.TabIndex = 7;
            lblFaturacao.Text = "Faturação";
            // 
            // txtConsumoTotal
            // 
            txtConsumoTotal.Location = new Point(313, 323);
            txtConsumoTotal.Name = "txtConsumoTotal";
            txtConsumoTotal.Size = new Size(561, 23);
            txtConsumoTotal.TabIndex = 10;
            // 
            // lblValorFatura
            // 
            lblValorFatura.AutoSize = true;
            lblValorFatura.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorFatura.Location = new Point(313, 394);
            lblValorFatura.Name = "lblValorFatura";
            lblValorFatura.Size = new Size(140, 25);
            lblValorFatura.TabIndex = 11;
            lblValorFatura.Text = "Valor Fatura";
            // 
            // txtValorFatura
            // 
            txtValorFatura.Location = new Point(313, 422);
            txtValorFatura.Name = "txtValorFatura";
            txtValorFatura.Size = new Size(561, 23);
            txtValorFatura.TabIndex = 12;
            // 
            // btnGerarFatura
            // 
            btnGerarFatura.BackColor = SystemColors.Control;
            btnGerarFatura.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGerarFatura.Location = new Point(689, 518);
            btnGerarFatura.Name = "btnGerarFatura";
            btnGerarFatura.Size = new Size(185, 50);
            btnGerarFatura.TabIndex = 16;
            btnGerarFatura.Text = "Gerar Fatura";
            btnGerarFatura.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Control;
            btnCancelar.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(502, 518);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 50);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormFaturacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 759);
            Controls.Add(btnCancelar);
            Controls.Add(btnGerarFatura);
            Controls.Add(txtValorFatura);
            Controls.Add(lblValorFatura);
            Controls.Add(txtConsumoTotal);
            Controls.Add(lblFaturacao);
            Controls.Add(lblConsumoTotal);
            Controls.Add(panel1);
            Name = "FormFaturacao";
            Text = "FormFaturacao";
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
        private Label lblConsumoTotal;
        private Label lblFaturacao;
        private TextBox txtConsumoTotal;
        private Label lblValorFatura;
        private TextBox txtValorFatura;
        private Button btnGerarFatura;
        private Button btnCancelar;
    }
}