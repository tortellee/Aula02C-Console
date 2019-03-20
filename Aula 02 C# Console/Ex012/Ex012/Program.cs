using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crie um programa que descubra se um valor informado pelo usuário é positivo ou negativo (considere o valor zero como positivo). Exiba na tela o resultado com uma mensagem amigável.
namespace Ex012
{
    class Program
    {
        static void Main(string[] args)
        {

            //variaveis
            int nd;

            //pede para o usuario informar um numero
            Console.WriteLine("informe um numero inteiro");
            nd = Convert.ToInt32(Console.ReadLine());

            //condiçao para saber se eh positivo ou negativo

            if(nd >= 0)
            {
                Console.WriteLine("Numero informado é POSITIVO");
            }
            else
            {
                Console.WriteLine("Numero informado é NEGATIVO");
            }

            //precionar para sair do programa
            Console.ReadKey();
        }
    }
}
