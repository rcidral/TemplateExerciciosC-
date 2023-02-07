using System;

namespace NamespaceExercicioQuatro
{
    public class ExercicioQuatro
    {
        public static void ExercicioQuatroTask()
        {
            Console.WriteLine("Digite o valor de A: ");
            double valorA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double valorB = double.Parse(Console.ReadLine());
            if(valorA > (valorB)*2)
            {
                Console.WriteLine("A é maior que B");
            }
            else
            {
                Console.WriteLine("A não é maior que B");
            }
        }
    }
}