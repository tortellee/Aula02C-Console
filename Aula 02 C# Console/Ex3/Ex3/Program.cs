using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escreva um programa para mostrar o sucessor e o antecessor de um número qualquer informado pelo usuário. 
//Exiba na tela nos números seguindo o exemplo da mensagem: “O antecessor do número 10 é 9, e o sucessor é 11.”.
namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int nd, ant , suce;
            string nome;

            //pedir nome do usuario
            Console.WriteLine("Informe seu nome");
            nome = (Console.ReadLine());

            //pedir numero inteiro para o +nome
            Console.WriteLine("Informe um numero inteiro");
            nd = Convert.ToInt32(Console.ReadLine());

            //formula
            ant = (nd - 1);
            suce = (nd + 1);

            //mostrar na tela o resultado
            Console.WriteLine(nome+ " o antecessor do numero " +nd+ " é: " + ant);
            Console.WriteLine(" ");
            Console.WriteLine(nome+ " o sucessor do numero " + nd + " é: " + suce);

            //esperando usuario a precionar tecla para exit
            Console.ReadKey();

        }
    }
}
