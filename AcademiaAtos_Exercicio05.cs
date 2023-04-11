namespace AcademiaAtos_Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5. Modifique o programa em VS anterior para aceitar votos nulos 
            // (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
            // Ao final, informe o nome do candidato vencedor, o número de votos nulos
            // e o número de pessoas que votaram.

            int votosJoao = 0, votosZeca = 0, votosBranco = 0, votosNulos = 0, votosTotais = 0;
            string voto;

            do
            {
                Console.Write("Digite seu voto (JOAO, ZECA, BRANCO ou NULO): ");
                voto = Console.ReadLine().ToUpper();

                switch (voto)
                {
                    case "JOAO":
                        votosJoao++;
                        votosTotais++;
                        break;
                    case "ZECA":
                        votosZeca++;
                        votosTotais++;
                        break;
                    case "BRANCO":
                        votosBranco++;
                        votosTotais++;
                        break;
                    case "NULO":
                        votosNulos++;
                        votosTotais++;
                        break;
                    case "FIM":
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Voto nulo registrado.");
                        votosNulos++;
                        votosTotais++;
                        break;
                }
            } while (voto != "FIM");

            Console.WriteLine("\nResultado da eleição:");
            Console.WriteLine($"JOAO: {votosJoao} votos");
            Console.WriteLine($"ZECA: {votosZeca} votos");
            Console.WriteLine($"Branco: {votosBranco} votos");
            Console.WriteLine($"Nulo: {votosNulos} votos");
            Console.WriteLine($"Total de votos: {votosTotais}");

            if (votosJoao > votosZeca)
            {
                Console.WriteLine("JOAO foi o candidato vencedor!");
            }
            else if (votosZeca > votosJoao)
            {
                Console.WriteLine("ZECA foi o candidato vencedor!");
            }
            else
            {
                Console.WriteLine("A eleição terminou empatada!");
            }
        }
    }
}