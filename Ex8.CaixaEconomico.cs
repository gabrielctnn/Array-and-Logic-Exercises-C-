using System;
using System.Runtime.InteropServices;

namespace CaixaEconomico
{
    class Program
    {
        private static double saldo = 10.50;

        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo(a) ao Caixa Econômico!");
            Thread.Sleep(1600);
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Depositar");
            Console.WriteLine(" ");
            Console.WriteLine("0 - Fechar");
            Console.WriteLine(" ");

            int chosse = Convert.ToInt32(Console.ReadLine());

            switch (chosse)
            {
                case 1: Saldo(); break;
                case 2: Sacar(); break;
                case 3: Depositar(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }


        public static void Saldo()
        {
            Console.Clear();
            Console.WriteLine("SALDO");
            Console.WriteLine(" ");
            Console.WriteLine($"O seu saldo atual é de {saldo}");

            ContinuarOP();
        }
        static void Sacar()
        {
            Console.Clear();
            Console.WriteLine("SACAR DINHEIRO");
            Console.WriteLine(" ");

            Console.WriteLine("Quanto você deseja sacar?");

            double sacar = Convert.ToDouble(Console.ReadLine());

            if (sacar > saldo)
            {
                Console.Clear();
                Console.WriteLine("Você não pode sacar mais do que você tem!");
                Console.WriteLine(saldo);
                Console.ReadKey();
                Sacar();
            }
            else
            {
                saldo = saldo - sacar;
            }

            Console.WriteLine($"O seu saldo atual agora é de {saldo}");

            ContinuarOP();
        }
        static void Depositar()
        {
            Console.Clear();
            Console.WriteLine("DEPOSITAR DINHEIRO");
            Console.WriteLine(" ");

            Console.WriteLine("Quanto você deseja depositar?");

            double depositar= Convert.ToDouble(Console.ReadLine());

            saldo = saldo + depositar;

           

            Console.WriteLine($"O seu saldo atual agora é de {saldo}");

            ContinuarOP();
        }

        static void ContinuarOP()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Deseja continuar a operação? (s ou n )");

            var hour = DateTime.Now.Hour;
            var msgDespedida = " ";

            if (hour < 12)
            {
                msgDespedida = "bom dia!";
            }
            else if (hour >= 12 && hour > 18)
            {
                msgDespedida = "boa tarde!";
            }
            else
            {
                msgDespedida = "boa noite!";
            }


            var chosse = Console.ReadLine();
            if (chosse != "s")
            {
                Console.WriteLine($"Obrigado! Tenha uma {msgDespedida}");
                Thread.Sleep(1500);
                System.Environment.Exit(0);
            }
            else
            {
                Menu();
            }
        }

    }
}