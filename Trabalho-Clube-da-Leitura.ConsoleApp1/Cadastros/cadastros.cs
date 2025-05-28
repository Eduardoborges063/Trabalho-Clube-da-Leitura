using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Clube_da_Leitura.ConsoleApp1.Módulo_de_Caixas;

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
            Console.WriteLine("Digite a quantidade de páginas: ");
            Console.WriteLine();
            Console.WriteLine("Ano de publicação: ");
            Console.WriteLine("Caixa(seleção obrigatória):");
            Console.WriteLine("Opções:drama, comédia, ficção científica, fantasia, terror, suspense, faroeste, romance e aventura");

            Console.WriteLine();
            
        }
        public void TelaCadastrarCaixa()
        {
            Console.WriteLine("vamos cadastrar uma caixa:");
            Console.WriteLine();
            Console.WriteLine("Digite o nome da caixa: ");
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de livros na caixa: ");
            Console.WriteLine();
            Console.WriteLine("Digite o tipo de caixa: ");
            Console.WriteLine("Opções: drama, comédia, ficção científica, fantasia, terror, suspense, faroeste, romance e aventura");
            Console.WriteLine();
            Console.WriteLine("Digite a Etiqueta(texto único, máximo 50 caracteres): ");
            Console.WriteLine();
            Console.WriteLine("Digite o prazo máximo para empréstimo de suas revistas(maximo 6 meses): ");

        }
        public void CadastrarCaixa()
        {
            Console.Clear();
            Caixas caixas = new Caixas();
            Caixas OpcoesDeCaixa;
            OpcoesDeCaixa = new Caixas();
            string nomeCaixa;
            int quantidadeLivros;
            string tipoCaixa;
            string etiqueta;
            int prazoMaximoEmprestimo;


        }
    }
}
