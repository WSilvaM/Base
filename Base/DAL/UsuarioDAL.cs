using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public Usuario Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                //documento UDL
                cn.ConnectionString = @"User ID=sa;Initial Catalog=Loja;Data Source=.\SQLEXPRESS2019;Password=Senailab05";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirUsuario";

                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit)
                {
                    Value = _usuario.Ativo
                };


                cmd.Parameters.Add(pativo);

                cmd.Parameters.Add(new SqlParameter("@NomeUsuario", SqlDbType.VarChar) { Value = _usuario.NomeUsuario });


                SqlParameter psenha = new SqlParameter("@Senha", SqlDbType.VarChar)
                {
                    Value = _usuario.Senha
                };

                cmd.Parameters.Add(psenha);

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _usuario.Id

                };

                cmd.Parameters.Add(pid);

                cn.Open();
                _usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _usuario;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable Buscar(string _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = @"User ID = sa; Initial Catalog = Loja; Data Source =.\SQLEXPRESS2019; Password = Senailab05";
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarUsuario";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;
                da.SelectCommand.Parameters.Add(pfiltro);
                cn.Open();
                da.Fill(dt);
                return dt;


            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int _Id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"User ID=sa;Initial Catalog=Loja;Data Source=.\SQLEXPRESS2019;Password=Senailab05";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirUsuario";

                SqlParameter pid = new SqlParameter("Id", SqlDbType.Int);
                pid.Value = _Id;
                cmd.Parameters.Add(pid);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possivel excluir o usuário:" + _Id.ToString());

            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = @"User ID=sa;Initial Catalog=Loja;Data Source=.\SQLEXPRESS2019;Password=Senailab05";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarUsuario";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _usuario.Id;
                cmd.Parameters.Add(pid);


                SqlParameter pnomeUsuario = new SqlParameter("@NomeUsuario", SqlDbType.VarChar);
                pnomeUsuario.Value = _usuario.NomeUsuario;
                cmd.Parameters.Add(pnomeUsuario);


                SqlParameter psenha = new SqlParameter("@Senha", SqlDbType.VarChar);
                psenha.Value = _usuario.Senha;
                cmd.Parameters.Add(psenha);


                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit);
                pativo.Value = _usuario.Ativo;
                cmd.Parameters.Add(pativo);

                cn.Open();
                cmd.ExecuteNonQuery();
                return _usuario;


            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor sql Erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

