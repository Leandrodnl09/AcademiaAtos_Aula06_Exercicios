using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace AcademiaAtos_Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.Faça um programa em C# que solicite o nome, a idade e o salário de uma pessoa.
            //A cada solicitação, teste se o usuário informou um valor válido. 
            //Por exemplo: se o nome não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            //informe que ele está incorreto e saia do programa.
            //Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
            //informe que está errada e saia.Se estiver correta, solicite o salário.
            //Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
            //Se estiver correto, mostre todos os valores lidos.

            
                

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            bool temNumero = nome.Any(char.IsDigit);
            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome) || temNumero == true)
            {
                Console.WriteLine("Dados incorretos.");
            }

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade <= 0)
            {
                Console.WriteLine("Dados incorretos.");
            }

            Console.Write("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine());
            if (salario <= 0)
            {
                Console.WriteLine("Dados incorretos.");
            }
            else
            {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Idade: {idade}");
                Console.WriteLine($"Salário: {salario:C}");
            }
        }
    }
}