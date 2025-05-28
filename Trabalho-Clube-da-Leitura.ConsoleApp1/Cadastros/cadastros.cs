using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Clube_da_Leitura.ConsoleApp1.Cadastros
{
    internal class cadastros
    {
        public void TelaCadastrarUsuario()
        {
            Console.Clear();
            Console.WriteLine(" Vamos cadastrar Você.");
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: ");
            Console.WriteLine();
            Console.WriteLine("Nome do responsável:");
            Console.WriteLine();
            Console.WriteLine("Telefone:");
        }
        public void TelaCadastrarLivro()
        {
            Console.Clear();
            Console.WriteLine(" Vamos cadastrar um livro.");
            Console.WriteLine();
            Console.WriteLine("Digite o nome do livro: ");
            Console.WriteLine();
            Console.WriteLine("Digite o nome do autor: ");
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de páginas: ");
            Console.WriteLine();
            
        }
    }
}
