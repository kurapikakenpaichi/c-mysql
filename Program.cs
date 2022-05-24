using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;




namespace aula2405
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conexao = new MySqlConnection("server=mercado;database=hospital;uid=root;password=");
            try
            {
                conexao.Open();
            }
            catch
            (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("erro ao acessar o banco de dados, contate o administrador!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            String sql = "SELECT * FROM tbusuario";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("Id:{0} Nome:{1} Senha:{2}", rdr["id"], rdr["usuario"], rdr["senha"]);
                Console.ReadKey();
            }
            conexao.Close();
            Console.ReadKey();



            if (conexao.State == ConnectionState.Open)
            {



            }
            else
            {
                conexao.Open();
            }
            sql = "Insert into tbusuario value(null,@usuario,@senha)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@usuario", " j ");
            cmd.Parameters.AddWithValue("@senha", " j ");



            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("cadastrado com sucesso ");
                Console.ReadKey();
            }
        }
    }
}