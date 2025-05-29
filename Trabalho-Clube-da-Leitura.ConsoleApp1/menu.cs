using Trabalho_Clube_da_Leitura.ConsoleApp1.Cadastros;

public class Menu()
{
    public void TMenu()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|       Esse é o clube da leitura       |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Bem vindo");
        Console.WriteLine();
        Console.WriteLine("O que quer fazer:");
        Console.WriteLine("1 - Cadastrar livro");
        Console.WriteLine("2 - fazer seu cadastro");
        Console.WriteLine("3 - cadastrar caixa");
        Console.WriteLine("4 - Sair");

        Console.Write("\nDigite a opção desejada: ");
        Console.WriteLine("----------------------------------------");
        string opcao = Console.ReadLine();
        cadastros cadastros = new cadastros();
        switch (opcao)
        {

            case "1":
               
                cadastros.TelaCadastrarLivro(this);
                break;
            case "2":
              
               cadastros.TelaCadastrarUsuario(this);
                break;
            case "3":

                cadastros.TelaCadastrarCaixa(this);
                break;
            case "4":
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
   
}

