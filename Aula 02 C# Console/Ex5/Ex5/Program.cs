using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Considerando que todos os meses tenham 30 dias, calcular o total de dias de n meses informado pelo usuário. Exibir na tela o resultado do cálculo com uma mensagem amigável.
namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            //variaveis
            int meses, total;

            //pedir para usuario informar os meses
            Console.WriteLine("Informe o total de mes(es)");
            meses = Convert.ToInt16(Console.ReadLine());

            //calculo
            total = (meses * 30);

            //informar o resultado
            Console.WriteLine("Total de dias é: " + total);

            //precionar para sair
            Console.ReadKey();


        }
    }
}
