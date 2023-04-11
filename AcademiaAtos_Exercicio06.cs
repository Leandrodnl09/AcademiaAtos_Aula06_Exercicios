namespace AcademiaAtos_Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
            // ou seja, repita a leitura até que ela esteja correta(maior do que zero). 
            // Ao final, mostre a idade digitada.

            int idade;

            do
            {
                Console.Write("Informe a idade: ");
                idade = int.Parse(Console.ReadLine()); // Lê a idade informada pelo usuário e converte para inteiro

                if (idade <= 0)
                { // Verifica se a idade é menor ou igual a zero
                    Console.WriteLine("Idade inválida! A idade deve ser um número maior que zero!.");
                }
            } while (idade <= 0); // Repete a leitura enquanto a idade for menor ou igual a zero

            Console.WriteLine("Idade digitada: " + idade); // Exibe a idade informada pelo usuário
        }
    }
}