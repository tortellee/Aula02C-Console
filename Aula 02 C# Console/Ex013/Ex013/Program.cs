using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crie um programa que descubra se um valor informado pelo usuário é maior ou menor que 10. Exiba na tela o resultado com uma mensagem amigável.
namespace Ex013
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int nd;

            //pede para usuario informar um numero
            Console.WriteLine("Informe um numero inteiro");
            nd = Convert.ToInt32(Console.ReadLine());

            //se numero digitado for maior que 10 entao é MAIOR 
            if (nd > 10)
            {
                Console.WriteLine("Numero informado é MAIOR que 10");
                            }
            //se numero digitado for menor que 10 entao é MENOR
            if (nd < 10)
            {
                Console.WriteLine("Numero informador é MENOR que 10");
            }
            //se numero digitado for 10 entao é 10
            if(nd ==10)
            {
                Console.WriteLine("Numero informador é 10");
            }

            //precionar qualquer tecla para sair do programa
            Console.ReadKey();

        }
    }
}
