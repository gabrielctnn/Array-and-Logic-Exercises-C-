using System;
using System.Threading;

namespace Cronometro
{
    class Program 
    {
        static void Main() 
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Bem vindo ao Cronômetro!");
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("s = Segundo => Ex.10s");
            Console.WriteLine("m = Minuto => Ex.10m");
            Console.WriteLine("0 = Sair");

            string data = Console.ReadLine().ToLower(); // ToLower converte tudo para caracteres minusculas
            char type = char.Parse(data.Substring(data.Length - 1,1));  //todo metodo q é uma string, ele tem um metodo substring que pode pegar uma parte da string, que é (valor inicial, quantiade de caracteres que quremos pegar) no  caso data.Length-1 pega a quantidade de caracteres e tira 1 e pegando a ultima caracater
            int time = int.Parse(data.Substring(0,data.Length-1)); //aqui pegamos desde a caracter 0 até a penultima tirando a ultima que seria o tipo do tempo
            int multiplier = 1; 

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Contando em ......");
            Thread.Sleep(1000);
            Console.WriteLine("3....");
             Thread.Sleep(1000);
            Console.WriteLine("2....");
             Thread.Sleep(1000);
            Console.WriteLine("1....");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time){
            int currentTime = 0; 
            while (currentTime != time ) {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //execução atual, no caso fala para a execução atual dormir por 1000milisegundos ou 1s adicionando um delay.
            }
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado.");
            Thread.Sleep(2500);
            Menu();
        }


    }
}