namespace ProjetoMercado.UserControls
{
    partial class UC_ProdutoCadastro
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
            txtMarca = new TextBox();
            label3 = new Label();
            txtValor = new TextBox();
            txtCodigo = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescricao = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureFoto = new PictureBox();
            listViewProd = new ListView();
            txtBuscarProduto = new TextBox();
            label9 = new Label();
            btnBuscar = new Button();
            btnAdicionar = new Button();
            btnAtualizar = new Button();
            btnRemoverFoto = new Button();
            btnProcurarFoto = new Button();
            btnRemoverProduto = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).BeginInit();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.BorderStyle = BorderStyle.None;
            txtMarca.Font = new Font("Segoe UI", 23.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(14, 222);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(258, 42);
            txtMarca.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 184);
            label3.Name = "label3";
            label3.Size = new Size(100, 35);
            label3.TabIndex = 62;
            label3.Text = "Marca:";
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.None;
            txtValor.Font = new Font("Segoe UI", 23.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(14, 432);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(258, 42);
            txtValor.TabIndex = 61;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Segoe UI", 23.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(14, 329);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(258, 42);
            txtCodigo.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 394);
            label5.Name = "label5";
            label5.Size = new Size(90, 35);
            label5.TabIndex = 59;
            label5.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 292);
            label2.Name = "label2";
            label2.Size = new Size(242, 35);
            label2.TabIndex = 58;
            label2.Text = "Código de Barras:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 79);
            label1.Name = "label1";
            label1.Size = new Size(147, 35);
            label1.TabIndex = 57;
            label1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.None;
            txtDescricao.Font = new Font("Segoe UI", 23.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.Location = new Point(14, 119);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(588, 42);
            txtDescricao.TabIndex = 56;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox1.Image = Properties.Resources.decoração_orange_01;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1130, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox2.Image = Properties.Resources.decoração_orange;
            pictureBox2.Location = new Point(0, 578);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1130, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            // 
            // pictureFoto
            // 
            pictureFoto.Image = Properties.Resources.logo_400_X_399;
            pictureFoto.Location = new Point(299, 171);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(303, 343);
            pictureFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFoto.TabIndex = 66;
            pictureFoto.TabStop = false;
            // 
            // listViewProd
            // 
            listViewProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewProd.Location = new Point(641, 171);
            listViewProd.Name = "listViewProd";
            listViewProd.Size = new Size(475, 343);
            listViewProd.TabIndex = 67;
            listViewProd.UseCompatibleStateImageBehavior = false;
            // 
            // txtBuscarProduto
            // 
            txtBuscarProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarProduto.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarProduto.Location = new Point(641, 119);
            txtBuscarProduto.Name = "txtBuscarProduto";
            txtBuscarProduto.Size = new Size(388, 43);
            txtBuscarProduto.TabIndex = 69;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Tahoma", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(641, 79);
            label9.Name = "label9";
            label9.Size = new Size(208, 35);
            label9.TabIndex = 68;
            label9.Text = "Buscar Produto";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Image = Properties.Resources.icons8_pesquisar_30;
            btnBuscar.Location = new Point(1035, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 43);
            btnBuscar.TabIndex = 70;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
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
            btnAdicionar.Location = new Point(67, 498);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(4, 0, 0, 0);
            btnAdicionar.Size = new Size(138, 55);
            btnAdicionar.TabIndex = 107;
            btnAdicionar.Text = "  Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAtualizar.BackColor = Color.SpringGreen;
            btnAtualizar.BackgroundImageLayout = ImageLayout.None;
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizar.ForeColor = Color.Black;
            btnAtualizar.Image = Properties.Resources.icons8_update_24;
            btnAtualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizar.Location = new Point(857, 522);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Padding = new Padding(4, 0, 0, 0);
            btnAtualizar.Size = new Size(122, 50);
            btnAtualizar.TabIndex = 108;
            btnAtualizar.Text = "   Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnRemoverFoto
            // 
            btnRemoverFoto.BackColor = Color.Black;
            btnRemoverFoto.BackgroundImageLayout = ImageLayout.None;
            btnRemoverFoto.Cursor = Cursors.Hand;
            btnRemoverFoto.FlatAppearance.BorderSize = 0;
            btnRemoverFoto.FlatStyle = FlatStyle.Flat;
            btnRemoverFoto.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverFoto.ForeColor = Color.White;
            btnRemoverFoto.Location = new Point(466, 522);
            btnRemoverFoto.Name = "btnRemoverFoto";
            btnRemoverFoto.Size = new Size(136, 39);
            btnRemoverFoto.TabIndex = 110;
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
            btnProcurarFoto.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProcurarFoto.ForeColor = Color.White;
            btnProcurarFoto.Location = new Point(299, 522);
            btnProcurarFoto.Name = "btnProcurarFoto";
            btnProcurarFoto.Size = new Size(161, 39);
            btnProcurarFoto.TabIndex = 109;
            btnProcurarFoto.Text = "Procurar Foto";
            btnProcurarFoto.UseVisualStyleBackColor = false;
            // 
            // btnRemoverProduto
            // 
            btnRemoverProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoverProduto.BackColor = Color.SpringGreen;
            btnRemoverProduto.BackgroundImageLayout = ImageLayout.None;
            btnRemoverProduto.Cursor = Cursors.Hand;
            btnRemoverProduto.FlatAppearance.BorderSize = 0;
            btnRemoverProduto.FlatStyle = FlatStyle.Flat;
            btnRemoverProduto.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverProduto.ForeColor = Color.Black;
            btnRemoverProduto.Image = Properties.Resources.icons8_delete_24;
            btnRemoverProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemoverProduto.Location = new Point(994, 522);
            btnRemoverProduto.Name = "btnRemoverProduto";
            btnRemoverProduto.Padding = new Padding(4, 0, 0, 0);
            btnRemoverProduto.Size = new Size(122, 50);
            btnRemoverProduto.TabIndex = 111;
            btnRemoverProduto.Text = "    Remover";
            btnRemoverProduto.UseVisualStyleBackColor = false;
            // 
            // UC_ProdutoCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 169, 63);
            Controls.Add(btnRemoverProduto);
            Controls.Add(btnAtualizar);
            Controls.Add(btnRemoverFoto);
            Controls.Add(btnProcurarFoto);
            Controls.Add(btnAdicionar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarProduto);
            Controls.Add(label9);
            Controls.Add(listViewProd);
            Controls.Add(pictureFoto);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(txtValor);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescricao);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "UC_ProdutoCadastro";
            Size = new Size(1130, 667);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarca;
        private Label label3;
        private TextBox txtValor;
        private TextBox txtCodigo;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox txtDescricao;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureFoto;
        private ListView listViewProd;
        private TextBox txtBuscarProduto;
        private Label label9;
        private Button btnBuscar;
        private Button btnAdicionar;
        private Button btnAtualizar;
        private Button btnRemoverFoto;
        private Button btnProcurarFoto;
        private Button btnRemoverProduto;
    }
}
