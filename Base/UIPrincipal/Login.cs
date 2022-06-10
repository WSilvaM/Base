using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lab_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void exibeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            CadastroUsuarioo cadastroUsuarioo = new CadastroUsuarioo();
            cadastroUsuarioo.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
