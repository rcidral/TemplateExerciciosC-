using System;

namespace NamespaceExercicioNove
{
    public class ExercicioNove
    {
        public static void ExercicioNoveTask()
        {
            Console.WriteLine("Digite o valor da string A: ");
            string valorA = Console.ReadLine();
            Console.WriteLine("Digite o valor da string B: ");
            string valorB = Console.ReadLine();
            if(valorA == valorB)
            {
                Console.WriteLine("As strings são iguais");
            }
            else
            {
                Console.WriteLine("As strings são diferentes");
            }
        }
    }
}