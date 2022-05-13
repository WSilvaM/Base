using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
    public class UsuarioBLL
    {
       public void Inserir()
        {
            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "joão";
            usuario.Senha = "asf123";
            usuario.Ativo = true;

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(usuario);
        }

        public void Excluir()
        {

        }
        public void Alterar()
        {

        }
        public List<Usuario> Buscar ()
        {
            return new List<Usuario>();
        }

    }
}
