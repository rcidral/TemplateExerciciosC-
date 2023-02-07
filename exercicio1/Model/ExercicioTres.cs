using System;

namespace NamespaceExercicioTres
{
    public class ExercicioTres
    {
        public static void ExercicioTresTask()
        {
            Console.WriteLine("Digite a largura: ");
            double largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            double alura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a profundidade: ");
            double profundidade = double.Parse(Console.ReadLine());
            double volume = largura * alura * profundidade;
            Console.WriteLine("O volume é: " + volume);
        }
    }
}