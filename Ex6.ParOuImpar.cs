using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PositivoParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 31) Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar.Exiba ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos. Suporemos que o  número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o fim dos dados.

            Console.WriteLine("Quantos números irá digitar?");
            int qtdNum = int.Parse(Console.ReadLine());

            int[] nums = new int [qtdNum];
     

            Console.Clear();

            Console.WriteLine("Digite números para verificar se é par e somaremos todos os pares com pares e impares com impares");
            for (int i = 0; i < qtdNum; i++) {
                nums[i] = int.Parse(Console.ReadLine());
                
             }

            Console.Clear();

            int somaPares = 0 ;
            int somaImpares = 0;
            foreach (int i in nums)
            {
                if (i % 2 == 0 )
                {
                    Console.WriteLine($"{i} é par");
                    somaPares += i;
                } else
                {
                    Console.WriteLine($"{i} é impar");
                    somaImpares += i;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Soma pares : {somaPares} e Soma impares : {somaImpares}");
        }
    }
}
