using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Em um jogo de adivinhação, o jogador deve descobrir um número entre 1 e 10 usando até três tentativas. 
 * A cada tentativa o jogador é informado se o número foi descoberto, ou se ele é maior ou menor do que a tentativa. 
 * Se após três tentativas o jogador não descobrir o número, então ele perde o jogo. Faça um algoritmo que implemente esse jogo.*/
namespace Ex016
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int tent1, tent2, tent3;
            int ns = 8;

            //Explicaçao sobre o jogo e pergunta pelo numero
            Console.Write("Você deve descobrir um número entre 1 e 10 usando até três tentativas, Boa sorte !" + System.Environment.NewLine + "Qual o numero secreto ?");
            tent1 = Convert.ToInt32(Console.ReadLine());

            //primeira condiçao
            if (tent1 == ns)
            {
                Console.Write("PARABENS vc Acertou !");                
                
                //precionar para sair do programa
                Console.ReadKey();

                //forçar a sair
                Environment.Exit(0);
            }
            else
            {
                Console.Write("Você Errou !" + System.Environment.NewLine + "Tentativa 2" + System.Environment.NewLine + "Qual o numero secreto ?");
            }

            //tentativa 2
            tent2 = Convert.ToInt32(Console.ReadLine());

            //segunda condiçao
            if (tent2 == ns)
            {
                Console.Write("PARABENS vc Acertou !");                
                
                //precionar para sair do programa
                Console.ReadKey();

                //forçar a sair
                Environment.Exit(0);
            }
            else
            {
                Console.Write("Você Errou !" + System.Environment.NewLine + "ultima tentativa" + System.Environment.NewLine + "Qual o numero secreto ?");
            }

            //tentativa 3
            tent3 = Convert.ToInt32(Console.ReadLine());

            //terceira condiçao
            if (tent3 == ns)
            {
                Console.Write("PARABENS vc Acertou !");                
                
                //precionar para sair do programa
                Console.ReadKey();

                //forçar a sair
                Environment.Exit(0);
            }
            else
            {
                Console.Write("Você Errou !" + System.Environment.NewLine + "FIM DO JOGO !!!");
            }

            //precionar para sair do programa
            Console.ReadKey();
        }       
    }
}
