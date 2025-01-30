using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a calculadora! O que deseja calcular?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Número par ou ímpar");
            Console.WriteLine(" ");
            Console.WriteLine("6 - Sair");

            Console.WriteLine("-----------");
            Console.WriteLine("Selecione a operação:");
            short sel = Convert.ToInt16(Console.ReadLine());

            switch (sel)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Par(); break;
                case 6: System.Environment.Exit(0); break; // Ambiente do Sistema.Sair (exit pede parametro de saida, e 0 é sucesso)
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("CALCULO DE SOMA");
            Console.WriteLine("Digite um valor:");
            float n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro valor:");
            float n2 = Convert.ToInt32(Console.ReadLine());

            float resultado = n1 + n2;
            Console.WriteLine($"O resultado da soma é {resultado}.");
            Console.ReadKey(); // faz a execução nao parar pós ultima ação, só para dps de dar enter
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("CALCULO DE SUBTRAÇÃO");
            Console.WriteLine("Digite um valor:");
            float n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro valor:");
            float n2 = Convert.ToInt32(Console.ReadLine());

            float resultado = n1 - n2;

            Console.WriteLine($"O resultado da subtração é {resultado}.");
            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("CALCULO DE DIVISÃO");
            Console.WriteLine("Digite um valor:");
            float n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro valor:");
            float n2 = Convert.ToInt32(Console.ReadLine());

            float resultado = n1 / n2;

            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("CALCULO DE MULTIPLICAÇÃO");
            Console.WriteLine("Digite um valor:");
            float n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro valor :");
            float n2 = Convert.ToInt32(Console.ReadLine());

            float resultado = n1 * n2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Par()
        {
            Console.Clear();
            Console.WriteLine("DESCUBRA SE O NÚMERO É PAR OU IMPAR");
            Console.WriteLine("Digite um valor:");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor == 0)
            {
                Console.WriteLine("0 é neutro papai.");
            }
            else if (valor % 2 != 0)
            {
                Console.WriteLine($"o número {valor} é impar");
            }
            else
            {
                Console.WriteLine($"o número {valor} é par");
            }
            Console.ReadKey();
            Menu();

        }


    }
}