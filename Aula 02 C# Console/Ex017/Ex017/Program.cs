using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Faça um algoritmo que mostre na tela todos os números entre 1 e 100.
namespace Ex017
{
    class Program
    {
        static void Main(string[] args)
        {

            //variaveis
            int n1;

            //consiçao enquanto n1 = 0 for menor que 101, ele adiciona um numero ate chegar no 100
            for (n1 = 0; n1 < 101; n1++)
            {
                Console.WriteLine("Numero: "+n1);             
            }

            //precionar para sair
            Console.ReadKey();
        }
    }
}
