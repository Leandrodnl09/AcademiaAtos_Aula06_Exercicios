using System.IO;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace AcademiaAtos_Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
            // certa região, a qual coletou os seguintes dados referentes a cada habitante para
            // serem analisados:
            // -sexo(masculino e feminino)
            // - cor dos olhos(azuis, verdes ou castanhos)
            // -cor dos cabelos(louros, castanhos, pretos)
            // -idade


            // Faça um algoritmo que determine e escreva:

            // -a maior idade dos habitantes
            // -a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
            // e que tenham olhos verdes e cabelos louros.
            // O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

            int maiorIdade = 0;
            int qtdMulheres = 0;

            while (true)
            {
                Console.Write("Digite a idade (-1 para encerrar): ");
                int idade = int.Parse(Console.ReadLine());

                if (idade == -1)
                {
                    break;
                }

                Console.Write("Digite o sexo (M ou F): ");
                char sexo = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Digite a cor dos olhos (A para azuis, V para verdes, C para castanhos): ");
                char corOlhos = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Digite a cor dos cabelos (L para louros, C para castanhos, P para pretos): ");
                char corCabelos = char.Parse(Console.ReadLine().ToUpper());

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }

                if (sexo == 'F' && idade >= 18 && idade <= 35 && corOlhos == 'V' && corCabelos == 'L')
                {
                    qtdMulheres++;
                }
            }

            Console.WriteLine("Maior idade: " + maiorIdade);
            Console.WriteLine("Quantidade de mulheres com olhos verdes, cabelos louros e idade entre 18 e 35 anos: " + qtdMulheres);
        }
    }
}