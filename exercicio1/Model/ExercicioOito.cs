using System;

namespace NamespaceExercicioOito
{
    public class ExercicioOito
    {
        public static void ExercicioOitoTask()
        {
            Console.WriteLine("Digite o valor: ");
            double valorA = double.Parse(Console.ReadLine());
            if(valorA %2 == 0)
            {
                Console.WriteLine("O valor é par");
            }
            else
            {
                Console.WriteLine("O valor é ímpar");
            }
        }
    }
}