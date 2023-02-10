using System;

namespace NamespaceExercicioQuatro
{
    public class ExercicioQuatro
    {
        public static void ExercicioQuatroTask()
        {
            int[] valores = new int[10];
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "º valor: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i<10; i++)
            {
                if(valores[i]%2 == 0)
                {
                    Console.WriteLine(valores[i] + " é par");
                }
                else
                {
                    Console.WriteLine(valores[i] + " é impar");
                }
            }
        }
    }
}