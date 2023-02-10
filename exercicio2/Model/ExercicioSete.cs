using System;

namespace NamespaceExercicioSete
{
    public class ExercicioSete
    {
        public static void ExercicioSeteTask()
        {
            double nota = 0;
            List<double> notas = new List<double>();
            do {
                Console.WriteLine("Digite uma nota: ");
                nota = double.Parse(Console.ReadLine());
                if(nota > 0)
                {
                    notas.Add(nota);
                }
            }while( nota >= 0 );
            double soma = 0;
            foreach(double n in notas)
            {
                soma += n;
            }
            Console.WriteLine("A média é: " + (soma/notas.Count));
        }
    }
}