using System;

namespace NamespaceExercicioSete
{
    public class ExercicioSete
    {
        public static void ExercicioSeteTask()
        {
            Console.WriteLine("Digite o faturamento: ");
            double faturamento = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do imposto: ");
            double imposto = double.Parse(Console.ReadLine());
            double percentualImposto = (imposto / faturamento);
            Console.WriteLine("O percentual de imposto é: " + percentualImposto);
        }
    }
}