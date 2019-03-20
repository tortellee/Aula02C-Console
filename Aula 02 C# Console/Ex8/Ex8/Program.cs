using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Faça um programa para calcular o juros simples segundo a fórmula abaixo. Todas as informações devem ser solicitadas ao usuário.
J = C*i*n
Onde:
J = juros,
C = capital,
i = taxa de empréstimo
n = períodos
Exemplo: Vamos imaginar o seguinte cenário: um empréstimo de R$ 16.000,00 sobre a taxa de 4% durante 4 meses.
*/
namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {

            //variaves
            double juros, capital, taxae, periodo ;

            //pedir capital para usuario
            Console.WriteLine("Informe o capítal");
            capital = Convert.ToDouble(Console.ReadLine());

            //pedir a taxa de emprestimo
            Console.WriteLine("Informe a taxa de emprestimo");
            taxae = Convert.ToDouble(Console.ReadLine());

            //informar o periodo
            Console.WriteLine("Informe o pediodo em mes(es)");
            periodo = Convert.ToDouble(Console.ReadLine());

            //formula do calculo
            juros = (capital * taxae * periodo);

            //mostrar juros para o usuario
            Console.WriteLine("Taxa de juros: " + juros);

            //precionar para sair
            Console.ReadKey();
        }
    }
}
