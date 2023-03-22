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
            else
            {
                string retorno = "";
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("Digite o primeiro número: ");
                _ = int.TryParse(Console.ReadLine(), out int N1);
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("Digite o segundo número: ");
                _ = int.TryParse(Console.ReadLine(), out int N2);
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("Os números " + Coprimos(N1, N2, retorno));

            }
            Console.ReadKey();
        }
        static public string Primos(int N , string check)
        {
            int i = 2, encerra = 0;
            do
            {
                if(N % 1 == 0 && N % N == 0)
                {
                    check = "é primo";
                }
                if (N % i == 0)
                {
                    check = "Não é primo";
                    encerra++;
                }
                else if(N == 1)
                {
                    check = "Não é primo";
                    encerra++;
                }
                else
                {
                    check = "Não é primo";
                    encerra++;
                }
                i++;
            } while (i < N && encerra != 1);
            
               

           
            
            return check;
        }

        static public string Coprimos(int N1, int N2, string retorno)
        {
            int i = 2, j = 2, encerra = 0;
            do
            {
                if (N1 % 1 == 0 && N2 % 1 == 0)
                {
                    retorno = "são primos entre si";
                   
                }
                if (N1 % i == 0 && N2 % i == 0)
                {
                    retorno = "não são primos entre si";
                    encerra++;
                }
                i++;
                j++;



            } while (i <= N1 && encerra != 1);
            return retorno;

        }
    }
}
