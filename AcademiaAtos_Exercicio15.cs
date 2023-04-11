using System.Runtime.ConstrainedExecution;

namespace AcademiaAtos_Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
            // ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente.
            // Considerar nota 7,0 como mínima para aprovação.

            // Solicitando ao usuário que digite as notas
            Console.WriteLine("Digite a primeira nota:");
            var nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            var nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            var nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota:");
            var nota4 = double.Parse(Console.ReadLine());

            // Calculando a média ponderada das notas
            double media = (nota1 * 2 + nota2 * 1 + nota3 * 2 + nota4 * 4) / 9;

            // Verificando se o aluno está aprovado ou reprovado
            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado com média " + media.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Aluno reprovado com média " + media.ToString("F2"));
            }
        }
    }
}