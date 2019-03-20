using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Faça um algoritmo que leia 5 números do teclado, e faça uma média.
namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double n1, n2, n3, n4, n5, media ;

            //pedir ao usuarios os cinco numeros
            Console.WriteLine("Informe o primeiro numero");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero");
            n2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe o terceiro numero");
            n3 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe o quarto numero");
            n4 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe o quinto numero");
            n5 = Convert.ToInt16(Console.ReadLine());

            //formula do calculo
            media = (n1 + n2 + n3 + n4 + n5) / 5;

            //mostrar para o usuario o resultado
            Console.WriteLine("A média é: " + media);

            //precionar para sair do programa
            Console.ReadKey();

        }
    }
}
