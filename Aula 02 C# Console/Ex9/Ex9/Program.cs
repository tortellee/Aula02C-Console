using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Faça um programa que calcule o reajuste de salário, solicite ao usuário o salário e a porcentagem a ser reajustado. Exemplo:
salário  = 1.000,00
reajuste = 15%
Salário Reajustado = 1.150,00*/

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {

            //variaveis
            double salario, porcentagem, reajustado;

            //pedir para o usuario informar o salario
            Console.WriteLine("Informe o salario");
            salario = Convert.ToDouble(Console.ReadLine());

            //pedir para o usuario informar a porcentagem
            Console.WriteLine("Informe a porcentagem");
            porcentagem = Convert.ToDouble(Console.ReadLine());

            //formula de calculo
            reajustado = (salario * porcentagem) / (100) + (salario);

            //informa o salario reajustado
            Console.WriteLine("Salario reajustado para: " + reajustado);

            //precionar para sair do programa
            Console.ReadKey();
        }
    }
}
