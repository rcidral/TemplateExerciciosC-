using System;

namespace NamespaceExercicioQuatro
{
    public class ExercicioQuatro
    {
        public static void ExercicioQuatroTask()
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            for(int i = 0; i<=10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero*i));
            }
        }
    }
}