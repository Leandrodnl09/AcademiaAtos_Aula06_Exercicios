namespace AcademiaAtos_Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
            // coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 

            // a) média do salário da população;
            // b) média do número de filhos;
            // c) maior salário;
            // d) percentual de pessoas com salário até R$ 100,00.
            // O final da leitura de dados se dará com a entrada de um salário negativo.

            double salario, somaSalario = 0, mediaSalario, maiorSalario = 0;
            int numFilhos, somaNumFilhos = 0, mediaNumFilhos, numPessoasAte100 = 0, totalPessoas = 0;

            Console.WriteLine("Digite o salário: ");
            salario = double.Parse(Console.ReadLine());

            while (salario >= 0)
            {
                Console.WriteLine("Digite o número de filhos: ");
                numFilhos = int.Parse(Console.ReadLine());

                somaSalario += salario;
                somaNumFilhos += numFilhos;

                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }

                if (salario <= 100)
                {
                    numPessoasAte100++;
                }

                totalPessoas++;

                Console.WriteLine("Digite o salário: ");
                salario = double.Parse(Console.ReadLine());
            }

            if (totalPessoas > 0)
            {
                mediaSalario = somaSalario / totalPessoas;
                mediaNumFilhos = somaNumFilhos / totalPessoas;

                Console.WriteLine("Média do salário da população: " + mediaSalario.ToString("F2"));
                Console.WriteLine("Média do número de filhos: " + mediaNumFilhos.ToString("F2"));
                Console.WriteLine("Maior salário: " + maiorSalario.ToString("F2"));
                Console.WriteLine("Percentual de pessoas com salário até R$ 100,00: "
                    + ((numPessoasAte100 * 100.0) / totalPessoas).ToString("F2") + "%");
            }
        }
    }
}