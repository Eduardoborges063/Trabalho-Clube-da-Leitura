using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Clube_da_Leitura.ConsoleApp1.Módulo_de_Empréstimos
{
    public class Emprestimo
    {
        public string NomeLivro;
        public string NomeUsuario;
        public string DataEmprestimo;
        public string DataDevolucao; 
        public void TEmprestimos()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|            Vamos emprestar.          |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("1 - Caixa");
            Console.WriteLine("2 - Livro");
            Console.WriteLine("3 - Devolver Livro");
            Console.WriteLine("4 - Devolver Caixa");
            Console.WriteLine("5 - Consultar Empréstimos");
            Console.WriteLine("6 - Excluir Empréstimo");
            Console.Write("Escolha uma opção: ");
            string escolha = Console.ReadLine(); 

            if (escolha == "2")
            {
                TelaEmprestarLivro(); 
            }
            else if (escolha == "1")
            {
                TelaEmprestarCaixa(); 
            }
            else if (escolha == "3")
            {
                TelaDevolverLivro(); 
            }
            else if (escolha == "4")
            {
                TelaDevolverCaixa();
            }
            else if (escolha == "5")
            {
                TelaConsultarEmprestimos();
            }
            else if (escolha == "6")
            {
                TelaExcluirEmprestimo();
            }
            else
            {
                Console.WriteLine("Opção inválida.");
                Console.ReadLine();
            }

        }
        public void TelaEmprestarLivro()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|      Vamos emprestar um livro.      |");
            Console.WriteLine("----------------------------------------");

            Console.Clear();
            Console.WriteLine("Digite o nome do livro:");
            string nomeLivro = Console.ReadLine();

            Console.WriteLine("Digite o nome do usuário:");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Data de empréstimo:");
            string dataEmprestimo = Console.ReadLine();

            Console.WriteLine("Data de devolução:");
            string dataDevolucao = Console.ReadLine();

            ListaDeEmprestimos.listaEmprestimos.Add(new Emprestimo
            {
                NomeLivro = nomeLivro,
                NomeUsuario = nomeUsuario,
                DataEmprestimo = dataEmprestimo,
                DataDevolucao = dataDevolucao
            });

            Console.WriteLine("✅ Empréstimo realizado com sucesso!");
            Console.ReadLine();
        }
        public void TelaEmprestarCaixa()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|      Vamos emprestar uma caixa.      |");
            Console.WriteLine("----------------------------------------");
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|      Vamos emprestar uma caixa.      |");
            Console.WriteLine("----------------------------------------");

            Console.Write("Digite o nome da caixa: ");
            string nomeCaixa = Console.ReadLine();

            Console.Write("Digite o nome do usuário: ");
            string nomeUsuario = Console.ReadLine();

            Console.Write("Data de empréstimo (dd/mm/aaaa): ");
            string dataEmprestimo = Console.ReadLine();

            Console.Write("Data de devolução (dd/mm/aaaa): ");
            string dataDevolucao = Console.ReadLine();

            ListaDeEmprestimos.listaEmprestimos.Add(new Emprestimo
            {
                NomeLivro = nomeCaixa, // reutilizando o campo NomeLivro para "caixa"
                NomeUsuario = nomeUsuario,
                DataEmprestimo = dataEmprestimo,
                DataDevolucao = dataDevolucao
            });

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("✅ Empréstimo de caixa realizado com sucesso!");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
        }
        public void TelaDevolverLivro()
        {
            
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|      Vamos devolver um livro.       |");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Digite o nome do livro: ");
            Console.WriteLine();
            Console.WriteLine("Digite o nome do usuário: ");
            Console.WriteLine();
            Console.WriteLine("Data de devolução (dd/mm/aaaa): ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" Devolução realizada com sucesso! ");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
        }
        public void TelaDevolverCaixa()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|      Vamos devolver uma caixa.       |");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Digite o nome da caixa: ");
            Console.WriteLine();
            Console.WriteLine("Digite o nome do usuário: ");
            Console.WriteLine();
            Console.WriteLine("Data de devolução (dd/mm/aaaa): ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" Devolução realizada com sucesso! ");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
        }
        public void TConsultarEmprestimos()
        {

            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|      Consultar Empréstimos           |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Lista de empréstimos: ");

            Console.WriteLine(NomeLivro);
            Console.WriteLine(NomeUsuario);
            Console.WriteLine(DataEmprestimo);
            Console.WriteLine(DataDevolucao);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
        }
        public void TelaExcluirEmprestimo()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do livro ou caixa:");
            string nomeLivro = Console.ReadLine();

            Console.WriteLine("Digite o nome do usuário:");
            string nomeUsuario = Console.ReadLine();

            var emprestimo = ListaDeEmprestimos.listaEmprestimos
                .FirstOrDefault(e => e.NomeLivro == nomeLivro && e.NomeUsuario == nomeUsuario);

            if (emprestimo != null)
            {
                ListaDeEmprestimos.listaEmprestimos.Remove(emprestimo);
                Console.WriteLine("✅ Empréstimo excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("❌ Empréstimo não encontrado.");
            }

            Console.ReadLine();
        }
        public void TelaConsultarEmprestimos()
        {
            Console.Clear();
            Console.WriteLine("📋 Lista de Empréstimos:");

            if (ListaDeEmprestimos.listaEmprestimos.Count == 0)
            {
                Console.WriteLine("Nenhum empréstimo registrado.");
            }
            else
            {
                foreach (var emp in ListaDeEmprestimos.listaEmprestimos)
                {
                    Console.WriteLine($"Usuário: {emp.NomeUsuario} | Livro/Caixa: {emp.NomeLivro} | De: {emp.DataEmprestimo} até {emp.DataDevolucao}");
                }
            }
            Console.ReadLine();
        }
    }
    public class ListaDeEmprestimos
    {
        public static List<Emprestimo> listaEmprestimos = new List<Emprestimo>();
    }
}
