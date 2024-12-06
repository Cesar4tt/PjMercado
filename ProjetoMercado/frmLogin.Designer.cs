namespace ProjetoMercado
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            btnEntrar = new Button();
            panel2 = new Panel();
            panelEmail = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panelSenha = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnSair = new Button();
            btnMinimizar = new Button();
            panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.White;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ImeMode = ImeMode.NoControl;
            txtSenha.Location = new Point(62, 11);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(269, 24);
            txtSenha.TabIndex = 18;
            txtSenha.Tag = "";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ImeMode = ImeMode.NoControl;
            txtEmail.Location = new Point(62, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(269, 24);
            txtEmail.TabIndex = 17;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(255, 114, 4);
            btnEntrar.BackgroundImageLayout = ImageLayout.None;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(612, 406);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(250, 42);
            btnEntrar.TabIndex = 16;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Location = new Point(569, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 2);
            panel2.TabIndex = 14;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.White;
            panelEmail.Controls.Add(pictureBox1);
            panelEmail.Controls.Add(txtEmail);
            panelEmail.Location = new Point(563, 227);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(351, 43);
            panelEmail.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_username_48;
            pictureBox1.Location = new Point(10, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Location = new Point(569, 358);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 2);
            panel1.TabIndex = 20;
            // 
            // panelSenha
            // 
            panelSenha.BackColor = Color.White;
            panelSenha.Controls.Add(pictureBox2);
            panelSenha.Controls.Add(txtSenha);
            panelSenha.Location = new Point(563, 309);
            panelSenha.Name = "panelSenha";
            panelSenha.Size = new Size(351, 43);
            panelSenha.TabIndex = 21;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_password_50;
            pictureBox2.Location = new Point(10, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(563, 149);
            label1.Name = "label1";
            label1.Size = new Size(144, 45);
            label1.TabIndex = 22;
            label1.Text = "LOGIN";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(9, 120, 217);
            btnSair.BackgroundImageLayout = ImageLayout.None;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Image = Properties.Resources.icons8_close_16;
            btnSair.Location = new Point(923, 8);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(24, 24);
            btnSair.TabIndex = 23;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(9, 120, 217);
            btnMinimizar.BackgroundImageLayout = ImageLayout.None;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ForeColor = Color.Transparent;
            btnMinimizar.Image = Properties.Resources.icons8_horizontal_line_16;
            btnMinimizar.Location = new Point(893, 8);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 24);
            btnMinimizar.TabIndex = 24;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 560);
            Controls.Add(btnMinimizar);
            Controls.Add(btnSair);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panelSenha);
            Controls.Add(btnEntrar);
            Controls.Add(panel2);
            Controls.Add(panelEmail);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSenha.ResumeLayout(false);
            panelSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button btnEntrar;
        private Panel panel2;
        private Panel panelEmail;
        private Panel panel1;
        private Panel panelSenha;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSair;
        private Button btnMinimizar;
    }
}