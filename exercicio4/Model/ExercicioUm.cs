using System;

namespace NamespaceExercicioUm 
{
    public class ExercicioUm 
    {
        public static async void ExercicioUmTask() 
        {
            Console.WriteLine("Digite a quantidade de notas que deseja inserir: ");
            int quantidade = int.Parse(Console.ReadLine());
            double[] notas = new double[quantidade];
            double soma = 0;
            for(int i = 0; i<notas.Length; i++)
            {
                Console.WriteLine("Digite a " + (i+1) + " de " + quantidade + " notas: ");
                notas[i] = double.Parse(Console.ReadLine());
                soma += notas[i];
            }
            double media = soma/notas.Length;
            Console.WriteLine("A média das notas é: " + media);
           
        }
    }
}
