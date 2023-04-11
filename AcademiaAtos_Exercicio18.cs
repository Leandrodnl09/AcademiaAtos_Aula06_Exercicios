namespace AcademiaAtos_Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
            // elevada a um expoente qualquer, ou seja, N , M.

            Console.Write("Digite a base da potência: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente da potência: ");
            int expoente = int.Parse(Console.ReadLine());

            int resultado = 1;
            for (int i = 0; i < expoente; i++)
            {
                resultado *= baseNum;
            }

            Console.WriteLine($"O resultado de {baseNum} elevado a {expoente} é {resultado}");
        }
    }
}