using System;

namespace NamespaceExercicioOito
{
    public class ExercicioOito
    {
        public static void ExercicioOitoTask()
        {
            string[] linhas = System.IO.File.ReadAllLines("./multiplicacao.txt");
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(linhas[i]);
            }

        }
    }
}