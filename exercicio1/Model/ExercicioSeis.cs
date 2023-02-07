using System;

namespace NamespaceExercicioSeis
{
    public class ExercicioSeis
    {
        public static void ExercicioSeisTask()
        {
            Console.WriteLine("Digite a distancia em KM: ");
            double distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo em horas: ");
            double tempo = double.Parse(Console.ReadLine());
            double velocidade = distancia / tempo;
            Console.WriteLine("A velocidade média é: " + velocidade);
        }
    }
}