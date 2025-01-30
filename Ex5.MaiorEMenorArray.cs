using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivoMaiorEMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 34) Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o fim dos dados.


            Console.WriteLine("Quantos números irá digitar?"); // define o tamanho do array
            int qtdNum = int.Parse(Console.ReadLine());

            int[] nums = new int[qtdNum];  // cria o array


            Console.Clear();

            Console.WriteLine("Digite números para verificar qual é maior"); 
            for (int i = 0; i < qtdNum; i++) // números para cada posição do array
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            foreach (int i in nums) //exibe o array
            {
                Console.WriteLine(i);
            }
;
            Console.WriteLine("");


            int maior = nums.Max(); //pega o maior valor do array
            int menor = nums.Min(); //pega o menor valor do array
            Console.WriteLine($"O maior numéro do conjunto é {maior} e o menor é {menor}");


        }
    }
}
