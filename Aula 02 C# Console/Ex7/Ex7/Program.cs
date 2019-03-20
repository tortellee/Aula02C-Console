using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*O custo de um carro novo ao consumidor é obtido com a seguinte fórmula:
custo final = custo de fábrica + (custo de fábrica * percentual do distribuidor) +
(custo de fábrica * percentual de impostos)

Considerando os valores abaixo, faça um programa para calcular o custo de fabricação.
Custo de fábrica = 10.000,00
Percentual do distribuidor = 28%
Percentual dos Impostos  = 45%
*/
namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {

            //variaveis
            double custofabrica, custofinal;

            //pedir para o usuario informar o valor de fabrica
            Console.WriteLine("Informe o valor do veiculo");
            custofabrica = Convert.ToDouble(Console.ReadLine());

            //formula de calculo
            custofinal = custofabrica + (custofabrica * 0.28) + (custofabrica * 0.45);

            //mostrar resultado final
            Console.WriteLine("Custo do veiculo com juros :"+custofinal);

            //precionar para sair
            Console.ReadKey();


        }
    }
}
