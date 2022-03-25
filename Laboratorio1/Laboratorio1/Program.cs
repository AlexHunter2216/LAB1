using System;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosCliente Cliente = new DadosCliente();

            Console.WriteLine("Insira seu Nome: ");
            string Nome1 = Console.ReadLine();
            Cliente.Nome = Nome1;
            Console.WriteLine("...");
            Console.WriteLine("Insira sua idade: ");
            int Idade1 = Convert.ToInt32(Console.ReadLine());
            Cliente.Idade = Idade1;
            Console.WriteLine("...");
            Console.WriteLine("Insira a sua altura: ");
            double Altura1 = Convert.ToDouble(Console.ReadLine());
            Cliente.Altura = Altura1;
            Console.WriteLine("...");
            Console.WriteLine("Insira seu peso: ");
            double Peso1 = Convert.ToDouble(Console.ReadLine());
            Cliente.Peso = Peso1;
            Console.WriteLine($"Nome do Cliente: {Nome1}");
            Console.WriteLine("");
            Console.WriteLine($"Idade do Cliente: {Idade1}");
            Console.WriteLine("");
            Console.WriteLine($"Altura do Cliente: {Altura1}");
            Console.WriteLine("");
            Console.WriteLine($"Peso do Cliente: {Peso1}");
            Console.WriteLine($"...");
            Cliente.CalculoIMC();
            Console.WriteLine("");
            Cliente.Situação();
            Console.WriteLine("");
            Cliente.Meta();
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
