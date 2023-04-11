namespace AcademiaAtos_Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8. Faça um programa em VS que solicite um numero inteiro. Se
            // o numero não for inteiro, solicite - o até que seja.após, informe se ele é par ou impar.
            // Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

            int numero;
            bool inteiro;

            do
            {
                Console.Write("Digite um número inteiro: ");
                inteiro = int.TryParse(Console.ReadLine(), out numero);

                if (!inteiro)
                {
                    Console.WriteLine("O número digitado não é inteiro. Tente novamente.");
                }
            } while (!inteiro);

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar.", numero);
            }

        }
    }
}