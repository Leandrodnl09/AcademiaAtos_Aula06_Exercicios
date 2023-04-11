namespace AcademiaAtos_Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14. Mostrar as potências de 2 variando de 0 a 10.

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"A potencia de 2 do valor {i} é: {Math.Pow(2, i)}");
            }
        }
    }
}