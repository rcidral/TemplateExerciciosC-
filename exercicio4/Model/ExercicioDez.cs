using System;

namespace NamespaceExercicioDez
{
    public class ExercicioDez
    {
        //public static void ExercicioDezTask(string[] args)
        // só argumentei pq tava dando erro de build :)
        public static void ExercicioDezTask()
        {
            double[] valores = new double[20];
            double soma = 0;
            for(int i = 0; i<20; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "º valor: ");
                valores[i] = double.Parse(Console.ReadLine());
                soma += valores[i];
            }
            double media = soma/20;
            Console.WriteLine("A média aritmética dos valores é: " + media);
            for(int i = 0; i<20; i++)
            {
                if(valores[i] < media)
                {
                    Console.WriteLine(valores[i] + " é menor que a média");
                }
            }
        }
    }
}