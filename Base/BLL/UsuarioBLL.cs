using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
    public class UsuarioBLL
    {
       public void Inserir(Usuario _usuario)
        {
            

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
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
