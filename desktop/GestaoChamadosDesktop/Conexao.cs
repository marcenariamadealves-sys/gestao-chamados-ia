using System.Data.SqlClient;

namespace GestaoChamadosDesktop
{
    public class Conexao
    {
        private static string conexaoString = "Data Source=localhost;Initial Catalog=GestaoChamadosDB;Integrated Security=True";

        public static SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            return conexao;
        }

        public static void Desconectar(SqlConnection conexao)
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
