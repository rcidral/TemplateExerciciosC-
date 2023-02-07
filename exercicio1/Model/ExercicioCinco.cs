using System;

namespace NamespaceExercicioCinco
{
    public class ExercicioCinco
    {
        public static void ExercicioCincoTask()
        {
            Console.WriteLine("Digite o valor de A: ");
            double valorA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double valorB = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double valorC = double.Parse(Console.ReadLine());
            double delta = (valorB * valorB) - (4 * valorA * valorC);
            if (delta < 0)
            {
                Console.WriteLine("Não existe raiz");
            }
            else
            {
                double raiz1 = (-valorB + Math.Sqrt(delta)) / (2 * valorA);
                double raiz2 = (-valorB - Math.Sqrt(delta)) / (2 * valorA);
                Console.WriteLine("Raiz 1: " + raiz1);
                Console.WriteLine("Raiz 2: " + raiz2);
            }
        }
    }
}