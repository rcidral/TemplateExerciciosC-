using System;

namespace NamespaceExercicioDez
{
    public class ExercicioDez
    {
        public static void ExercicioDezTask()
        {
            Console.WriteLine("Digite o valor com ponto flutuante: ");
            string valorA = Console.ReadLine();
            Int32.Parse(valorA);
            Console.WriteLine("O convertido é: " + valorA);

        }
    }
}