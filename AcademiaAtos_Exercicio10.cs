using System.Threading.Channels;

namespace AcademiaAtos_Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
            // Número de pessoas do sexo masculino.
            // Número de pessoas do sexo feminino.
            // Número de pessoas com idade inferior a 30 anos.
            // Número de pessoas com idade superior a 60 anos.
            // Média de idade das mulheres.

            int numHomens = 0;
            int numMulheres = 0;
            int numIdadeInferior30 = 0;
            int numIdadeSuperior60 = 0;
            int somaIdadesMulheres = 0;
            double mediaIdadesMulheres = 0;

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"Dados da pessoa {i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Sexo (M/F): ");
                char sexo = Console.ReadLine().ToUpper()[0];
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());

                if (sexo == 'M')
                {
                    numHomens++;
                }
                else if (sexo == 'F')
                {
                    numMulheres++;
                    somaIdadesMulheres += idade;
                }

                if (idade < 30)
                {
                    numIdadeInferior30++;
                }
                else if (idade > 60)
                {
                    numIdadeSuperior60++;
                }
            }

            mediaIdadesMulheres = (double)somaIdadesMulheres / numMulheres;

            Console.WriteLine($"Número de pessoas do sexo masculino: {numHomens}");
            Console.WriteLine($"Número de pessoas do sexo feminino: {numMulheres}");
            Console.WriteLine($"Número de pessoas com idade inferior a 30 anos: {numIdadeInferior30}");
            Console.WriteLine($"Número de pessoas com idade superior a 60 anos: {numIdadeSuperior60}");
            Console.WriteLine($"Média de idade das mulheres: {mediaIdadesMulheres:F2}");
        }
    }
}