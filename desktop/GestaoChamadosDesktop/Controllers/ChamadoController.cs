using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestaoChamadosDesktop.Models;

namespace GestaoChamadosDesktop.Controllers
{
    public class ChamadoController
    {
        public void CriarChamado(Chamado chamado)
        {
            using (SqlConnection conexao = Conexao.Conectar())
            {
                string sql = "INSERT INTO Chamados (Titulo, Descricao, Status, Prioridade, Usuario, DataAbertura) VALUES (@Titulo, @Descricao, @Status, @Prioridade, @Usuario, @DataAbertura)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Titulo", chamado.Titulo);
                cmd.Parameters.AddWithValue("@Descricao", chamado.Descricao);
                cmd.Parameters.AddWithValue("@Status", chamado.Status);
                cmd.Parameters.AddWithValue("@Prioridade", chamado.Prioridade);
                cmd.Parameters.AddWithValue("@Usuario", chamado.Usuario);
                cmd.Parameters.AddWithValue("@DataAbertura", chamado.DataAbertura);
                cmd.ExecuteNonQuery();
                Conexao.Desconectar(conexao);
            }
        }

        public List<Chamado> ListarChamados()
        {
            List<Chamado> lista = new List<Chamado>();
            using (SqlConnection conexao = Conexao.Conectar())
            {
                string sql = "SELECT * FROM Chamados";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Chamado c = new Chamado
                    {
                        Id = reader.GetInt32(0),
                        Titulo = reader.GetString(1),
                        Descricao = reader.GetString(2),
                        Status = reader.GetString(3),
                        Prioridade = reader.GetString(4),
                        Usuario = reader.GetString(5),
                        DataAbertura = reader.GetDateTime(6),
                        DataFechamento = reader.IsDBNull(7) ? null : reader.GetDateTime(7)
                    };
                    lista.Add(c);
                }

                Conexao.Desconectar(conexao);
            }
            return lista;
        }
    }
}
