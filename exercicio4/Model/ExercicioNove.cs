using System;

namespace NamespaceExercicioNove
{
    public class ExercicioNove
    {
 
        public static void ExercicioNoveTask()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[20];
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "º valor do primeiro array: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "º valor do segundo array: ");
                array2[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i<10; i++)
            {
                array3[i] = array1[i];
                array3[i+10] = array2[i];
            }
            for(int i = 0; i<20; i++)
            {
                Console.WriteLine(array3[i]);
            }
        }
    }
}