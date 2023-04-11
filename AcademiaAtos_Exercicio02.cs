namespace AcademiaAtos_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
            // informar um outro número. Caso positivo, o programa em VS deve ser repetido.


            // Exemplo:
            //            Digite um número inteiro positivo: 8
            // Numero digitado: 8
            // Números inteiros pares entre 1 e 8: 2, 4, 6.


            // Deseja informar outro número(s/ n)? S

            // Digite um número inteiro positivo: 12
            // Numero digitado: 20
            // Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


            // Deseja informar outro número(s/ n)? N

            do
            {
                int num;

                // Loop para solicitar o número até que seja fornecido um valor correto
                while (true)
                {
                    Console.Write("Digite um número inteiro positivo: ");
                    if (int.TryParse(Console.ReadLine(), out num) && num > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
                }

                Console.Write("Números pares entre 1 e " + num + ": ");

                // Loop para exibir todos os números pares entre 1 e o número fornecido
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.WriteLine();

                // Pergunta se o usuário deseja informar outro número
                Console.Write("Deseja informar outro número? (S/N) ");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() != "s")
                {
                    break;
                }

            } while (true);

            Console.WriteLine("Programa encerrado.");
        }
    }
}