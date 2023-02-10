using System;

namespace NamespaceExercicioSeis
{
    public class ExercicioSeis
    {
        public static void ExercicioSeisTask()
        {
            Console.WriteLine("Soma de todos os números impares e múltiplos de 7 entre 1 e 500");
            int soma = 0;
            for(int i = 1; i<=500; i++)
            {
                if(i%2 != 0 && i%7 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("A soma é: " + soma);
            
        }
    }
}