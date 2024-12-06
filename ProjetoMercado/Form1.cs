using ProjetoMercado.UserControls;
using System.Runtime.ConstrainedExecution;

namespace ProjetoMercado
{
    public partial class frmMercado : Form
    {
        public frmMercado()
        {
            InitializeComponent();

            VerificaUser();
        }

        private void VerificaUser()
        {
            if (variaveisGlobais.Cargo == "Caixa") //Se no formsLogin for ele verificar o "Cargo" no banco e 
            {                                      // amarzenar na varivel global a função "Caixa", ele tem 2 restrições                                   // no sistema que é feita abaixo.
                btnCadastroUsuario.Visible = false;
                btnProdutoCadastrar.Visible = false;
            }
        }

        // Evento para add da forma correta o UC
        private void addUserControl(UserControl userControl)
        {
            // Faz o controle 'userControl' preencher todo o painelVisual.
            userControl.Dock = DockStyle.Fill;

            // Remove todos os controles atuais do painel 'panelVisual'.
            panelVisual.Controls.Clear();

            // Adiciona o 'userControl' ao painel.
            panelVisual.Controls.Add(userControl);

            // Garante que o 'userControl' fique na frente de outros controles no painel.
            userControl.BringToFront();
        }

        // Método para alterar a cor dos botões
        private void AlterarCorBotoes(Button botaoSelecionado)
        {
            // Definir a cor padrão para todos os botões
            CorPadraoButtons();

            // Mudar a cor do botão selecionado para laranja
            botaoSelecionado.BackColor = Color.FromArgb(250, 114, 4);
        }

        //Metodo que defini a cor padrão para todos os botões
        private void CorPadraoButtons()
        {
            btnCadastroUsuario.BackColor = Color.FromArgb(2, 111, 216);
            btnCaixa.BackColor = Color.FromArgb(2, 111, 216);
            btnProdutoCadastrar.BackColor = Color.FromArgb(2, 111, 216);
        }

        // Método para adicionar o UserControl no painel
        private void CarregarUserControl(UserControl userControl)
        {
            addUserControl(userControl);  // Chama o método que adiciona o UC no painel
        }

        // Evento do botão Cadastro de Usuário
        private void button3_Click(object sender, EventArgs e)
        {
            AlterarCorBotoes(btnCadastroUsuario); // Muda a cor do botão Cadastro de Usuário para laranja
            CarregarUserControl(new UC_UserCadastro()); // Carregar o UserControl de Cadastro de Usuário
        }

        // Evento do botão Caixa
        private void btnCaixa_Click(object sender, EventArgs e)
        {
            AlterarCorBotoes(btnCaixa); // Muda a cor do botão Caixa para laranja
            CarregarUserControl(new UC_Caixa()); // Carregar o UserControl de Caixa
        }

        // Evento do botão Cadastro de Produto
        private void btnProdutoCadastrar_Click(object sender, EventArgs e)
        {
            AlterarCorBotoes(btnProdutoCadastrar); // Muda a cor do botão Cadastro de Produto para laranja
            CarregarUserControl(new UC_ProdutoCadastro()); // Carregar o UserControl de Cadastro de Produto
        }

        // Evento do botão Home (imagem de Home)
        private void pictureHome_Click(object sender, EventArgs e)
        {
            CorPadraoButtons(); // Defini a cor padrão para todos os botões
            CarregarUserControl(new UC_Home()); // Carregar o UserControl de Home
        }

        private void FrmMercado_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.Show();
        }
    }
}