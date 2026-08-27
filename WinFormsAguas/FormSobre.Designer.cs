namespace WinFormsAguas
{
    partial class FormSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobre));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblNome = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(332, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 14F);
            lblNome.Location = new Point(330, 200);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(118, 22);
            lblNome.TabIndex = 32;
            lblNome.Text = "Versão 1.0.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(168, 155);
            label2.Name = "label2";
            label2.Size = new Size(443, 27);
            label2.TabIndex = 33;
            label2.Text = "Aqualis - Gestão de Consumos de Água";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F);
            label1.Location = new Point(308, 241);
            label1.Name = "label1";
            label1.Size = new Size(163, 22);
            label1.TabIndex = 34;
            label1.Text = "Desenvolvido por:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F);
            label3.Location = new Point(291, 284);
            label3.Name = "label3";
            label3.Size = new Size(197, 22);
            label3.TabIndex = 35;
            label3.Text = "Maria Franciele Torres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F);
            label4.Location = new Point(292, 328);
            label4.Name = "label4";
            label4.Size = new Size(179, 22);
            label4.TabIndex = 36;
            label4.Text = " 29/05/2026 Aqualis";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(24, 104, 153);
            btnFechar.Font = new Font("Arial", 14F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(324, 375);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(130, 50);
            btnFechar.TabIndex = 37;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblNome);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSobre";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormSobre";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblNome;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnFechar;
    }
}