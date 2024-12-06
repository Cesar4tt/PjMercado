namespace ProjetoMercado
{
    partial class frmMercado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMercado));
            panel1 = new Panel();
            btnSobre = new Button();
            pictureHome = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            btnCaixa = new Button();
            panel4 = new Panel();
            btnProdutoCadastrar = new Button();
            panel5 = new Panel();
            btnCadastroUsuario = new Button();
            panelVisual = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panelVisual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 114, 4);
            panel1.Controls.Add(btnSobre);
            panel1.Controls.Add(pictureHome);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 63);
            panel1.TabIndex = 0;
            // 
            // btnSobre
            // 
            btnSobre.BackColor = Color.FromArgb(255, 114, 4);
            btnSobre.BackgroundImageLayout = ImageLayout.None;
            btnSobre.Cursor = Cursors.Hand;
            btnSobre.FlatAppearance.BorderSize = 0;
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSobre.Image = Properties.Resources.icons8_box_important_24;
            btnSobre.ImageAlign = ContentAlignment.MiddleRight;
            btnSobre.Location = new Point(1229, 14);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(96, 40);
            btnSobre.TabIndex = 4;
            btnSobre.Text = "Sobre";
            btnSobre.TextAlign = ContentAlignment.MiddleLeft;
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += btnSobre_Click;
            // 
            // pictureHome
            // 
            pictureHome.BackColor = Color.Transparent;
            pictureHome.Cursor = Cursors.Hand;
            pictureHome.ErrorImage = null;
            pictureHome.Image = Properties.Resources.icons8_casa_50;
            pictureHome.InitialImage = null;
            pictureHome.Location = new Point(13, 14);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(50, 40);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 3;
            pictureHome.TabStop = false;
            pictureHome.Click += pictureHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(69, 8);
            label1.Name = "label1";
            label1.Size = new Size(438, 46);
            label1.TabIndex = 2;
            label1.Text = "EMPÓRIO ALL BLUE";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(2, 111, 216);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 63);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(220, 666);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCaixa);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(217, 50);
            panel3.TabIndex = 0;
            // 
            // btnCaixa
            // 
            btnCaixa.BackColor = Color.FromArgb(2, 111, 216);
            btnCaixa.BackgroundImageLayout = ImageLayout.None;
            btnCaixa.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCaixa.ForeColor = Color.White;
            btnCaixa.Image = Properties.Resources.icons8_add_properties_32;
            btnCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaixa.Location = new Point(-41, -9);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Padding = new Padding(40, 0, 0, 0);
            btnCaixa.Size = new Size(265, 69);
            btnCaixa.TabIndex = 1;
            btnCaixa.Text = "          CAIXA";
            btnCaixa.TextAlign = ContentAlignment.MiddleLeft;
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnProdutoCadastrar);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(3, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(217, 50);
            panel4.TabIndex = 1;
            // 
            // btnProdutoCadastrar
            // 
            btnProdutoCadastrar.BackColor = Color.FromArgb(2, 111, 216);
            btnProdutoCadastrar.BackgroundImageLayout = ImageLayout.None;
            btnProdutoCadastrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProdutoCadastrar.ForeColor = Color.White;
            btnProdutoCadastrar.Image = Properties.Resources.icons8_food_receiver_32;
            btnProdutoCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutoCadastrar.Location = new Point(-41, -9);
            btnProdutoCadastrar.Name = "btnProdutoCadastrar";
            btnProdutoCadastrar.Padding = new Padding(40, 0, 0, 0);
            btnProdutoCadastrar.Size = new Size(265, 69);
            btnProdutoCadastrar.TabIndex = 1;
            btnProdutoCadastrar.Text = "          Cadastrar Produto";
            btnProdutoCadastrar.TextAlign = ContentAlignment.MiddleLeft;
            btnProdutoCadastrar.UseVisualStyleBackColor = false;
            btnProdutoCadastrar.Click += btnProdutoCadastrar_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnCadastroUsuario);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(3, 115);
            panel5.Name = "panel5";
            panel5.Size = new Size(217, 50);
            panel5.TabIndex = 2;
            // 
            // btnCadastroUsuario
            // 
            btnCadastroUsuario.BackColor = Color.FromArgb(2, 111, 216);
            btnCadastroUsuario.BackgroundImageLayout = ImageLayout.None;
            btnCadastroUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastroUsuario.ForeColor = Color.White;
            btnCadastroUsuario.Image = Properties.Resources.icons8_add_user_male_32;
            btnCadastroUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastroUsuario.Location = new Point(-41, -9);
            btnCadastroUsuario.Name = "btnCadastroUsuario";
            btnCadastroUsuario.Padding = new Padding(40, 0, 0, 0);
            btnCadastroUsuario.Size = new Size(265, 69);
            btnCadastroUsuario.TabIndex = 1;
            btnCadastroUsuario.Text = "          Cadastrar Usuário";
            btnCadastroUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastroUsuario.UseVisualStyleBackColor = false;
            btnCadastroUsuario.Click += button3_Click;
            // 
            // panelVisual
            // 
            panelVisual.BackgroundImageLayout = ImageLayout.Stretch;
            panelVisual.Controls.Add(pictureBox1);
            panelVisual.Dock = DockStyle.Fill;
            panelVisual.Location = new Point(220, 63);
            panelVisual.Name = "panelVisual";
            panelVisual.Size = new Size(1130, 666);
            panelVisual.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.banner_Mercado_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1130, 666);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmMercado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(panelVisual);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1366, 768);
            Name = "frmMercado";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += FrmMercado_Closing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panelVisual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelVisual;
        private Panel panel3;
        private Button btnCaixa;
        private Panel panel5;
        private Button btnCadastroUsuario;
        private Panel panel4;
        private Button btnProdutoCadastrar;
        private PictureBox pictureHome;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSobre;
    }
}