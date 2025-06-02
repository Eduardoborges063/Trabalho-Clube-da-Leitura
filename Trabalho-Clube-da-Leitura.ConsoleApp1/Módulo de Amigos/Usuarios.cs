using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Clube_da_Leitura.ConsoleApp1.Módulo_de_Amigos
{
    public class Usuarios
    {
        public void TUsuario()
        {
            FUsuario();

            Console.Clear();
            Console.WriteLine($"Bem-vindo {this}");
            Console.WriteLine();
            Console.WriteLine("Vamos ler?");
            Console.WriteLine();
            Console.WriteLine("1 - caixas");
            Console.WriteLine();
            Console.WriteLine("2 - livros");
            Console.WriteLine();
            Console.WriteLine("3 - sair");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();

        }
        public string FUsuario()
        {
            string opcoa = Console.ReadLine();
            switch (opcoa)
            {
                case "1":
                    Console.WriteLine("Vamos ver caixas.");
                    VCaixa();
                    break;

                case "2":
                    Console.WriteLine("Vamos ler.");
                    lerLivro();

                    break;
                case "3":
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;

            }
            Console.ReadLine();
            Console.Clear();
            return opcoa;
        }
        public void VCaixa()
        {

            Console.WriteLine("vamos escolher uma caixa:");
            Console.WriteLine("1 - Drama");
            Console.WriteLine("2 - Comédia");
            Console.WriteLine("3 - Ficção Científica");
            Console.WriteLine("4 - Fantasia");
            Console.WriteLine("5 - Terror");
            Console.WriteLine("6 - Suspense");
            Console.WriteLine("7 - Faroeste");
            Console.WriteLine("8 - Romance");
            Console.WriteLine("9 - Aventura");
            Console.WriteLine("10 - Voltar ao menu principal");
            Console.ReadLine();
        }
        public void SCaixa()
        {
           string opcoa = Console.ReadLine();
            switch (opcoa)
            {
                case "1":
                    Console.WriteLine("Caixa de Drama selecionada.");
                    break;
                case "2":
                    Console.WriteLine("Caixa de Comédia selecionada.");
                    break;
                case "3":
                    Console.WriteLine("Caixa de Ficção Científica selecionada.");
                    break;
                case "4":
                    Console.WriteLine("Caixa de Fantasia selecionada.");
                    break;
                case "5":
                    Console.WriteLine("Caixa de Terror selecionada.");
                    break;
                case "6":
                    Console.WriteLine("Caixa de Suspense selecionada.");
                    break;
                case "7":
                    Console.WriteLine("Caixa de Faroeste selecionada.");
                    break;
                case "8":
                    Console.WriteLine("Caixa de Romance selecionada.");
                    break;
                case "9":
                    Console.WriteLine("Caixa de Aventura selecionada.");
                    break;
                case "10":
                    Console.WriteLine("Voltando ao menu principal...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }
        public void lerLivro()
        {
            Console.WriteLine("você tem esses livros");
            //Console.WriteLine(Seuslivros);
            Console.ReadLine();
        }
    }
}
