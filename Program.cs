using System;
using Polimorfismo_POO_Elevador.classes;

namespace Polimorfismo_POO_Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();
            elevador.Inicializa(8,16);
            
            string opcao;
            do
            {
               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Selecione uma das opções :");
                Console.WriteLine("[1] - Entrar");
                Console.WriteLine("[2] - Sair");
                Console.WriteLine("[3] - Subir");
                Console.WriteLine("[4] - Descer");
                Console.WriteLine("[0] - Sair do menu");
                opcao = Console.ReadLine();
                Console.ResetColor();

                switch(opcao)
                {
                    case "1":
                        elevador.Entrar();
                    return;

                    case "2":
                        elevador.Sair();
                    return;

                    case "3":
                        elevador.Subir();
                    return;

                    case "4":
                        elevador.Descer();
                    return;

                    case "0":
                        Console.WriteLine("Encerrado!");
                    return;

                    default:
                        Console.WriteLine("Opção inválida!");
                    break;
                }
                
                
            } while (opcao!= "0");

            
            


        }
    }
}

