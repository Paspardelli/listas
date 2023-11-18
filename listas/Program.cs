using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente clientes = new Cliente();

            foreach ( Cliente cliente in clientes.GetListaCliente())
            {
                Console.WriteLine(cliente.GetClienteInfo());
                /*Console.WriteLine("ID: {0}", cliente.id);
                Console.WriteLine("ID empresa: {0}", cliente.id_empresa);
                Console.WriteLine("Nome: {0}", cliente.nome);
                Console.WriteLine("Telefone: {0}", cliente.telefone);
                Console.WriteLine("EMAIL: {0}", cliente.email);
                Console.WriteLine("Data Cadastro: {0}", cliente.data_cadastro);
                Console.WriteLine("Documento: {0}", cliente.GetDocumento());*/
                Console.WriteLine("---------------------------");
            }
            Funcionario funcionarios = new Funcionario();

            foreach (Funcionario funcionario in funcionarios.GetListaFuncionario())
            {
                //Console.WriteLine(funcionario.GetFuncionarioInfo());
                Console.WriteLine("ID: {0}", funcionario.id);
                Console.WriteLine("ID empresa: {0}", funcionario.id_empresa);
                Console.WriteLine("Nome: {0}", funcionario.nome);
                Console.WriteLine("EMAIL: {0}", funcionario.email);
                Console.WriteLine("Senha: {0}", funcionario.GetSenha());
                Console.WriteLine("Nível: {0}", funcionario.nivel);
                Console.WriteLine("Data Cadastro: {0}", funcionario.data_cadastro);
                Console.WriteLine("---------------------------");
            }
        }
    }
}


