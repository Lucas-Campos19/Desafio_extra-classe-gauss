using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_extra_classe_gauss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            do
            {
                Console.WriteLine("Escolha o exercicio");
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("1 - números primos                        2 - números primos entre si");
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("Digite apenas o número 1 ou 2 para escolher um dos problemas: ");
                var converteu = int.TryParse(Console.ReadLine(), out escolha);
            } while (escolha != 1 && escolha != 2);

            if(escolha == 1)
            {
                string check = "";
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("Digite um número para verificar se este será primo ou não: ");
                _= int.TryParse(Console.ReadLine(), out int N);
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("O número escolhido " + Primos(N,check));
            }
            Console.ReadKey();
        }
        static public string Primos(int N , string check)
        {
            if (N % 2 == 0 && N != 2)
            {
                
                check = "não é primo";
            }
            else if(N == 1)
            {
                check = "não é primo"; 

            }
            else if(N % 3 == 0 && N != 3)
            {
               
                check = "não é primo";

            }
            else if (N % 5 == 0 && N != 5)
            {
                
                check = "não é primo";

            }
            else if (N % 7 == 0 && N != 7)
            {
                
                check = "não é primo";

            }
            else if (N % 11 == 0 && N != 11)
            {
                check = "não é primo";

            }
            else
            {
                check = "é primo";
            }
            return check;
            
        }
    }
}
