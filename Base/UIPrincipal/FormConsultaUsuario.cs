using BLL;
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
    public partial class FormConsultaUsuario : Form
    {
        public FormConsultaUsuario()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
        }

        private void FormConsultaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormConsultaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                buttonSair_Click(null,null);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario()) 
            {
                frm.ShowDialog();
            }
        }

        private void usuarioDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Id"]);

            usuarioBLL.Excluir(id);
            usuarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluido com sucesso");
           // if(MessageBox.Show("Deseja realmente excluir este registro?","Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
            
                   
        
            return;

           //falta codigo aqui

        }
    }
}
