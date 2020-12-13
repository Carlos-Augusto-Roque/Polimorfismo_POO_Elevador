using System;

namespace Polimorfismo_POO_Elevador.classes
{
    public class Elevador
    {

        public int [] totaldeAndares = new int[16];
        public int [] TotalDeAndares{
            get;set;
        }
        public int capacidadeElevador = 8;
        public int CapacidadeElevador{
            get;set;
        }

        public int posicaoAndar;
        public int PosicaoAndar{
            get;set;
        }


        public void Inicializa(int capacidadeElevador, int totaldeAndares){
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"O prédio tem {totaldeAndares} andares");
            Console.WriteLine($"A capacidade máxima do elevador Social é de: {capacidadeElevador} pessoas");
            Console.WriteLine("--------------------------------");
            Console.ResetColor();
            
        }
        
        
        public void Entrar(){
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Quantas pessoas estão no elevador ? : ");
            int pessoas = int.Parse(Console.ReadLine());
            Console.ResetColor();
            if(pessoas < this.capacidadeElevador){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Entrada Liberada!");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Capacidade esgotada ,aguarde até que o elevador retorne com vaga!");
                Console.ResetColor();
            }
        }
        
        public void Sair(){
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Quantas pessoas estão no elevador ? : ");
            Console.ResetColor();
            int pessoas = int.Parse(Console.ReadLine());
            if(pessoas != 0){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Saída liberada!");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ops!!! Elevador Vazio!!!");
                Console.ResetColor();
            }
        }

        public void Subir(){
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Em qual andar o elevador está ? : ");
            Console.ResetColor();
            posicaoAndar = int.Parse(Console.ReadLine());
            if(posicaoAndar <15 && posicaoAndar > 1){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Elevador subindo.......");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Elevador não pode subir pois já está no último andar!");
                Console.ResetColor();
            }
        }

        public void Descer(){
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Em qual andar o elevador está ? : ");
            Console.ResetColor();
            posicaoAndar = int.Parse(Console.ReadLine());
            if(posicaoAndar >0){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Elevador descendo....");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Elevador já está no térreo,não pode descer!");
                Console.ResetColor();
            }

        }

        
    }
}
// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:
// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);

// - Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
// - Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
// - Subir : para subir um andar (não deve subir se já estiver no último andar);
// - Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).