using System;

namespace TiposBasicos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Inteiros:");
            byte valor1 = 10; // +
            short valor2 = 20; // -/+
            int valor3 = 30; // -/+
            long valor4 = 40L; // -/+

            Console.WriteLine(valor1 + valor2 + valor3 + valor4);

            Console.WriteLine("Ponto flutuante:");
            float valor5 = 50.5F; // -/+
            double valor6 = 60.5; // -/+
            decimal valor7 = 70.5M; // -/+

            Console.WriteLine(valor5);
            Console.WriteLine(valor6);
            Console.WriteLine(valor7);

            Console.WriteLine("Carácter (Unicode):");
            char sexo = 'M';

            Console.WriteLine(sexo);

            Console.WriteLine("Booleano:");
            bool estaChovendo = true; // true/false

            Console.WriteLine(estaChovendo);

            Console.WriteLine("String:");
            string nome = "Arthur";

            Console.WriteLine(nome);

            Console.WriteLine("Inteiros (Existentes apenas no C#):");
            sbyte valor8 = 10; // -/+
            ushort valor9 = 20; // +
            uint valor10 = 30; // +
            ulong valor11 = 40L; // +

            Console.WriteLine(valor8);
            Console.WriteLine(valor9);
            Console.WriteLine(valor10);
            Console.WriteLine(valor11);

            Console.WriteLine("Object:");
            object nome2 = "Alex";
            object valor12 = 10.5F;

            Console.WriteLine(nome2);
            Console.WriteLine(valor12);

            Console.WriteLine("Camel Case: lastName -> Parâmetros e Variáveis!");
            Console.WriteLine("Pascal Case: LastName -> Namespaces, Classes, Propriedades e Métodos!");
        }
    }
}