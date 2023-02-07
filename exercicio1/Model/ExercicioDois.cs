using System;

namespace NamespaceExercicioDois
{
    public class ExercicioDois
    {
        public static void ExercicioDoisTask()
        {
            Console.WriteLine("Digite o lado A: ");
            double ladoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado B: ");
            double ladoB = double.Parse(Console.ReadLine());
            double area = ladoA * ladoB;
        }
    }
}