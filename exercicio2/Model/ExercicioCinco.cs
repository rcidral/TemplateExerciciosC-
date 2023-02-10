using System;

namespace NamespaceExercicioCinco
{
    public class ExercicioCinco
    {
        public static void ExercicioCincoTask()
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            for(int i = 0; i<palavra.Length; i++)
            {
                Console.WriteLine(palavra[i]);
            }
            
        }
    }
}