using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Clube_da_Leitura.ConsoleApp1.Módulo_de_Empréstimos
{
    internal class Empretimos
    {
        public void TelaEmprestarLivro()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|      Vamos emprestar um livro.      |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Digite o nome do livro: ");
            string nomeLivro = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o nome do usuário: ");
            string nomeUsuario = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Data de empréstimo (dd/mm/aaaa): ");
            string dataEmprestimo = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Data de devolução (dd/mm/aaaa): ");
            string dataDevolucao = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" Empréstimo realizado com sucesso! ");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
        }
    }
}
