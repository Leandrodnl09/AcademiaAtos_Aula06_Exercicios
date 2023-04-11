namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
            // Se o usuário digitar 0 o programa em VS deve parar. 
            // Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.

            int num;
            do
            {
                Console.Write("Digite um número (digite 0 para sair): ");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                string parImpar = num % 2 == 0 ? "PAR" : "IMPAR";
                bool primo = true;
               
                // Verifica se o número é primo
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                string primoStr = primo ? "Número Primo" : "Não Primo";

                Console.WriteLine("{0} é {1} e {2}.", num, parImpar, primoStr);

            } while (true);
        }
    }
}