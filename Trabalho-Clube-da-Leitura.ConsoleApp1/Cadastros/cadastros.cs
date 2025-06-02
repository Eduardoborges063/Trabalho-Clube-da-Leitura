using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Clube_da_Leitura.ConsoleApp1.Módulo_de_Caixas;

namespace Trabalho_Clube_da_Leitura.ConsoleApp1.Cadastros
{
    public class Cadastros
    {
        public string TelaCadastrarUsuario(Menu TMenu)
        {
            string nomeUsuario;
            string nomeResponsavel;
            string telefoneResponsavel;

            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|      Vamos cadastrar você.            |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Digite seu nome: ");
            nomeUsuario = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Nome do responsável:");
            nomeResponsavel = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Telefone:");
            telefoneResponsavel = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" cadastrada(a/o) com sucesso! ");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
            Console.Clear();

          return nomeUsuario;
        }
        public void CadastrarUsuario()
        {
            string nomeUsuario;
            string nomeResponsavel;
            string telefoneResponsavel;
        }
        public void TelaCadastrarLivro(Menu TMenu)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|      Vamos cadastrar um livro.      |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Digite o nome do livro: ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Digite a quantidade de páginas: ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Ano de publicação: ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Caixa(seleção obrigatória):");
            Console.WriteLine("Opções:drama, comédia, ficção científica, fantasia, terror, suspense, faroeste, romance e aventura");
            Console.ReadLine();
            Console.WriteLine("----------------------------------------");


            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Livro cadastrada com sucesso! ");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
            Console.Clear();
            return;
        }
        public void CadastrarLivro()
        {
            string nomeLivro;
            int quantidadePaginas;
            int anoPublicacao;
            string tipoCaixa;
        }
        public void TelaCadastrarCaixa(Menu TMenu)
        {


            CadastrarCaixa();


            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|      Vamos cadastrar uma caixa.      |");
            Console.WriteLine("----------------------------------------");


            Console.WriteLine("Digite o nome da caixa: ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Digite a quantidade de livros na caixa(10 livros por caixa): ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Digite o tipo de caixa: ");
            Console.WriteLine("Opções: drama, comédia, ficção científica, fantasia, terror, suspense, faroeste, romance e aventura");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Digite a Etiqueta(texto único, máximo 50 caracteres): ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Digite o prazo máximo para empréstimo de suas revistas(maximo 6 meses): ");
            Console.ReadLine();
            Console.WriteLine("----------------------------------------");


            Console.WriteLine("----------------------------------------");
            Console.WriteLine("caixa cadastrada com sucesso! ");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
            Console.Clear();
            return;
        }
        public void CadastrarCaixa()
        {
            Caixas caixas = new Caixas();
            Caixas OpcoesDeCaixa;
            OpcoesDeCaixa = new Caixas();

            string nomeCaixa;
            int quantidadeLivros = 10; // Considerando 10 livros por caixa
            string tipoCaixa;
            string etiqueta;
            int prazoMaximoEmprestimo;

        }
    }
}
