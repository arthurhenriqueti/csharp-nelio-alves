using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Saída #1");
            //Console.Write("Saída #2");

            string nome = "Arthur";
            int idade = 25;
            double saldo = 34.567;

            Console.WriteLine("Nome: " + nome + " | Idade: " + idade + " | Saldo: " + saldo.ToString("F2"));
            Console.WriteLine("Nome: {0} | Idade: {1} | Saldo: {2}", nome, idade, saldo.ToString("F2"));
            Console.WriteLine($"Nome: {nome} | Idade: {idade} | Saldo: {saldo:F2}");
            Console.WriteLine($"Nome: {nome} | Idade: {idade} | Saldo: {saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.WriteLine("Exercício #1");
            Console.WriteLine();

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade2 = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, custa $ {preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, custa $ {preco2.ToString("F2")}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade2} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida: {medida.ToString("F8")}");
            Console.WriteLine($"Arredondado: {medida.ToString("F3")}");
            Console.WriteLine($"Separador: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}