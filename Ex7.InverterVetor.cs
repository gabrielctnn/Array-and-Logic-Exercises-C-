using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorInteirosInverso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 45) Dada uma seqüência de n números(vetor de inteiros), imprimi - la na ordem inversa que foi realizada a leitura

            Console.WriteLine("Digite uma quantidade de números que irá digitar:");
            int qtd = int.Parse(Console.ReadLine());

            int[] nums = new int[qtd];

            Console.Clear();

            Console.WriteLine("Digite números para verificar qual é maior");
            for (int i = 0; i < qtd; i++) // números para cada posição do array
            {
                nums[i] = int.Parse(Console.ReadLine());
            }


            Console.Clear();
           Array.Reverse(nums);
            foreach (int i in nums) {
                Console.WriteLine(i);
            }
        }
    }
}
