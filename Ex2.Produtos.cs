using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa que leia o nome e o preço de 10 produtos. Logo após realizar o cadastro dos produtos, pedir para o usuário digitar um valor, no qual deverá ser realizada uma pesquisa e exibir apenas os produtos que possuem preço até o valor digitado pelo usuário.

            string[] nomeProd = new string[10];
            double[] precoProd = new double[10];
            object[,] produtos = new object[10, 2];

            // cadastro nome e preço  dos produtos
            Console.WriteLine("Digite o nome e o preço de 10 produtos em estoque");
        
            for (int linha = 0; linha < 10; linha++)
            {
                Console.WriteLine($"Produto {linha + 1}: ");
                nomeProd[linha] = Console.ReadLine();

                Console.WriteLine($"Preço do {nomeProd[linha]}");
                precoProd[linha] = double.Parse(Console.ReadLine());
                Console.Clear();

            }

            Console.Clear();

            // tabela dos produtos
            for (int linha = 0; linha < 10; linha++)
            {
                Console.WriteLine($"Produto {nomeProd[linha]} - Preço: {precoProd[linha]:F2}");
            }

            Console.WriteLine("");
            Console.WriteLine("Agora, digite o máximo que você pode gastar, e mostraremos qual produto poderá comprar.");
            double maxCost = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Você pode comprar esses produtos com {maxCost}:");
            for (int linha = 0; linha < 10; linha++)
            {
               
                if (precoProd[linha] <= maxCost)
                {
                    Console.WriteLine($"Produto {nomeProd[linha]} - Preço: {precoProd[linha]:F2}");
                }
            }
        }
    }

}



