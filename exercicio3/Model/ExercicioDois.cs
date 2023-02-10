using System;

namespace NamespaceExercicioDois
{
    public class ExercicioDois
    {
        public static async void ExercicioDoisTask()
        {
            string text = await File.ReadAllTextAsync("multiplicacao.txt");
            Console.WriteLine(text);
        }
    }
}