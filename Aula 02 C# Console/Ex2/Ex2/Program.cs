using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crie um programa que solicite ao usuário a temperatura em celsius e converta para fahrenheit. Exiba na tela o resultado com uma mensagem amigável.
Fórmula para cálculo:  F = 1.8 * Celsius + 32*/


namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double cel, convert;
            string nome;

            //pedir o nome do usuario
            Console.WriteLine("Informe o seu nome");
            nome = (Console.ReadLine());

            //pedir a temperatura em celsius para o usuario
            Console.WriteLine(nome + ", informe a temperatura em celsius");
            cel = Convert.ToDouble(Console.ReadLine());

            //formula do cálculo
            convert = (cel * 1.8) + 32;

            //informa a temperatura em fahrenheit
            Console.WriteLine("Convertido, a temperatura em fahrenheit é: " + convert);

            //esperando o usuario precionar tecla para exit
            Console.ReadKey();

        }
    }
}
