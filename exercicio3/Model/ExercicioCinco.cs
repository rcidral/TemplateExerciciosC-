using System;

namespace NamespaceExercicioCinco
{
    public class ExercicioCinco
    {
        public static void ExercicioCincoTask()
        {
            string[] nomes = new string[5];
            for(int i = 0; i<nomes.Length; i++)
            {
                Console.WriteLine("Digite o " + i+1 +" de cinco para ser aleatorizado: ");
                nomes[i] = Console.ReadLine();
            }        
            Random random = new Random();
            int index = random.Next(nomes.Length);
            for(int i = 0; i<nomes.Length; i++)
            {
                Console.WriteLine(nomes[index]);
            }
            
        }
    }
}