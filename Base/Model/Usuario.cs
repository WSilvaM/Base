using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        private string nomeUsuario;


        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }
        private bool ativo;
        public bool Ativo


        {
            get { return ativo; }
            set { ativo = value; }
        }
        private int id;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }





    }
}
