using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex3OrdenacaoEBusca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia 5 números inteiros e os armazene em um array. Depois de preenchido, ordene o array em ordem crescente e pergunte ao usuário um número para buscar. Informe se o número está no array e sua posição.
            int[] nums = new int[5];

            // obtendo os numeros inteiros
            Console.WriteLine("Digite 5 números inteiros.");
            for (int i = 0; i < 5; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            // ordenando os numeros
           
            Array.Sort(nums);

            foreach (int i in nums) //faz passar por todo o array
            {
                Console.WriteLine(i);
            }

            Thread.Sleep(1000);
            Console.Clear();
            // bucsa um numero e o encontra no array

            Console.WriteLine("Digite um número para buscar");
            int busca = int.Parse(Console.ReadLine());

            if (nums.Contains(busca))
            {
                Console.Clear();
                int posicao = Array.IndexOf(nums, busca); // retorna o indice onde no array (nums) o numero (busca) desejado
                Console.WriteLine($"O número {busca} está no array, na posição {posicao}");
                Console.WriteLine("");

                foreach (int i in nums) //faz passar por todo o array
                {
                    Console.WriteLine(i);
                }
            } else
            {
                Console.Clear();
                Console.WriteLine($"O número {busca} não está no array!");
            }

        }
    }
}
