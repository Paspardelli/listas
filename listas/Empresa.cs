using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class Empresa : Conexao
    {
        public int id;

        public int id_empresa;

        public string nome;

        public string email;

        private string senha;

        public int nivel;

        public DateTime data_cadastro;

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }

        public string GetSenha()
        {
            return this.senha;
        }

        public List<Empresa> GetListaEmpresa()
        {
            List<Empresa> Empresas = new List<Empresa>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM Empresas;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empresa novoEmpresa = new Empresa();

                            novoEmpresa.id = Convert.ToInt32(reader.GetString("id"));
                            novoEmpresa.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoEmpresa.nome = reader.GetString("nome");
                            novoEmpresa.email = reader.GetString("email");
                            novoEmpresa.nivel = Convert.ToInt32(reader.GetString("nivel"));
                            novoEmpresa.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            novoEmpresa.SetSenha(reader.GetString("senha"));

                            Empresas.Add(novoEmpresa);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return Empresas;
        }
    }
}
