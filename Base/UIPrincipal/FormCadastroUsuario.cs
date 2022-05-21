using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        private bool inserindoNovo;
        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
        }
        public FormCadastroUsuario(object _current)
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _current;

            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();
                Inserir();
                MessageBox.Show("Cadastro realizado com sucesso");

                usuarioBindingSource.AddNew();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro!" + ex.Message);
            }
        }

        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();

            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;

           if(inserindoNovo)
            usuarioBLL.Inserir(usuario);
         else
            usuarioBLL.Alterar(usuario);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCadastraNovo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            Inserir();
            MessageBox.Show("Operação realizado com sucesso!");
            usuarioBindingSource.DataSource = typeof(Usuario);
            
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
            nomeUsuarioTextBox.Focus();

        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            nomeUsuarioTextBox.Focus();
        }

        private void FormCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
