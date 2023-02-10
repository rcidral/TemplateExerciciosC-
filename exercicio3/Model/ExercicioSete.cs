using System;

namespace NamespaceExercicioSete
{
    public class ExercicioSete
    {
        public static void ExercicioSeteTask()
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            if(frase.Contains("JAVA"))
                Console.WriteLine("A frase contém a palavra JAVA");
            else
                Console.WriteLine("A frase não contém a palavra JAVA");
        }
    }
}