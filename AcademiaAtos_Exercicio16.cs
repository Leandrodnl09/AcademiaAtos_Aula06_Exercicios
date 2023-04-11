namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
            // multiplicação sucessiva de N por 3 enquanto o produto for menor que 250
            // (N * 3; N * 3 * 3; N * 3 * 3 * 3; etc)

            Console.Write("Digite um número inteiro entre 1 e 50: ");
            int n = int.Parse(Console.ReadLine());

            while (n < 250)
            {
                Console.WriteLine(n);
                n *= 3;
            }
        }
    }
}