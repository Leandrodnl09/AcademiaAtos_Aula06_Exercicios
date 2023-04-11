using System.Security.Cryptography;
using System;

namespace AcademiaAtos_Exercicio009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
            // o zoológico num determinado dia, imprimindo:
            // Quantas pessoas tem entre 1 e 3 filhos.
            // Quantas pessoas tem entre 4 e 7 filhos.
            // Quantas pessoas tem mais de 8 filhos.
            // Quantas pessoas não tem filhos.

            int[] filhos = new int[30]; // cria um array para armazenar a quantidade de filhos de cada pessoa
            int[] faixas = new int[4]; // cria um array para armazenar a quantidade de pessoas em cada faixa de filhos

            // lê a quantidade de filhos de cada pessoa e incrementa a contagem da faixa correspondente
            for (int i = 0; i < filhos.Length; i++)
            {
                Console.Write($"Digite a quantidade de filhos da pessoa {i + 1} que visitou o zoológico: ");
                int qtdFilhos = int.Parse(Console.ReadLine());

                if (qtdFilhos == 0)
                {
                    faixas[0]++;
                }
                else if (qtdFilhos >= 1 && qtdFilhos <= 3)
                {
                    faixas[1]++;
                }
                else if (qtdFilhos >= 4 && qtdFilhos <= 7)
                {
                    faixas[2]++;
                }
                else
                {
                    faixas[3]++;
                }
            }

            // imprime a quantidade de pessoas em cada faixa de filhos
            Console.WriteLine($"Quantidade de pessoas sem filhos: {faixas[0]}");
            Console.WriteLine($"Quantidade de pessoas com 1 a 3 filhos: {faixas[1]}");
            Console.WriteLine($"Quantidade de pessoas com 4 a 7 filhos: {faixas[2]}");
            Console.WriteLine($"Quantidade de pessoas com mais de 8 filhos: {faixas[3]}");
        }
    }
}