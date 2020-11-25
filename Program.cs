using System;

namespace Condicionais_Eleitorado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleições");
            Console.WriteLine("Você está elegível para votação?\n");

            Console.WriteLine("Digite o ano Vigente: ");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano de Nascimento: ");
            int anoNasc = int.Parse(Console.ReadLine());

            int idade= anoAtual - anoNasc;

            if(idade >=16){
                Console.WriteLine("Você está elegível para votar este ano");
            }
            
            else{
                Console.WriteLine("Você NÃO está elegível para votar este ano");
            }


        }
    }
}
