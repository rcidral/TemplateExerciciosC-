using System;

namespace NamespaceExercicioTres
{
    public class ExercicioTres
    {
        public static void ExercicioTresTask()
        {
            double[] valores = new double[10];
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "º valor: ");
                valores[i] = double.Parse(Console.ReadLine());
            }
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
}