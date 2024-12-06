namespace ProjetoMercado.UserControls
{
    partial class UC_Caixa
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
            btnAbrirCupom = new Button();
            panel1 = new Panel();
            lblNomeProduto = new Label();
            lblCaixaFechado = new Label();
            pictureBox1 = new PictureBox();
            lsvProdutos = new ListView();
            panel2 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            checkNotaFiscal = new CheckBox();
            panel4 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            label1 = new Label();
            mskdNotaFiscal = new MaskedTextBox();
            txtCodigo = new TextBox();
            txtQuantidade = new TextBox();
            lblValoUnitario = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            lblTotalItem = new Label();
            label15 = new Label();
            pictureBox10 = new PictureBox();
            lblTroco = new Label();
            lblTotalRecebido = new Label();
            label11 = new Label();
            pictureBox8 = new PictureBox();
            label10 = new Label();
            pictureBox7 = new PictureBox();
            lblSubtotal = new Label();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            txtPagamento = new TextBox();
            cmbFormaPagamento = new ComboBox();
            panel6 = new Panel();
            label16 = new Label();
            label18 = new Label();
            panel7 = new Panel();
            label19 = new Label();
            btnPagar = new Button();
            btnFinalizarCompra = new Button();
            btnAdicionar = new Button();
            btnRemoverProd = new Button();
            panelRemoverPd = new Panel();
            grpBoxRemoverPd = new GroupBox();
            btnNãoRemover = new Button();
            btnSimRemover = new Button();
            txtSenha = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panelRemoverPd.SuspendLayout();
            grpBoxRemoverPd.SuspendLayout();
            SuspendLayout();
            // 
            // btnAbrirCupom
            // 
            btnAbrirCupom.BackColor = Color.OrangeRed;
            btnAbrirCupom.Cursor = Cursors.Hand;
            btnAbrirCupom.FlatAppearance.BorderSize = 0;
            btnAbrirCupom.FlatStyle = FlatStyle.Flat;
            btnAbrirCupom.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrirCupom.ForeColor = Color.White;
            btnAbrirCupom.Location = new Point(13, 9);
            btnAbrirCupom.Name = "btnAbrirCupom";
            btnAbrirCupom.Size = new Size(151, 48);
            btnAbrirCupom.TabIndex = 76;
            btnAbrirCupom.Text = "ABRIR CUPOM";
            btnAbrirCupom.UseVisualStyleBackColor = false;
            btnAbrirCupom.Click += btnAbrirCupom_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblNomeProduto);
            panel1.Location = new Point(13, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 48);
            panel1.TabIndex = 75;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.BackColor = Color.FromArgb(255, 128, 0);
            lblNomeProduto.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeProduto.ForeColor = Color.White;
            lblNomeProduto.Location = new Point(7, 0);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(358, 42);
            lblNomeProduto.TabIndex = 43;
            lblNomeProduto.Text = "Nome do produto";
            lblNomeProduto.Click += lblNomeProduto_Click;
            // 
            // lblCaixaFechado
            // 
            lblCaixaFechado.Anchor = AnchorStyles.Top;
            lblCaixaFechado.AutoSize = true;
            lblCaixaFechado.Font = new Font("Arial Rounded MT Bold", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaixaFechado.ForeColor = Color.White;
            lblCaixaFechado.Location = new Point(375, 9);
            lblCaixaFechado.Name = "lblCaixaFechado";
            lblCaixaFechado.Size = new Size(383, 50);
            lblCaixaFechado.TabIndex = 74;
            lblCaixaFechado.Text = "CAIXA FECHADO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_400_X_399;
            pictureBox1.Location = new Point(13, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // lsvProdutos
            // 
            lsvProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvProdutos.Location = new Point(534, 156);
            lsvProdutos.Name = "lsvProdutos";
            lsvProdutos.Size = new Size(586, 338);
            lsvProdutos.TabIndex = 78;
            lsvProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(2, 111, 216);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(534, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 33);
            panel2.TabIndex = 79;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(2, 111, 216);
            label6.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(176, 4);
            label6.Name = "label6";
            label6.Size = new Size(234, 25);
            label6.TabIndex = 30;
            label6.Text = "LISTA DE PRODUTOS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(2, 111, 216);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(checkNotaFiscal);
            panel3.Location = new Point(341, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 35);
            panel3.TabIndex = 80;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(2, 111, 216);
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 8);
            label5.Name = "label5";
            label5.Size = new Size(116, 18);
            label5.TabIndex = 87;
            label5.Text = "NOTA FISCAL";
            label5.Click += label5_Click;
            // 
            // checkNotaFiscal
            // 
            checkNotaFiscal.Anchor = AnchorStyles.None;
            checkNotaFiscal.AutoSize = true;
            checkNotaFiscal.BackColor = Color.FromArgb(2, 111, 216);
            checkNotaFiscal.Cursor = Cursors.Hand;
            checkNotaFiscal.Location = new Point(154, 11);
            checkNotaFiscal.Name = "checkNotaFiscal";
            checkNotaFiscal.Size = new Size(15, 14);
            checkNotaFiscal.TabIndex = 86;
            checkNotaFiscal.UseVisualStyleBackColor = false;
            checkNotaFiscal.CheckedChanged += checkNotaFiscal_CheckedChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(2, 111, 216);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(341, 325);
            panel4.Name = "panel4";
            panel4.Size = new Size(177, 35);
            panel4.TabIndex = 81;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(2, 111, 216);
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 87;
            label2.Tag = "";
            label2.Text = "QUANTIDADE";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(2, 111, 216);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(341, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(177, 35);
            panel5.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(2, 111, 216);
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 10);
            label1.Name = "label1";
            label1.Size = new Size(82, 18);
            label1.TabIndex = 86;
            label1.Text = "CÓDIGO ";
            // 
            // mskdNotaFiscal
            // 
            mskdNotaFiscal.BackColor = Color.FromArgb(2, 111, 216);
            mskdNotaFiscal.BorderStyle = BorderStyle.FixedSingle;
            mskdNotaFiscal.Enabled = false;
            mskdNotaFiscal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            mskdNotaFiscal.ForeColor = Color.White;
            mskdNotaFiscal.Location = new Point(341, 161);
            mskdNotaFiscal.Mask = "000.000.000-00";
            mskdNotaFiscal.Name = "mskdNotaFiscal";
            mskdNotaFiscal.Size = new Size(177, 39);
            mskdNotaFiscal.TabIndex = 83;
            mskdNotaFiscal.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(2, 111, 216);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.White;
            txtCodigo.Location = new Point(341, 260);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(177, 39);
            txtCodigo.TabIndex = 84;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.FromArgb(2, 111, 216);
            txtQuantidade.BorderStyle = BorderStyle.FixedSingle;
            txtQuantidade.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.ForeColor = Color.White;
            txtQuantidade.Location = new Point(341, 359);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(177, 39);
            txtQuantidade.TabIndex = 85;
            txtQuantidade.TextAlign = HorizontalAlignment.Center;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // lblValoUnitario
            // 
            lblValoUnitario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblValoUnitario.AutoSize = true;
            lblValoUnitario.BackColor = Color.FromArgb(250, 114, 4);
            lblValoUnitario.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblValoUnitario.ForeColor = Color.White;
            lblValoUnitario.Location = new Point(400, 541);
            lblValoUnitario.Name = "lblValoUnitario";
            lblValoUnitario.Size = new Size(103, 25);
            lblValoUnitario.TabIndex = 88;
            lblValoUnitario.Text = "R$ 0,00";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(250, 114, 4);
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(351, 517);
            label4.Name = "label4";
            label4.Size = new Size(152, 18);
            label4.TabIndex = 87;
            label4.Text = "VALOR UNITÁRIO";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox5.BackColor = Color.FromArgb(250, 114, 4);
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Location = new Point(348, 509);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(177, 67);
            pictureBox5.TabIndex = 86;
            pictureBox5.TabStop = false;
            // 
            // lblTotalItem
            // 
            lblTotalItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalItem.AutoSize = true;
            lblTotalItem.BackColor = Color.FromArgb(250, 114, 4);
            lblTotalItem.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalItem.ForeColor = Color.White;
            lblTotalItem.Location = new Point(400, 625);
            lblTotalItem.Name = "lblTotalItem";
            lblTotalItem.Size = new Size(103, 25);
            lblTotalItem.TabIndex = 91;
            lblTotalItem.Text = "R$ 0,00";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(250, 114, 4);
            label15.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(351, 599);
            label15.Name = "label15";
            label15.Size = new Size(137, 18);
            label15.TabIndex = 90;
            label15.Text = "TOTAL DO ITEM";
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox10.BackColor = Color.FromArgb(250, 114, 4);
            pictureBox10.BorderStyle = BorderStyle.Fixed3D;
            pictureBox10.Location = new Point(348, 591);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(177, 67);
            pictureBox10.TabIndex = 89;
            pictureBox10.TabStop = false;
            // 
            // lblTroco
            // 
            lblTroco.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.FromArgb(250, 114, 4);
            lblTroco.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTroco.ForeColor = Color.White;
            lblTroco.Location = new Point(938, 617);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(142, 35);
            lblTroco.TabIndex = 100;
            lblTroco.Text = "R$ 0,00";
            // 
            // lblTotalRecebido
            // 
            lblTotalRecebido.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRecebido.AutoSize = true;
            lblTotalRecebido.BackColor = Color.FromArgb(250, 114, 4);
            lblTotalRecebido.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalRecebido.ForeColor = Color.White;
            lblTotalRecebido.Location = new Point(660, 619);
            lblTotalRecebido.Name = "lblTotalRecebido";
            lblTotalRecebido.Size = new Size(142, 35);
            lblTotalRecebido.TabIndex = 99;
            lblTotalRecebido.Text = "R$ 0,00";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(250, 114, 4);
            label11.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(862, 598);
            label11.Name = "label11";
            label11.Size = new Size(78, 23);
            label11.TabIndex = 98;
            label11.Tag = "";
            label11.Text = "TROCO";
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox8.BackColor = Color.FromArgb(250, 114, 4);
            pictureBox8.BorderStyle = BorderStyle.Fixed3D;
            pictureBox8.Location = new Point(854, 591);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(266, 67);
            pictureBox8.TabIndex = 97;
            pictureBox8.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(250, 114, 4);
            label10.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(535, 596);
            label10.Name = "label10";
            label10.Size = new Size(187, 23);
            label10.TabIndex = 96;
            label10.Tag = "";
            label10.Text = " TOTAL RECEBIDO";
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox7.BackColor = Color.FromArgb(250, 114, 4);
            pictureBox7.BorderStyle = BorderStyle.Fixed3D;
            pictureBox7.Location = new Point(534, 591);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(308, 67);
            pictureBox7.TabIndex = 95;
            pictureBox7.TabStop = false;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.FromArgb(250, 114, 4);
            lblSubtotal.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubtotal.ForeColor = Color.White;
            lblSubtotal.Location = new Point(910, 524);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(170, 42);
            lblSubtotal.TabIndex = 94;
            lblSubtotal.Text = "R$ 0,00";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(250, 114, 4);
            label7.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(546, 516);
            label7.Name = "label7";
            label7.Size = new Size(135, 25);
            label7.TabIndex = 93;
            label7.Text = "SUBTOTAL";
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.BackColor = Color.FromArgb(250, 114, 4);
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Location = new Point(534, 509);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(586, 67);
            pictureBox6.TabIndex = 92;
            pictureBox6.TabStop = false;
            // 
            // txtPagamento
            // 
            txtPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtPagamento.BackColor = Color.White;
            txtPagamento.BorderStyle = BorderStyle.FixedSingle;
            txtPagamento.Enabled = false;
            txtPagamento.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPagamento.ForeColor = Color.Black;
            txtPagamento.Location = new Point(179, 555);
            txtPagamento.Name = "txtPagamento";
            txtPagamento.Size = new Size(143, 35);
            txtPagamento.TabIndex = 103;
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbFormaPagamento.BackColor = Color.White;
            cmbFormaPagamento.Enabled = false;
            cmbFormaPagamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Items.AddRange(new object[] { "Dinhero", "Credito", "Debito" });
            cmbFormaPagamento.Location = new Point(11, 557);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(151, 33);
            cmbFormaPagamento.TabIndex = 101;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel6.BackColor = Color.FromArgb(2, 111, 216);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label18);
            panel6.Location = new Point(11, 509);
            panel6.Name = "panel6";
            panel6.Size = new Size(151, 50);
            panel6.TabIndex = 102;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(2, 111, 216);
            label16.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(27, 4);
            label16.Name = "label16";
            label16.Size = new Size(99, 18);
            label16.TabIndex = 61;
            label16.Text = "FORMA DE ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(2, 111, 216);
            label18.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(19, 26);
            label18.Name = "label18";
            label18.Size = new Size(110, 18);
            label18.TabIndex = 68;
            label18.Text = "PAGAMENTO";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel7.BackColor = Color.FromArgb(2, 111, 216);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label19);
            panel7.Location = new Point(179, 509);
            panel7.Name = "panel7";
            panel7.Size = new Size(143, 50);
            panel7.TabIndex = 104;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(2, 111, 216);
            label19.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(15, 13);
            label19.Name = "label19";
            label19.Size = new Size(110, 18);
            label19.TabIndex = 69;
            label19.Tag = "";
            label19.Text = "PAGAMENTO";
            // 
            // btnPagar
            // 
            btnPagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPagar.BackColor = Color.SpringGreen;
            btnPagar.BackgroundImageLayout = ImageLayout.None;
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.Black;
            btnPagar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagar.Location = new Point(11, 610);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(151, 48);
            btnPagar.TabIndex = 106;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFinalizarCompra.BackColor = Color.OrangeRed;
            btnFinalizarCompra.BackgroundImageLayout = ImageLayout.None;
            btnFinalizarCompra.Cursor = Cursors.Hand;
            btnFinalizarCompra.FlatAppearance.BorderSize = 0;
            btnFinalizarCompra.FlatStyle = FlatStyle.Flat;
            btnFinalizarCompra.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizarCompra.ForeColor = Color.White;
            btnFinalizarCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarCompra.Location = new Point(178, 610);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(144, 48);
            btnFinalizarCompra.TabIndex = 105;
            btnFinalizarCompra.Text = "FINALIZAR ";
            btnFinalizarCompra.UseVisualStyleBackColor = false;
            btnFinalizarCompra.Click += btnFinalizarCompra_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.SpringGreen;
            btnAdicionar.BackgroundImageLayout = ImageLayout.None;
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Image = Properties.Resources.icons8_add_24;
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(355, 418);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(10, 0, 0, 0);
            btnAdicionar.Size = new Size(151, 48);
            btnAdicionar.TabIndex = 107;
            btnAdicionar.Text = "   ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemoverProd
            // 
            btnRemoverProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemoverProd.BackColor = Color.SpringGreen;
            btnRemoverProd.BackgroundImageLayout = ImageLayout.None;
            btnRemoverProd.Cursor = Cursors.Hand;
            btnRemoverProd.FlatAppearance.BorderSize = 0;
            btnRemoverProd.FlatStyle = FlatStyle.Flat;
            btnRemoverProd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverProd.ForeColor = Color.Black;
            btnRemoverProd.Image = Properties.Resources.icons8_delete_24;
            btnRemoverProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemoverProd.Location = new Point(969, 9);
            btnRemoverProd.Name = "btnRemoverProd";
            btnRemoverProd.Padding = new Padding(10, 0, 0, 0);
            btnRemoverProd.Size = new Size(151, 48);
            btnRemoverProd.TabIndex = 108;
            btnRemoverProd.Text = "   REMOVER";
            btnRemoverProd.UseVisualStyleBackColor = false;
            btnRemoverProd.Click += btnRemoverProd_Click;
            // 
            // panelRemoverPd
            // 
            panelRemoverPd.Controls.Add(grpBoxRemoverPd);
            panelRemoverPd.Location = new Point(11, 126);
            panelRemoverPd.Name = "panelRemoverPd";
            panelRemoverPd.Size = new Size(311, 340);
            panelRemoverPd.TabIndex = 109;
            panelRemoverPd.Visible = false;
            // 
            // grpBoxRemoverPd
            // 
            grpBoxRemoverPd.Controls.Add(btnNãoRemover);
            grpBoxRemoverPd.Controls.Add(btnSimRemover);
            grpBoxRemoverPd.Controls.Add(txtSenha);
            grpBoxRemoverPd.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpBoxRemoverPd.ForeColor = SystemColors.ActiveCaptionText;
            grpBoxRemoverPd.Location = new Point(14, 75);
            grpBoxRemoverPd.Name = "grpBoxRemoverPd";
            grpBoxRemoverPd.Size = new Size(284, 185);
            grpBoxRemoverPd.TabIndex = 0;
            grpBoxRemoverPd.TabStop = false;
            grpBoxRemoverPd.Text = "Remover Produto";
            // 
            // btnNãoRemover
            // 
            btnNãoRemover.BackColor = Color.Black;
            btnNãoRemover.Cursor = Cursors.Hand;
            btnNãoRemover.FlatAppearance.BorderSize = 0;
            btnNãoRemover.FlatStyle = FlatStyle.Flat;
            btnNãoRemover.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNãoRemover.ForeColor = Color.White;
            btnNãoRemover.Location = new Point(154, 105);
            btnNãoRemover.Name = "btnNãoRemover";
            btnNãoRemover.Size = new Size(95, 43);
            btnNãoRemover.TabIndex = 78;
            btnNãoRemover.Text = "NÃO";
            btnNãoRemover.UseVisualStyleBackColor = false;
            btnNãoRemover.Click += btnNãoRemover_Click;
            // 
            // btnSimRemover
            // 
            btnSimRemover.BackColor = Color.Black;
            btnSimRemover.Cursor = Cursors.Hand;
            btnSimRemover.FlatAppearance.BorderSize = 0;
            btnSimRemover.FlatStyle = FlatStyle.Flat;
            btnSimRemover.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimRemover.ForeColor = Color.White;
            btnSimRemover.Location = new Point(30, 105);
            btnSimRemover.Name = "btnSimRemover";
            btnSimRemover.Size = new Size(98, 43);
            btnSimRemover.TabIndex = 77;
            btnSimRemover.Text = "SIM";
            btnSimRemover.UseVisualStyleBackColor = false;
            btnSimRemover.Click += btnSimRemover_Click;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(30, 60);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Digite a Senha";
            txtSenha.Size = new Size(219, 39);
            txtSenha.TabIndex = 0;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // UC_Caixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 169, 63);
            Controls.Add(panelRemoverPd);
            Controls.Add(btnRemoverProd);
            Controls.Add(btnAdicionar);
            Controls.Add(txtPagamento);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(btnPagar);
            Controls.Add(btnFinalizarCompra);
            Controls.Add(lblTroco);
            Controls.Add(lblTotalRecebido);
            Controls.Add(label11);
            Controls.Add(pictureBox8);
            Controls.Add(label10);
            Controls.Add(pictureBox7);
            Controls.Add(lblSubtotal);
            Controls.Add(label7);
            Controls.Add(pictureBox6);
            Controls.Add(lblTotalItem);
            Controls.Add(label15);
            Controls.Add(pictureBox10);
            Controls.Add(lblValoUnitario);
            Controls.Add(label4);
            Controls.Add(pictureBox5);
            Controls.Add(txtQuantidade);
            Controls.Add(txtCodigo);
            Controls.Add(mskdNotaFiscal);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lsvProdutos);
            Controls.Add(pictureBox1);
            Controls.Add(btnAbrirCupom);
            Controls.Add(panel1);
            Controls.Add(lblCaixaFechado);
            Name = "UC_Caixa";
            Size = new Size(1130, 667);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panelRemoverPd.ResumeLayout(false);
            grpBoxRemoverPd.ResumeLayout(false);
            grpBoxRemoverPd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirCupom;
        private Panel panel1;
        private Label lblNomeProduto;
        private Label lblCaixaFechado;
        private PictureBox pictureBox1;
        private ListView lsvProdutos;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private CheckBox checkNotaFiscal;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private Label label1;
        private MaskedTextBox mskdNotaFiscal;
        private TextBox txtCodigo;
        private TextBox txtQuantidade;
        private Label label6;
        private Label lblValoUnitario;
        private Label label4;
        private PictureBox pictureBox5;
        private Label lblTotalItem;
        private Label label15;
        private PictureBox pictureBox10;
        private Label lblTroco;
        private Label lblTotalRecebido;
        private Label label11;
        private PictureBox pictureBox8;
        private Label label10;
        private PictureBox pictureBox7;
        private Label lblSubtotal;
        private Label label7;
        private PictureBox pictureBox6;
        private TextBox txtPagamento;
        private ComboBox cmbFormaPagamento;
        private Panel panel6;
        private Label label16;
        private Label label18;
        private Panel panel7;
        private Label label19;
        private Button btnPagar;
        private Button btnFinalizarCompra;
        private Button btnAdicionar;
        private Button btnRemoverProd;
        private Panel panelRemoverPd;
        private GroupBox grpBoxRemoverPd;
        private TextBox txtSenha;
        private Button btnSimRemover;
        private Button btnNãoRemover;
    }
}
