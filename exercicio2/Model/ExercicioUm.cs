using System;

namespace NamespaceExercicioUm 
{
    public class ExercicioUm 
    {
        public static void ExercicioUmTask() 
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());
            double media = (nota1 + nota2 + nota3) / 3;
            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
