using System;

namespace ConversaoDeTipos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversão implícita:");
            byte valor1 = 10;
            int valor2 = valor1;

            int valor3 = 10;
            double valor4 = valor3;

            Console.WriteLine(valor2);
            Console.WriteLine(valor4);

            Console.WriteLine("Conversão explícita:");
            int valor5 = 10;
            byte valor6 = (byte) valor5;

            double valor7 = 15.5;
            int valor8 = (int) valor7;

            Console.WriteLine(valor6);
            Console.WriteLine(valor8);
        }
    }
}