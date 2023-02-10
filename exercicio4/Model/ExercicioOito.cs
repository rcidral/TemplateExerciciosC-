using System;

namespace NamespaceExercicioOito
{
    public class ExercicioOito
    {
        public static void ExercicioOitoTask()
        {
            double[] temperaturas = new double[12];
            double soma = 0;
            for(int i = 0; i<12; i++)
            {
                Console.WriteLine("Digite a temperatura média do mês " + (i+1) + ": ");
                temperaturas[i] = double.Parse(Console.ReadLine());
                soma += temperaturas[i];
            }
            double media = soma/12;
            Console.WriteLine("A média anual das temperaturas é: " + media);

        }
    }
}