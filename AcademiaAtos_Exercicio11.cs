namespace academiaAtos_Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
            // a média aritmética da turma e a quantidade de alunos da turma. Usar - 1 para encerrar a leitura.

            double sum = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            int count = 0;

            Console.WriteLine("Digite as notas dos alunos (digite -1 para encerrar):");

            while (true)
            {
                double nota = double.Parse(Console.ReadLine());

                if (nota == -1)
                {
                    break;
                }

                count++;
                sum += nota;
                max = Math.Max(max, nota); // armazena a nota mais alta
                min = Math.Min(min, nota); // armazena a nota mais baixa
            }

            if (count > 0)
            {
                double media = sum / count;
                Console.WriteLine($"Nota mais alta: {max}");
                Console.WriteLine($"Nota mais baixa: {min}");
                Console.WriteLine($"Média da turma: {media}");
                Console.WriteLine($"Quantidade de alunos: {count}");
            }
            else
            {
                Console.WriteLine("Nenhuma nota foi digitada.");
            }
        }
    }
}