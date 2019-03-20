using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crie um programa que descubra se um valor informado pelo usuário é par ou ímpar. Exiba na tela o resultado com uma mensagem amigável.

namespace Ex011
{
    class Program
    {
        static void Main(string[] args)
        {

            //variaveis
            int nd;

            //pedir numero ao usuario
            Console.WriteLine("Informe um numero inteiro");
            nd = Convert.ToInt16(Console.ReadLine());

            //calculo para saber se eh par ou impar
            if (nd % 2 == 0)
            {
                Console.WriteLine(nd + " É PAR");
            }
            else
            {
                Console.WriteLine(nd+ " É IMPAR");
            }

            //precionar para sair do programa
            Console.ReadKey();
        }
    }
}
