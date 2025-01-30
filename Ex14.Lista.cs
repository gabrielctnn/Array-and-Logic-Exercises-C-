using System;

namespace Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            var meuArray = new int[5];  // cria um array(lista) com 5 posições (0,1,2,3,4)
            //{ 1, 2, 3, 4, 5 }; // e caso queiramos colocar os valores nas posições usamos os = { , }

            var funcionarios = new Funcionario[3];
            funcionarios[0] = new Funcionario() { Id = 0001, Nome = "Carlos", Cargo = "Dev" };
            funcionarios[1] = new Funcionario() { Id = 2456, Nome = "Samuka", Cargo = "Hacker" };
            funcionarios[2] = new Funcionario() { Id = 1613, Nome = "Verrisimo", Cargo = "Chefe" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
                Console.WriteLine(funcionario.Cargo);
                Console.WriteLine("");

            }




            // EXECEPTION 

            var arr = new int[3];

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                //     Console.WriteLine(arr[index]);
                //     //retorna erro : System.IndexOutOfRangeException
                // }

                Cadastrar("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Nao encontrei o indice na lista!");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha no cadastro do texto!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Nao encontrei o indice na lista!");
            } finally {
                Console.WriteLine("Concluído!");
            }


        }

        public static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio!Tente novamente.");
            }
        }
    }
}

public struct Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cargo { get; set; }


}