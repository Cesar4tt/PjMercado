namespace ProjetoMercado.UserControls
{
    partial class UC_UserCadastro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            mskdDataNascimento = new MaskedTextBox();
            label8 = new Label();
            cmbSexo = new ComboBox();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            mskdCelular = new MaskedTextBox();
            mskdCPF = new MaskedTextBox();
            txtRG = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNomeCompleto = new TextBox();
            btnRemoverFoto = new Button();
            btnProcurarFoto = new Button();
            txtBuscarUsuario = new TextBox();
            label9 = new Label();
            listView1 = new ListView();
            pictureFotoUser = new PictureBox();
            btnAdicionar = new Button();
            btnAtualizar = new Button();
            btnBuscar = new Button();
            btnRemoverUser = new Button();
            cmbCargo = new ComboBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureFotoUser).BeginInit();
            SuspendLayout();
            // 
            // mskdDataNascimento
            // 
            mskdDataNascimento.BorderStyle = BorderStyle.None;
            mskdDataNascimento.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskdDataNascimento.Location = new Point(15, 216);
            mskdDataNascimento.Mask = "00/00/0000";
            mskdDataNascimento.Name = "mskdDataNascimento";
            mskdDataNascimento.Size = new Size(240, 36);
            mskdDataNascimento.TabIndex = 41;
            mskdDataNascimento.TextAlign = HorizontalAlignment.Center;
            mskdDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 272);
            label8.Name = "label8";
            label8.Size = new Size(72, 29);
            label8.TabIndex = 40;
            label8.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            cmbSexo.FlatStyle = FlatStyle.Popup;
            cmbSexo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmbSexo.Location = new Point(15, 304);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(240, 36);
            cmbSexo.TabIndex = 39;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(395, 392);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(240, 36);
            txtSenha.TabIndex = 38;
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(15, 392);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(350, 36);
            txtLogin.TabIndex = 37;
            // 
            // mskdCelular
            // 
            mskdCelular.BorderStyle = BorderStyle.None;
            mskdCelular.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskdCelular.Location = new Point(395, 216);
            mskdCelular.Mask = "(55) 00 00000-0000";
            mskdCelular.Name = "mskdCelular";
            mskdCelular.Size = new Size(240, 36);
            mskdCelular.TabIndex = 36;
            mskdCelular.TextAlign = HorizontalAlignment.Center;
            // 
            // mskdCPF
            // 
            mskdCPF.BorderStyle = BorderStyle.None;
            mskdCPF.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskdCPF.Location = new Point(395, 123);
            mskdCPF.Mask = "000.000.000-00";
            mskdCPF.Name = "mskdCPF";
            mskdCPF.Size = new Size(240, 36);
            mskdCPF.TabIndex = 35;
            mskdCPF.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRG
            // 
            txtRG.BorderStyle = BorderStyle.None;
            txtRG.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRG.Location = new Point(15, 123);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(240, 36);
            txtRG.TabIndex = 34;
            txtRG.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 177);
            label7.Name = "label7";
            label7.Size = new Size(233, 29);
            label7.TabIndex = 33;
            label7.Text = "Data de nascimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(395, 184);
            label6.Name = "label6";
            label6.Size = new Size(93, 29);
            label6.TabIndex = 32;
            label6.Text = "Celular:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 360);
            label5.Name = "label5";
            label5.Size = new Size(77, 29);
            label5.TabIndex = 31;
            label5.Text = "Login:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(395, 360);
            label4.Name = "label4";
            label4.Size = new Size(86, 29);
            label4.TabIndex = 30;
            label4.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(395, 91);
            label3.Name = "label3";
            label3.Size = new Size(61, 29);
            label3.TabIndex = 29;
            label3.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 91);
            label2.Name = "label2";
            label2.Size = new Size(52, 29);
            label2.TabIndex = 28;
            label2.Text = "RG:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(190, 29);
            label1.TabIndex = 27;
            label1.Text = "Nome Completo:";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.BorderStyle = BorderStyle.None;
            txtNomeCompleto.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCompleto.Location = new Point(15, 42);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(620, 36);
            txtNomeCompleto.TabIndex = 26;
            // 
            // btnRemoverFoto
            // 
            btnRemoverFoto.BackColor = Color.Black;
            btnRemoverFoto.BackgroundImageLayout = ImageLayout.None;
            btnRemoverFoto.Cursor = Cursors.Hand;
            btnRemoverFoto.FlatAppearance.BorderSize = 0;
            btnRemoverFoto.FlatStyle = FlatStyle.Flat;
            btnRemoverFoto.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverFoto.ForeColor = Color.White;
            btnRemoverFoto.Location = new Point(827, 386);
            btnRemoverFoto.Name = "btnRemoverFoto";
            btnRemoverFoto.Size = new Size(131, 42);
            btnRemoverFoto.TabIndex = 43;
            btnRemoverFoto.Text = "Remover";
            btnRemoverFoto.UseVisualStyleBackColor = false;
            // 
            // btnProcurarFoto
            // 
            btnProcurarFoto.BackColor = Color.Black;
            btnProcurarFoto.BackgroundImageLayout = ImageLayout.None;
            btnProcurarFoto.Cursor = Cursors.Hand;
            btnProcurarFoto.FlatAppearance.BorderSize = 0;
            btnProcurarFoto.FlatStyle = FlatStyle.Flat;
            btnProcurarFoto.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProcurarFoto.ForeColor = Color.White;
            btnProcurarFoto.Location = new Point(664, 386);
            btnProcurarFoto.Name = "btnProcurarFoto";
            btnProcurarFoto.Size = new Size(157, 42);
            btnProcurarFoto.TabIndex = 42;
            btnProcurarFoto.Text = "Procurar Foto";
            btnProcurarFoto.UseVisualStyleBackColor = false;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarUsuario.Location = new Point(15, 484);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(1031, 35);
            txtBuscarUsuario.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(15, 454);
            label9.Name = "label9";
            label9.Size = new Size(172, 29);
            label9.TabIndex = 45;
            label9.Text = "Buscar Usuário";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Location = new Point(15, 525);
            listView1.Name = "listView1";
            listView1.Size = new Size(1100, 132);
            listView1.TabIndex = 44;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureFotoUser
            // 
            pictureFotoUser.BackgroundImageLayout = ImageLayout.None;
            pictureFotoUser.Image = Properties.Resources.man_157699_640;
            pictureFotoUser.Location = new Point(664, 42);
            pictureFotoUser.Name = "pictureFotoUser";
            pictureFotoUser.Size = new Size(294, 338);
            pictureFotoUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFotoUser.TabIndex = 47;
            pictureFotoUser.TabStop = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.SpringGreen;
            btnAdicionar.BackgroundImageLayout = ImageLayout.None;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.Image = Properties.Resources.icons8_adicionar_usuário_masculino_50;
            btnAdicionar.ImageAlign = ContentAlignment.TopCenter;
            btnAdicionar.Location = new Point(980, 42);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(125, 78);
            btnAdicionar.TabIndex = 48;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.TextAlign = ContentAlignment.BottomCenter;
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.SpringGreen;
            btnAtualizar.BackgroundImageLayout = ImageLayout.None;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizar.Image = Properties.Resources.icons8_instalando_atualizações_50;
            btnAtualizar.ImageAlign = ContentAlignment.TopCenter;
            btnAtualizar.Location = new Point(980, 144);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(125, 82);
            btnAtualizar.TabIndex = 49;
            btnAtualizar.Text = "ATUALIZAR";
            btnAtualizar.TextAlign = ContentAlignment.BottomCenter;
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = Properties.Resources.icons8_pesquisar_30;
            btnBuscar.Location = new Point(1052, 478);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(63, 44);
            btnBuscar.TabIndex = 50;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRemoverUser
            // 
            btnRemoverUser.BackColor = Color.SpringGreen;
            btnRemoverUser.BackgroundImageLayout = ImageLayout.None;
            btnRemoverUser.FlatAppearance.BorderSize = 0;
            btnRemoverUser.FlatStyle = FlatStyle.Flat;
            btnRemoverUser.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverUser.Image = Properties.Resources.icons8_delete_50;
            btnRemoverUser.ImageAlign = ContentAlignment.TopCenter;
            btnRemoverUser.Location = new Point(980, 260);
            btnRemoverUser.Name = "btnRemoverUser";
            btnRemoverUser.Size = new Size(125, 82);
            btnRemoverUser.TabIndex = 51;
            btnRemoverUser.Text = "REMOVER";
            btnRemoverUser.TextAlign = ContentAlignment.BottomCenter;
            btnRemoverUser.UseVisualStyleBackColor = false;
            btnRemoverUser.Click += btnRemoverUser_Click;
            // 
            // cmbCargo
            // 
            cmbCargo.FlatStyle = FlatStyle.Popup;
            cmbCargo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Supervisor", "Caixa" });
            cmbCargo.Location = new Point(395, 304);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(240, 36);
            cmbCargo.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(395, 272);
            label10.Name = "label10";
            label10.Size = new Size(83, 29);
            label10.TabIndex = 53;
            label10.Text = "Cargo:";
            // 
            // UC_UserCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 169, 63);
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(label10);
            Controls.Add(cmbCargo);
            Controls.Add(btnRemoverUser);
            Controls.Add(btnBuscar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnAdicionar);
            Controls.Add(pictureFotoUser);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(label9);
            Controls.Add(listView1);
            Controls.Add(btnRemoverFoto);
            Controls.Add(btnProcurarFoto);
            Controls.Add(mskdDataNascimento);
            Controls.Add(label8);
            Controls.Add(cmbSexo);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(mskdCelular);
            Controls.Add(mskdCPF);
            Controls.Add(txtRG);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNomeCompleto);
            Name = "UC_UserCadastro";
            Size = new Size(1130, 667);
            ((System.ComponentModel.ISupportInitialize)pictureFotoUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskdDataNascimento;
        private Label label8;
        private ComboBox cmbSexo;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private MaskedTextBox mskdCelular;
        private MaskedTextBox mskdCPF;
        private TextBox txtRG;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNomeCompleto;
        private Button btnRemoverFoto;
        private Button btnProcurarFoto;
        private TextBox txtBuscarUsuario;
        private Label label9;
        private ListView listView1;
        private PictureBox pictureFotoUser;
        private Button btnAdicionar;
        private Button btnAtualizar;
        private Button btnBuscar;
        private Button btnRemoverUser;
        private ComboBox cmbCargo;
        private Label label10;
    }
}
