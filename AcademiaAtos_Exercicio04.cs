using System.Diagnostics.Metrics;

namespace AcademiaAtos_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
            // Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            // Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
            // Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            // escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
            // de votos em branco.

            int votosJoao = 0, votosZeca = 0, votosBranco = 0;
            string voto;

            do
            {
                Console.Write("Digite o voto (JOAO, ZECA ou BRANCO): ");
                voto = Console.ReadLine().ToUpper();

                switch (voto)
                {
                    case "JOAO":
                        votosJoao++;
                        break;
                    case "ZECA":
                        votosZeca++;
                        break;
                    case "BRANCO":
                        votosBranco++;
                        break;
                    case "FIM":
                        Console.WriteLine("Encerrando a votação...");
                        break;
                    default:
                        Console.WriteLine("Voto inválido.");
                        break;
                }
            } while (voto != "FIM");

            Console.WriteLine("Total de votos do João: " + votosJoao);
            Console.WriteLine("Total de votos do Zeca: " + votosZeca);
            Console.WriteLine("Total de votos em branco: " + votosBranco);
        }
    }
}