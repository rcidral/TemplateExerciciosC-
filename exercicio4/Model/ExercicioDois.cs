using System;

namespace NamespaceExercicioDois
{
    public class ExercicioDois
    {
        public static async void ExercicioDoisTask()
        {
            Console.WriteLine("Programa que imprima arrays com foreach");
            int[] array = new int[10];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            array[5] = 6;
            array[6] = 7;
            array[7] = 8;
            array[8] = 9;
            array[9] = 10;
            array[10] = 11;
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}