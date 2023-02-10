using System;

namespace NamespaceExercicioDez
{
    public class ExercicioDez
    {
        //public static void ExercicioDezTask(string[] args)
        // só argumentei pq tava dando erro de build :)
        public static void ExercicioDezTask()
        {
            string text = "";
            //string text = args;
            int soma = 0;
            string[] linhas = System.IO.File.ReadAllLines(text);
            for(int i = 0; i<10; i++)
            {
                soma += int.Parse(linhas[i]);
            }
            Console.WriteLine("Soma: " + soma);
        }
    }
}