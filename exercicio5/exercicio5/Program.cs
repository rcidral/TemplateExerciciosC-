using System;

namespace NamespaceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            NamespaceCircunferencia.Circunferencia circunferencia = new NamespaceCircunferencia.Circunferencia(10);
            Console.WriteLine("A área da circunferência é: " + circunferencia.area());
            Console.ReadLine();
        }
    }
}
