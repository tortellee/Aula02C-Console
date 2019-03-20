using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Faça um programa que calcule a média simples (aritmética) de 3 valores quaisquer informado pelo usuário. 
Utilize as variáveis  valor1, valor2 e valor3. Exiba a média na tela para o usuário.*/
namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double valor1, valor2, valor3, media;

            //Pedir ao usuario 3 valores quaisquer
            Console.WriteLine("Informe o primeiro valor");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor");
            valor3 = Convert.ToDouble(Console.ReadLine());

            //calculo para a média
            media = (valor1 + valor2 + valor3) / 3;

            //mostrar para o usuario a média
            Console.WriteLine("A média é: " + media);

            //precionar para sair
            Console.ReadKey();
        }
    }
}
