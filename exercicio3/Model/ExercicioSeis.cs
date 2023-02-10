using System;

namespace NamespaceExercicioSeis
{
    public class ExercicioSeis
    {
        public static void ExercicioSeisTask()
        {
            Console.WriteLine("Digite o diametro: ");
            double diametro = double.Parse(Console.ReadLine());
            double raio = diametro/2;
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("A área do circulo é: " + area + " e o raio é: " + raio);
            
        }
    }
}